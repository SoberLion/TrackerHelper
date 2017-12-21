using System;
using System.Collections.Generic;
using TrackerHelper.DB;
using TrackerHelper.RedmineEntities;

namespace TrackerHelper
{
    public class Vacation
    {
        public DateTime begin { get; set; }
        public DateTime end { get; set; }
    }

    public abstract class Role
    {
    }

    public class User
    {
        public delegate void Message(string message);

        public event Message onError;
        public event Message onMessage;


        private string _Id = string.Empty;
        private string _Name = string.Empty;
        //private Role _Role;
        private string _CompanyName = string.Empty;
        private string _Position = string.Empty;
        private string _Telephone = string.Empty;
        private string _InternalPhone = string.Empty;
        private List<Vacation> _Vacations = new List<Vacation>();
        //private Language _Language = new Language;
        private string _BaseAddress = @"http://tracker.ucs.ru/";
        private Issues _Issues = new Issues();
        private Issues _IssuesUpdated = new Issues();
        private string _ApiKey = "1287ca3310be20d6992a764b57f9c8bcfbb05664";

        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        /*public Role Role
        {
            get { return _Role; }
            set { _Role = value; }
        }*/
        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }
        public string Position
        {
            get { return _Position; }
            set { _Position = value; }
        }
        public string Telephone
        {
            get { return _Telephone; }
            set { _Telephone = value; }
        }
        public string InternalPhone
        {
            get { return _InternalPhone; }
            set { _InternalPhone = value; }
        }
        public List<Vacation> Vacations
        {
            get { return _Vacations; }
            set { _Vacations = value; }
        }
      /*  public Language Language
        {
            get { return _Language; }
            set { _Language = value; }
        }*/
        public string BaseAddress
        {
            get { return _BaseAddress; }
            set
            {
                onMessage?.Invoke("BaseAddress = " + value);
                _BaseAddress = value;
            }
        }
        public Issues Issues
        {
            get { return _Issues; }
            set { _Issues = value; }
        }
        public Issues IssuesUpdated
        {
            get { return _IssuesUpdated; }
            set { _IssuesUpdated = value; }
        }
        public string ApiKey
        {
            get { return _ApiKey; }
            set
            {
                onMessage?.Invoke("ApiKey = " + value);
                _ApiKey = value;
            }
        }

        public void FetchOpenedIssues(int Retries)
        {
            string filter = @"set_filter=1&f[]=assigned_to_id&op[assigned_to_id]=%3D&v[assigned_to_id][]=me&f[]=status_id&op[status_id]=o";
            FetchIssuesFiltered(Retries, filter);
        }

        public void FetchUpdatedIssues(int Retries, int NumofDaysSinceLastUpdate)
        {
            // string filter = $@"set_filter=1&f[]=assigned_to_id&op[assigned_to_id]=%3D&v[assigned_to_id][]=me&f[]=status_id&op[status_id]=*&f[]=updated_on&op[updated_on]=%3Et-&v[updated_on][]={NumofDaysSinceLastUpdate}";
            string filter = $@"set_filter=1&f[]=status_id&op[status_id]=*&f[]=updated_on&op[updated_on]=%3Et-&v[updated_on][]={NumofDaysSinceLastUpdate}";
            FetchIssuesFiltered(Retries, filter);
        }

        public void FetchAllIssues(int Retries)
        {
            string filter = @"set_filter=1&f[]=&c[]=project&c[]=tracker&c[]=status&c[]=priority&c[]=author&c[]=subject&c[]=assigned_to&c[]=updated_on&c[]=category&group_by=&t[]=";

            FetchIssuesFiltered(Retries, filter);
        }

        public void GetOpenedIssuesFromDb() => DBman.GetIssuesListByUserId(_Id, _Issues);

        public void FetchIssuesFiltered(int Retries, string filter)
        {
            ResultModel resultModel = new ResultModel();
            int retries = 0;
            do
            {
                string url = $@"{_BaseAddress}issues.xml?utf8=%E2%9C%93&limit={_IssuesUpdated.limit}&offset={_IssuesUpdated.offset}&key={_ApiKey}&{filter}";
                resultModel.IsSuccess = false;

                resultModel = Http.Get(url);
                if (resultModel.IsSuccess)
                {
                    if (_IssuesUpdated.issue.Count > 0)
                    {
                        XML.Deserialize<Issues>(resultModel.Results).issue.ForEach(p => _IssuesUpdated.issue.Add(p));
                        retries = 0;
                    }
                    else
                    {
                        _IssuesUpdated = XML.Deserialize<Issues>(resultModel.Results);
                    } // IncOffset увеличивает offset на величину limit при каждом вызове.
                    _IssuesUpdated.IncOffset();
                }
                else
                {// в случае если запрос к redmine не был успешным сделать повторный запрос с теми же параметрами
                    retries++;
                    if (retries == Retries)
                    {
                        onError?.Invoke($"No reply from host. Fetched {_IssuesUpdated.issue.Count} issues");
                        break;
                    }
                }
            }// счётчик - tracker.ucs.ru возвращает максимум 100 элементов, если кол-во total_count больше, необходимо сделать повторные запросы со смещением
            while (_IssuesUpdated.offset < _IssuesUpdated.total_count);
        }

        public void Update()
        {

        }
    }
}
