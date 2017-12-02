using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TrackerHelper
{
    // id, name pair class
    public class IdName
    {
        public IdName() { }

        private int idField = -1;
        private string nameField = string.Empty;

        [XmlAttribute]
        public int id
        {
            get { return idField; }
            set { idField = value; }
        }
        [XmlAttribute]
        public string name
        {
            get { return nameField; }
            set { nameField = value; }
        }
    }

    #region ---------------------------------- time_entries -------------------------------------

    [XmlRoot("time_entries", IsNullable = false)]
    public class Time_entries
    {
        public Time_entries() { }

        private List<Time_entry> _time_entry = new List<Time_entry>();
        private string _total_count;
        private string _offset;
        private string _limit;
        private string _type;

        [XmlElement("time_entry")]
        public List<Time_entry> time_entry_list
        {
            get
            {
                return _time_entry;
            }
            set { _time_entry = value; }
        }

        [XmlAttribute]
        public string total_count
        {
            get { return _total_count; }
            set { _total_count = value; }
        }

        [XmlAttribute]
        public string offset
        {
            get { return _offset; }
            set { _offset = value; }
        }

        [XmlAttribute]
        public string limit
        {
            get { return _limit; }
            set { _limit = value; }
        }

        [XmlAttribute]
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        public void IncOffset()
        {
            _offset = (int.Parse(_offset) + int.Parse(_limit)).ToString();
        }
    }

    public partial class Time_entry
    {
        private string _id;
        private string _hours;
        private string _comments;
        private string _spent_on;
        private string _created_on;
        private string _updated_on;
        private IdName _project;
        private IdName _issue;
        private IdName _user;
        private IdName _activity;

        [XmlElement("id")]
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        [XmlElement("hours")]
        public string hours
        {
            get { return _hours; }
            set { _hours = value; }
        }

        [XmlElement("comments")]
        public string comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        [XmlElement("spent_on")]
        public string spent_on
        {
            get { return _spent_on; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    _spent_on = dt.ToString("yyyy-MM-dd hh:mm:00.000");
                }
                else
                    _spent_on = string.Empty;
            }
        }

        [XmlElement("created_on")]
        public string created_on
        {
            get { return _created_on; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    _created_on = dt.ToString("yyyy-MM-dd hh:mm:00.000");
                }
                else
                    _created_on = string.Empty;
            }
        }

        [XmlElement("updated_on")]
        public string updated_on
        {
            get { return _updated_on; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    _updated_on = dt.ToString("yyyy-MM-dd hh:mm:00.000");
                }
                else
                    _updated_on = string.Empty;
            }
        }

        [XmlElement("project")]
        public IdName project
        {
            get { return _project; }
            set { _project = value; }
        }

        [XmlElement("issue")]
        public IdName issue
        {
            get { return _issue; }
            set { _issue = value; }
        }

        [XmlElement("user")]
        public IdName user
        {
            get { return _user; }
            set { _user = value; }
        }

        [XmlElement("activity")]
        public IdName activity
        {
            get { return _activity; }
            set { _activity = value; }
        }
    }


    #endregion

    #region -------------------------------------- Issues ---------------------------------------
    [XmlRoot("issues", IsNullable = false)]
    public class Issues
    {
        private string _total_count = "0";
        private string _offset = "0";
        private string _limit = "100";
        private string _type = string.Empty;
        private List<Issue> issueField = new List<Issue>();

        [XmlAttribute]
        public string total_count
        {
            get { return _total_count; }
            set { _total_count = value; }
        }

        [XmlAttribute]
        public string offset
        {
            get { return _offset; }
            set { _offset = value; }
        }

        [XmlAttribute]
        public string limit
        {
            get { return _limit; }
            set { _limit = value; }
        }

        [XmlAttribute]
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        [XmlElement(IsNullable = false)]
        public List<Issue> issue
        {
            get { return issueField; }
            set { issueField = value; }
        }

        public void IncOffset()
        {
            _offset = (int.Parse(_offset) + int.Parse(_limit)).ToString();
        }
    }

    #endregion

    #region -------------------------------------- Issue ----------------------------------------
    [XmlRoot("issue")]
    public class Issue
    {
        private IdName projectField = new IdName();
        private IdName trackerField = new IdName();
        private IdName statusField = new IdName();
        private IdName priorityField = new IdName();
        private IdName authorField = new IdName();
        private IdName assigned_toField = new IdName();
        private IdName categoryField = new IdName();

        private string idField = string.Empty;
        private string subjectField = string.Empty;
        private string descriptionField = string.Empty;
        private string startDateField = string.Empty;
        private string dueDateField = string.Empty;
        private string doneRatioField = string.Empty;
        private bool isPrivateField = false;
        private string estimatedHoursField = string.Empty;
        private List<custom_field> custom_fieldsField = new List<custom_field>();
        private string createdOnField = string.Empty;
        private string updatedOnField = string.Empty;
        private string closedOnField = string.Empty;

        private List<IssueJournalItem> IssueJournalList = new List<IssueJournalItem>();

        [XmlElement]
        public string id
        {
            get { return idField; }
            set { idField = value; }
        }
        [XmlElement]
        public IdName project
        {
            get { return projectField; }
            set { projectField = value; }
        }
        [XmlElement]
        public IdName tracker
        {
            get { return trackerField; }
            set { trackerField = value; }
        }
        [XmlElement]
        public IdName status
        {
            get { return statusField; }
            set { statusField = value; }
        }
        [XmlElement]
        public IdName priority
        {
            get { return priorityField; }
            set { priorityField = value; }
        }
        [XmlElement]
        public IdName author
        {
            get { return authorField; }
            set { authorField = value; }
        }

        [XmlElement]
        public IdName assigned_to
        {
            get { return assigned_toField; }
            set { assigned_toField = value; }
        }
        [XmlElement]
        public IdName category
        {
            get { return categoryField; }
            set { categoryField = value; }
        }

        [XmlElement]
        public string subject
        {
            get { return subjectField; }
            set { subjectField = value; }
        }
        [XmlElement]
        public string description
        {
            get { return descriptionField; }
            set { descriptionField = value; }
        }
        [XmlElement("start_date")]
        public string startDate
        {
            get { return startDateField; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    startDateField = dt.ToString("yyyy-MM-dd hh:mm:00.000");
                }
                else
                    startDateField = string.Empty;
            }
        }

        [XmlElement("due_date")]
        public string dueDate
        {
            get { return dueDateField; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    dueDateField = dt.ToString("yyyy-MM-dd hh:mm:00.000");
                }
                else
                    dueDateField = string.Empty;
            }
        }

        [XmlElement("done_ratio")]
        public string doneRatio
        {
            get { return doneRatioField; }
            set { doneRatioField = value; }
        }

        [XmlElement("is_private")]
        public bool IsPrivate
        {
            get { return isPrivateField; }
            set { isPrivateField = value; }
        }

        [XmlElement("estimated_hours")]
        public string estimatedHours
        {
            get { return estimatedHoursField; }
            set { estimatedHoursField = value; }
        }

        [XmlArray("custom_fields")]
        [XmlArrayItem("custom_field")]
        public List<custom_field> custom_fields
        {
            get { return custom_fieldsField; }
            set { custom_fieldsField = value; }
        }

        [XmlElement("created_on")]
        public string createdOn
        {
            get { return createdOnField; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    createdOnField = dt.ToString("yyyy-MM-dd hh:mm:00.000");
                }
                else
                    createdOnField = string.Empty;
            }
        }

        [XmlElement("updated_on")]
        public string updatedOn
        {
            get { return updatedOnField; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    updatedOnField = dt.ToString("yyyy-MM-dd hh:mm:00.000");
                }
                else
                    updatedOnField = string.Empty;
            }
        }

        [XmlElement("closed_on")]
        public string closedOn
        {
            get { return closedOnField; }
            set
            {
                DateTime dt;
                if (DateTime.TryParse(value, out dt))
                {
                    closedOnField = dt.ToString("yyyy-MM-dd hh:mm:00.000");
                }
                else
                    closedOnField = string.Empty;
            }

        }

        [XmlArray("journals"), XmlArrayItem(ElementName = "journal", Type = typeof(IssueJournalItem))]
        public List<IssueJournalItem> JournalList
        {
            get { return IssueJournalList; }
            set { IssueJournalList = value; }
        }

        public class custom_field
        {
            public custom_field() { }

            private int idField;
            private string nameField;
            private bool multipleField;
            private List<Value> valueField;

            [XmlAttribute]
            public int id
            {
                get { return idField; }
                set { idField = value; }
            }
            [XmlAttribute]
            public string name
            {
                get { return nameField; }
                set { nameField = value; }
            }

            [XmlAttribute]
            public bool multiple
            {
                get { return multipleField; }
                set { multipleField = value; }
            }

            [XmlArray("value")]
            [XmlArrayItem("value")]
            public List<Value> values
            {
                get { return valueField; }
                set { valueField = value; }
            }

            public class Value
            {
                private string V_type;
                private string valueField;

                [XmlAttribute("type")]
                public string type
                {
                    get { return V_type; }
                    set { V_type = value; }
                }
                [XmlText]
                public string value
                {
                    get { return valueField; }
                    set { valueField = value; }
                }
                public Value() { }
            }
        }

        public class IssueJournalItem
        {
            private string IdField = string.Empty;
            private IdName UserField = null;
            private string NotesField = string.Empty;
            private string CreatedOnField = string.Empty;
            private List<Detail> DetailsField = new List<Detail>();

            [XmlArray("details")]
            [XmlArrayItem("detail")]
            public List<Detail> Details
            {
                get { return DetailsField; }
                set { DetailsField = value; }
            }

            [XmlAttribute("id")]
            public string Id
            {
                get { return IdField; }
                set { IdField = value; }
            }

            [XmlElement("user")]
            public IdName User
            {
                get { return UserField; }
                set { UserField = value; }
            }

            [XmlElement("notes")]
            public string Notes
            {
                get { return NotesField; }
                set { NotesField = value; }
            }

            [XmlElement("created_on", IsNullable = true)]
            public string CreatedOn
            {
                get { return CreatedOnField; }
                set
                {
                    DateTime dt;
                    if (DateTime.TryParse(value, out dt))
                    {
                        CreatedOnField = dt.ToString("yyyy-MM-dd hh:mm:00.000");
                    }
                    else
                        CreatedOnField = string.Empty;
                }
            }

            public class Detail
            {
                public Detail() { }

                private string PropertyField = string.Empty;
                private string NameField = string.Empty;
                private string OldValueField = string.Empty;
                private string NewValueField = string.Empty;

                [XmlAttribute("property")]
                public string Property
                {
                    get { return PropertyField; }
                    set { PropertyField = value; }
                }

                [XmlAttribute("name")]
                public string Name
                {
                    get { return NameField; }
                    set { NameField = value; }
                }

                [XmlElement("old_value")]
                public string OldValue
                {
                    get { return OldValueField; }
                    set { OldValueField = value; }
                }

                [XmlElement("new_value")]
                public string NewValue
                {
                    get { return NewValueField; }
                    set { NewValueField = value; }
                }
            }
        }
        public static Issue GetIssue(string url)
        {
            Issue issue = null;
            ResultModel model = new ResultModel();

            model = Http.Get(url);
            if (model.IsSuccess)
            {
                issue = XML.Deserialize<Issue>(model.Results);
            }
            return issue = issue ?? null;
        }
    }
    public class IssueComparer : IEqualityComparer<Issue>
    {
        public bool Equals(Issue x, Issue y)
        {
            return x.updatedOn.Equals(y.updatedOn) && (x.JournalList.Count == y.JournalList.Count);
        }

        public int GetHashCode(Issue obj)
        {
            if (object.ReferenceEquals(obj, null))
                return 0;

            return obj.updatedOn.GetHashCode();
        }
    }
    #endregion
}
