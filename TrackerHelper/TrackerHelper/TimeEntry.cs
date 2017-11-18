using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerHelper
{
    public class TimeEntry : object
    {
        #region Объявления переменных класса TimeEntry
        private string TEid = "";
        private string TEProjectId = "";
        private string TEProjName = "";
        private string TEIssueId = "";
        private string TEUserId = "";
        private string TEUserName = "";
        private string TEActivityId = "";
        private string TEActivityName = "";
        private string TEHours = "";
        private string TEComment = "";
        private string TECreatedOn = "";
        #endregion

        #region Объявления свойств класса TimeEntry
        public string Id
        {
            get { return TEid; }
            set { TEid = value; }
        }
        public string ProjectId
        {
            get { return TEProjectId; }
            set { TEProjectId = value; }
        }
        public string ProjectName
        {
            get { return TEProjName; }
            set { TEProjName = value; }
        }
        public string IssueId
        {
            get { return TEIssueId; }
            set { TEIssueId = value; }
        }
        public string UserId
        {
            get { return TEUserId; }
            set { TEUserId = value; }
        }
        public string UserName
        {
            get { return TEUserName; }
            set { TEUserName = value; }
        }
        public string ActivityId
        {
            get { return TEActivityId; }
            set { TEActivityId = value; }
        }
        public string ActivityName
        {
            get { return TEActivityName; }
            set { TEActivityName = value; }
        }
        public string Hours
        {
            get { return TEHours; }
            set { TEHours = value; }
        }
        public string Comment
        {
            get { return TEComment; }
            set { TEComment = value; }
        }
        public string CreatedOn
        {
            get { return TECreatedOn; }
            set { TECreatedOn = value; }
        }
        public override string ToString()
        {

            return String.Format("ID = {0}, ProjectID = {1}, ProjectName = {2}, IssueID = {3},  UserId = {4}, UserName = {5}, ActivityId = {6}, ActivityName = {7}, Hours = {8}, Comment = {9}, CreatedOn = {10}",
                                  TEid, TEProjectId, TEProjName, TEIssueId, TEUserId, TEUserName, TEActivityId, TEActivityName, TEHours, TEComment, TECreatedOn);
        }
        #endregion
    }
}
