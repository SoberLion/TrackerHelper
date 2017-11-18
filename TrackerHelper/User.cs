﻿using System;
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

    public enum Role
    {
        Administrator,
        User
    }

    public enum Language
    {
        Русский,
        English
    }
    abstract class User
    {
        private string _UniqueId = new Guid().ToString();
        private string _Name = string.Empty;
        private Role _Role;
        private string _CompanyName = string.Empty;
        private string _Position = string.Empty;
        private string _Telephone = string.Empty;
        private string _InternalPhone = string.Empty;
        private List<Vacation> _Vacations = new List<Vacation>();
        private Language _Language = Language.Русский;


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public Role Role
        {
            get { return _Role; }
            set { _Role = value; }
        }
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
    }
}
