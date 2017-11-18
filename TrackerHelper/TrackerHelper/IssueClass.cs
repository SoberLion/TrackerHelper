using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerHelper
{

    public class Issue : object
    {
        #region Объявления переменных класса Issue
        private string IssueID = "";
        private string IssueStatus = "";
        private string IssuePriority = "";
        private string IssueAssigned = "";
        private string IssueCategory = "";
        private string IssueStartDate = "";
        private string IssueDescription = "";
        private string IssueSubject = "";
        private string IssueProject = "";
        private string IssueRating = "";
        #endregion

        #region Объявления свойств класса Issue
        public string ID
        {
         get { return IssueID; }
         set { IssueID = value; }
        }
        public string Status
        {
            get { return IssueStatus; }
            set { IssueStatus = value; }
        }
        public string Priority
        {
            get { return IssuePriority; }
            set { IssuePriority = value; }
        }
        public string Assigned
        {
            get { return IssueAssigned; }
            set { IssueAssigned = value; }
        }
        public string Category
        {
            get { return IssueCategory; }
            set { IssueCategory = value; }
        }
        public string StartDate
        {
            get { return IssueStartDate; }
            set { IssueStartDate = value; }
        }
        public string Description
        {
            get { return IssueDescription; }
            set { IssueDescription = value; }
        }
        public string Subject
        {
            get { return IssueSubject; }
            set { IssueSubject = value; }
        }
        public string Project
        {
            get { return IssueProject; }
            set { IssueProject = value; }
        }
        public string Rating
        {
            get { return IssueRating; }
            set { IssueRating = value; }
        }
        #endregion
        public override string ToString()
        {

            return String.Format("ID = {0}, Project = {1}, Subject = {2}, Status = {3},  Priority = {4}, Assigned = {5}, Category = {6}, StartDate = {7}, Rating = {8}",
                                  IssueID, IssueProject, IssueSubject, IssueStatus, IssuePriority, IssueAssigned, IssueCategory, IssueStartDate, IssueRating);
         }
    }

}
