using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerHelper.DB
{
    public class DBController
    {
        public delegate void Message(string message);

        public static event Message onError;


        private static User _user = new User();

        private Time_entries _timeEntries = new Time_entries();

        private Issues _dbIssues = new Issues();
        private Issues _rmIssues = new Issues();
        private Issues _updatedIssues = new Issues();

        public DBController(User user)
        {
            _user = user;
        }

        public void UpdateTimeEntries(int retries, int numOfDays)
        {
            GetRmTimeEntries(retries, numOfDays);
            DBman.InsertTE(_timeEntries);
        }

        public void UpdateIssues(int Retries, int NumofDaysSinceLastUpdate)
        {
            IssueComparer comparer = new IssueComparer();            

            GetRmIssues(Retries, NumofDaysSinceLastUpdate);
            DBman.GetOpenedIssues(_dbIssues, NumofDaysSinceLastUpdate+1);

            _user.Issues.issue = _rmIssues.issue.Except(_dbIssues.issue, comparer).ToList();

            GetJournals();
            DBman.InsertIssues(_user.IssuesUpdated);
        }

        private void GetRmTimeEntries(int retries, int numofDays)
        {
            ResultModel resultModel = new ResultModel();
            string filter = $"from={DateTime.Now.AddDays(-numofDays).ToString("yyyy-MM-dd")}&to={DateTime.Now.ToString("yyyy-MM-dd")}";
            int _retries = 0;
            do
            {//http://tracker.ucs.ru/time_entries.xml?limit=100&key=1287ca3310be20d6992a764b57f9c8bcfbb05664&from=2017-01-01&to=2017-12-31
                string url = $@"{_user.BaseAddress}time_entries.xml?&offset={_timeEntries.offset}&limit=100&key=1287ca3310be20d6992a764b57f9c8bcfbb05664&{filter}";
                resultModel.IsSuccess = false;

                resultModel = Http.Get(url);
                if (resultModel.IsSuccess)
                {
                    if (_timeEntries.time_entry_list.Count > 0)
                    {
                        XML.Deserialize<Time_entries>(resultModel.Results).time_entry_list.ForEach(p => _timeEntries.time_entry_list.Add(p));
                        _retries = 0;
                    }
                    else
                    {
                        _timeEntries = XML.Deserialize<Time_entries>(resultModel.Results);
                    } // IncOffset увеличивает offset на величину limit при каждом вызове.
                    _timeEntries.IncOffset();
                }
                else
                {// в случае если запрос к redmine не был успешным сделать повторный запрос с теми же параметрами
                    _retries++;
                    if (_retries == retries)
                    {
                        onError?.Invoke($"No reply from host. Fetched {_timeEntries.time_entry_list.Count} time entries");
                        break;
                    }
                }
            }// счётчик - tracker.ucs.ru возвращает максимум 100 элементов, если кол-во total_count больше, необходимо сделать повторные запросы со смещением
            while (int.Parse(_timeEntries.offset) < int.Parse(_timeEntries.total_count));
        }

        private void GetRmIssues(int Retries, int NumofDaysSinceLastUpdate)
        {
            string filter = $@"set_filter=1&f[]=status_id&op[status_id]=*&f[]=updated_on&op[updated_on]=%3Et-&v[updated_on][]={NumofDaysSinceLastUpdate}";

            ResultModel resultModel = new ResultModel();
            int retries = 0;
            do
            {
                string url = $@"{_user.BaseAddress}issues.xml?utf8=%E2%9C%93&limit={_rmIssues.limit}&offset={_rmIssues.offset}&key={_user.ApiKey}&{filter}";
                resultModel.IsSuccess = false;

                resultModel = Http.Get(url);
                if (resultModel.IsSuccess)
                {
                    if (_rmIssues.issue.Count > 0)
                    {
                        XML.Deserialize<Issues>(resultModel.Results).issue.ForEach(p => _rmIssues.issue.Add(p));
                        retries = 0;
                    }
                    else
                    {
                        _rmIssues = XML.Deserialize<Issues>(resultModel.Results);
                    } // IncOffset увеличивает offset на величину limit при каждом вызове.
                    _rmIssues.IncOffset();
                }
                else
                {// в случае если запрос к redmine не был успешным сделать повторный запрос с теми же параметрами                    
                    if (retries == Retries)
                    {
                        onError?.Invoke($"No reply from host. Fetched {_rmIssues.issue.Count.ToString()} issues");
                        break;
                    }
                    retries++;
                }
            }// счётчик - tracker.ucs.ru возвращает максимум 100 элементов, если кол-во total_count больше, необходимо сделать повторные запросы со смещением
            while (int.Parse(_rmIssues.offset) < int.Parse(_rmIssues.total_count));          
        }


        private void GetUpdatedIssues()
        {

        }

        private void GetJournals()
        {
            for (int i = 0; i < _user.Issues.issue.Count; i++)
            {
                string url = $@"{_user.BaseAddress}issues/{_user.Issues.issue[i].id}.xml?include=journals&key={_user.ApiKey}";
                Issue issue = new Issue();
                issue = Issue.GetIssue(url);
                if (issue != null)
                    _user.IssuesUpdated.issue.Add(issue);
            }
        }
    }
}
