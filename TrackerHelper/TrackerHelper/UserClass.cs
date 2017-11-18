using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TrackerHelper
{
   public class User : object
    {
        #region Объявления переменных класса пользователь
        private string UserName = "";
        private int UserID = 0;
        private List<Issue> UserIssues = null;
        private List<TimeEntry> UserTimeEntry = null;
        private string UserApiKey = "";
        private double UserTimeSpent = 0.0;


        #endregion

        #region Объявления свойств класса пользователь
        public string Name
        {
            get { return UserName; }
            set { UserName = value; }
        }

        public int ID
        {
            get { return UserID; }
            set { UserID = value; }
        }

        public List<Issue> Issues
        {
            get { return UserIssues; }
            set { UserIssues = value; }
        }

        public List<TimeEntry> timeEntry
        {
            get { return UserTimeEntry; }
            set { UserTimeEntry = value; }
        }

        public string ApiKey
        {
            get { return UserApiKey; }
            set { UserApiKey = value; }
        }

        public double TimeSpent
        {
            get { return UserTimeSpent; }
            set { UserTimeSpent = value; }
        }
        #endregion
    }
}
