using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;


namespace TrackerHelper
{
    public partial class WorkForm : Form
    {
        User user = null;
        public WorkForm()
        {
            InitializeComponent();                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultModel model = new ResultModel();
            Time_entries te = new Time_entries();                                                                       
            //&user_id=me
            //string URL = @"http://tracker.ucs.ru/time_entries.xml?limit=100&key=1287ca3310be20d6992a764b57f9c8bcfbb05664&from=2017-10-01&to=2017-12-31";
            //model = Http.Get(URL);

            //if (model.IsSuccess)
            //te = XML.Deserialize<Time_entries>(model.Results);
            te = Redmines.FetchTimeEntriesFiltered(3, "");
            if (DBman.Exist("TimeEntries"))
            {
                DBman.InsertTE(te);
            }
        }

        private void btn_GetIssues_Click(object sender, EventArgs e)
        {
            
            user = new User
            {
                Id = "751",
                ApiKey = "1287ca3310be20d6992a764b57f9c8bcfbb05664",
            };
            user.onError += ShowMessage;

            //user.GetAllIssues(1);
            // Redmine.GetUserIssueList(user);

            

            if (DBman.Exist("Issues"))
            {
                DBman.InsertIssues(user.Issues);
            }

            if (user.Issues.issue.Count > 0)
                TreeViewMethods.populateTreeView(user.Issues.issue, treeView_Issues);

        }

        private void treeView_Issues_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ResultModel model = new ResultModel();
            Issue issue = new Issue();
            string URL = @"http://tracker.ucs.ru/issues/" + e.Node.Text + ".xml?include=journals&key=1287ca3310be20d6992a764b57f9c8bcfbb05664";
            model = Http.Get(URL);

            if (model.IsSuccess)
                issue = XML.Deserialize<Issue>(model.Results);

            DBman.InsertIssue(issue);

            tControl.SelectTab(1);

            foreach (Issue.IssueJournalItem item in issue.JournalList)
            {
                if (item.Notes != string.Empty)
                {
                    listbox_IssueJournal.Items.Add(item.User.name + ": " + item.Notes);
                }
            }                
        }

        private void btn_UpdateIssues_Click(object sender, EventArgs e)
        {
            user = new User
            {
                Id = "751",
                ApiKey = "1287ca3310be20d6992a764b57f9c8bcfbb05664",
            };
            user.onError += ShowMessage;
            IssueComparer comparer = new IssueComparer();
            if (user != null)
            {
             //   user.GetOpenedIssuesFromDb();
              //  user.FetchOpenedIssues(1);
                user.FetchUpdatedIssues(3, 5);
             /*   List<Issue> ExceptIssues = user.Issues.issue.Except(user.IssuesUpdated.issue, comparer).ToList<Issue>();
                for (int i = 0; i < ExceptIssues.Count; i++)
                {
                    ResultModel model = new ResultModel();
                    string URL = $@"{user.BaseAddress}issues/{ExceptIssues[i].id}.xml?include=journals&key={user.ApiKey}";
                    model = Http.Get(URL);

                    if (model.IsSuccess)
                        ExceptIssues[i] = XML.Deserialize<Issue>(model.Results);
                }*/
            }
                //user.GetUpdatedIssues(1, 50);
                   if (DBman.Exist("Issues"))
                   {
                       DBman.InsertIssues(user.IssuesUpdated);
                   }

                if (user.IssuesUpdated.issue.Count > 0)
                      TreeViewMethods.populateTreeView(user.IssuesUpdated.issue, treeView_Issues);
             

           // user.GetOpenedIssuesFromDb();
         //   SQLiteClass.GetDict("StatusId", "StatusName");
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnGetIssuesJournals_Click(object sender, EventArgs e)
        {
            user = new User
            {
                Id = "751",
                ApiKey = "1287ca3310be20d6992a764b57f9c8bcfbb05664",
            };
         //   user.FetchUpdatedIssues(3, 5);
            /*for (int i = 0; i < user.IssuesUpdated.issue.Count; i++)
            {
                string url = $@"{user.BaseAddress}issues/{user.IssuesUpdated.issue[i].id}.xml?include=journals&key={user.ApiKey}";
                Issue issue = new Issue();
                issue = Issue.GetIssue(url);
                if (issue != null)
                    user.IssuesUpdated.issue[i] = issue;
            }
            DBman.InsertIssues(user.IssuesUpdated);*/
            Issues issues = new Issues();
            for (int i = 124601; i <= 125657; i++)
            {                
                string url = $@"{user.BaseAddress}issues/{i.ToString()}.xml?include=journals&key={user.ApiKey}";
                Issue issue = new Issue();
                issue = Issue.GetIssue(url);
                if (issue != null)
                    issues.issue.Add(issue);

                if (i % 100 == 0)
                {
                    DBman.InsertIssues(issues);
                    issues.issue.Clear();
                }
            }
            DBman.InsertIssues(issues);
        }
    }
}
