using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using TrackerHelper.DB;
using TrackerHelper.RedmineEntities;


namespace TrackerHelper
{
    public partial class WorkForm : Form
    {
        delegate void Message(string message);

        Person user = null;
        public WorkForm()
        {
            InitializeComponent();                  
        }


        private void btn_GetIssues_Click(object sender, EventArgs e)
        {
            
            user = new Person
            {
                Id = "751",
                ApiKey = "1287ca3310be20d6992a764b57f9c8bcfbb05664",
            };
            user.onError += ShowMessage;            

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

            foreach (IssueJournalItem item in issue.JournalList)
            {
                if (item.Notes != string.Empty)
                {
                    listbox_IssueJournal.Items.Add(item.User.name + ": " + item.Notes);
                }
            }                
        }

        private void btn_UpdateIssues_Click(object sender, EventArgs e)
        {
            user = new Person
            {
                Id = "751",
                ApiKey = "d0867cd6f5559eb738c48cd53c870ad9853999e3",//"1287ca3310be20d6992a764b57f9c8bcfbb05664",
            };
            user.onError += ShowMessage;
            IssueComparer comparer = new IssueComparer();
            if (user != null)
            {
                user.FetchUpdatedIssues(3, 2);
            }
                   if (DBman.Exist("Issues"))
                   {
                       DBman.InsertIssues(user.IssuesUpdated);
                   }

            if (user.IssuesUpdated.issue.Count > 0)
                TreeViewMethods.populateTreeView(user.IssuesUpdated.issue, treeView_Issues);
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (bgWorker.IsBusy != true)
            {
                bgWorker.RunWorkerAsync();
            }
        }

        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            user = new Person
            {
                Id = "751",
                ApiKey = "d0867cd6f5559eb738c48cd53c870ad9853999e3"//"1287ca3310be20d6992a764b57f9c8bcfbb05664",
            };
            DBController dbController = new DBController(user);

            DBController.onProgressChange += delegate (EventProgressArgs args)
            {
                bgWorker.ReportProgress(args.Percents);
                lblPBarSetText(args.Message);
            };

            int numOfDays = 1;

            int.TryParse(tbNumOfDays.Text, out numOfDays);

            tbNumOfDays.Text = numOfDays.ToString();

            dbController.UpdateIssues(3, numOfDays);
            dbController.UpdateTimeEntries(3, numOfDays);
            dbController.UpdateUsers(3);
        }

        private void bgWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            pbBGWork.Value = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
            }
            else if (!(e.Error == null))
            {
            }
            else
            {
                pbBGWork.Value = 100;
                lblPBarSetText("Updated.");
            }
        }

        private void lblPBarSetText(string message)
        {
            if (lblPBar.InvokeRequired)
            {
                Message lblup = new Message(lblPBarSetText);
                Invoke(lblup, new object[] { message });
            }
            else
            {
                lblPBar.Text = message;
            }
        }
    }
}
