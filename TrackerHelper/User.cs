using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public delegate void Update(string message);
        public Update MessageDel;

        public void RegisterDelegate(Update del)
        {
            MessageDel += del;
        }
        public void UnregisterDelegate(Update del)
        {
            MessageDel -= del;
        }

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
                MessageDel?.Invoke("BaseAddress = " + value);
                _BaseAddress = value;
            }
        }
        public Issues Issues
        {
            get { return _Issues; }
            set { _Issues = value; }
        }
        public string ApiKey
        {
            get { return _ApiKey; }
            set
            {
                MessageDel?.Invoke("ApiKey = " + value);
                _ApiKey = value;
            }
        }

        public void GetIssues()
        {
            string url = $@"{_BaseAddress}issues.xml?utf8=%E2%9C%93&set_filter=1&f[]=assigned_to_id&op[assigned_to_id]=%3D&v[assigned_to_id][]=me&f[]=&c[]=project&c[]=tracker&c[]=status&c[]=priority&c[]=author&c[]=subject&c[]=assigned_to&c[]=updated_on&c[]=category&group_by=&t[]=&key={_ApiKey}";

            var resultModel = new ResultModel();

            resultModel = Http.Get(url);

            if (resultModel.IsSuccess)
            {
                try
                {
                    _Issues = XML.Deserialize<Issues>(resultModel.Results);
                }
                catch (Exception ex)
                {
                }

                // счётчик - redmine возвращает максимум 100 элементов, если кол-во total_count больше, необходимо сделать повторные запросы со смещением
                int cnt = int.Parse(_Issues.total_count) / 100;
                if (cnt > 0)
                {
                    for (int i = 1; i <= cnt; i++)
                    {
                        resultModel = Http.Get(url + "&offset=" + (i * 100).ToString());
                        if (resultModel.IsSuccess)
                        {
                            try
                            {
                                // Десериализуем следующие записи и добавим их к существующим.
                                XML.Deserialize<Issues>(resultModel.Results).issue.ForEach(p => _Issues.issue.Add(p));
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                }
            }
            else
            {
            }
        }

        public void GetUpdatedIssues()
        {
            string url = $@"{_BaseAddress}issues?utf8=%E2%9C%93&set_filter=1&f%5B%5D=assigned_to_id&op%5Bassigned_to_id%5D=%3D&v%5Bassigned_to_id%5D%5B%5D=me&f%5B%5D=updated_on&op%5Bupdated_on%5D=t&f%5B%5D=&c%5B%5D=project&c%5B%5D=tracker&c%5B%5D=status&c%5B%5D=priority&c%5B%5D=author&c%5B%5D=subject&c%5B%5D=assigned_to&c%5B%5D=updated_on&c%5B%5D=category&group_by=&t%5B%5D=%key={ApiKey}";

            var resultModel = new ResultModel();

            resultModel = Http.Get(url);

            if (resultModel.IsSuccess)
            {
                try
                {
                    _Issues = XML.Deserialize<Issues>(resultModel.Results);
                }
                catch (Exception ex)
                {
                }

                // счётчик - redmine возвращает максимум 100 элементов, если кол-во total_count больше, необходимо сделать повторные запросы со смещением
                int cnt = int.Parse(_Issues.total_count) / 100;
                if (cnt > 0)
                {
                    for (int i = 1; i <= cnt; i++)
                    {
                        resultModel = Http.Get(url + "&offset=" + (i * 100).ToString());
                        if (resultModel.IsSuccess)
                        {
                            try
                            {
                                // Десериализуем следующие записи и добавим их к существующим.
                                XML.Deserialize<Issues>(resultModel.Results).issue.ForEach(p => _Issues.issue.Add(p));
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                }
            }
            else
            {
            }
        }


    }
}
