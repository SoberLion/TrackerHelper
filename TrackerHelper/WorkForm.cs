using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TrackerHelper
{
    public partial class WorkForm : Form
    {
        public WorkForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultModel model = new ResultModel();
            Time_entries te = new Time_entries();
            string URL = @"http://tracker.ucs.ru/time_entries.xml?limit=100&key=1287ca3310be20d6992a764b57f9c8bcfbb05664&user_id=me&from=2017-09-01&to=2017-09-30";
            model = Http.Get(URL);

            if (model.IsSuccess)
                te = XML.Deserialize<Time_entries>(model.Results);

          //  BindingList<Time_entry> data = new BindingList<Time_entry>();
//data = te.time_entry_list;
            dataGridView1.DataSource = te.time_entry_list;

            SQLiteClass.CreateTETable();
            if (SQLiteClass.Exist("TimeEntries"))
            {
                SQLiteClass.InsertTE(te);
            }

        }

        private void btn_GetIssues_Click(object sender, EventArgs e)
        {
            ResultModel model = new ResultModel();
            Issues issues = new Issues();
            string URL = @"http://tracker.ucs.ru/issues.xml?limit=100&key=1287ca3310be20d6992a764b57f9c8bcfbb05664";// &assigned_to_id=me";//&status_id=9";
            model = Http.Get(URL);

            if (model.IsSuccess)
                issues = XML.Deserialize<Issues>(model.Results);

            SQLiteClass.CreateIssuesTable();
            if (SQLiteClass.Exist("Issues"))
            {
                SQLiteClass.InsertIssue(issues);
            }
            
        }
    }
}
