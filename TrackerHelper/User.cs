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

    public enum Language
    {
        Русский,
        English
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
        private Language _Language = Language.Русский;
        private string _BaseAddress = @"http://test-tracker.ucs.ru/";
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
        public Language Language
        {
            get { return _Language; }
            set { _Language = value; }
        }
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
    }
}
