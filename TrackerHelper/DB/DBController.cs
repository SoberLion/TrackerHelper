using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerHelper.DB
{
    public class DBController
    {
        private static User _user = new User();

        private Issues dbIssues = new Issues();
        private Issues rmIssues = new Issues();
        private Issues updatedIssues = new Issues();

        public DBController(User user)
        {
            _user = user;
        }

        public void UpdateDB(int Retries, int NumofDaysSinceLastUpdate)
        {
            IssueComparer comparer = new IssueComparer();            

            GetRmIssues(Retries, NumofDaysSinceLastUpdate);
            DBman.GetOpenedIssues(dbIssues, NumofDaysSinceLastUpdate+1);

            _user.Issues.issue = rmIssues.issue.Except(dbIssues.issue, comparer).ToList();

            GetJournals();
            DBman.InsertIssues(_user.IssuesUpdated);
        }

        private void GetRmIssues(int Retries, int NumofDaysSinceLastUpdate)
        {
            string filter = $@"set_filter=1&f[]=status_id&op[status_id]=*&f[]=updated_on&op[updated_on]=%3Et-&v[updated_on][]={NumofDaysSinceLastUpdate}";

            ResultModel resultModel = new ResultModel();
            int retries = 0;
            do
            {
                string url = $@"{_user.BaseAddress}issues.xml?utf8=%E2%9C%93&limit={rmIssues.limit}&offset={rmIssues.offset}&key={_user.ApiKey}&{filter}";
                resultModel.IsSuccess = false;

                resultModel = Http.Get(url);
                if (resultModel.IsSuccess)
                {
                    if (rmIssues.issue.Count > 0)
                    {
                        XML.Deserialize<Issues>(resultModel.Results).issue.ForEach(p => rmIssues.issue.Add(p));
                        retries = 0;
                    }
                    else
                    {
                        rmIssues = XML.Deserialize<Issues>(resultModel.Results);
                    } // IncOffset увеличивает offset на величину limit при каждом вызове.
                    rmIssues.IncOffset();
                }
                else
                {// в случае если запрос к redmine не был успешным сделать повторный запрос с теми же параметрами                    
                    if (retries == Retries)
                    {
                        break;
                    }
                    retries++;
                }
            }// счётчик - tracker.ucs.ru возвращает максимум 100 элементов, если кол-во total_count больше, необходимо сделать повторные запросы со смещением
            while (int.Parse(rmIssues.offset) < int.Parse(rmIssues.total_count));          
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
