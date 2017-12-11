using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerHelper.Controls
{
    public partial class DashboardTime : UserControl
    {
        static string _dateFormat = "yyyy-MM-dd HH:mm:ss:fff";
        private string _userIdList = "2361,2374,1830,2233,1240,1383,2886,2235,1521,2232,1537,2535,551,894,3713,328";
        private string _statusIdList = "3,5,6,19,26,27,29,30";

        public string UserIdList
        {
            get { return _userIdList; }
            set { _userIdList = value; }
        }

        public string StatusIdList
        {
            get { return _statusIdList; }
            set { _statusIdList = value; }
        }

        public DashboardTime()
        {
            InitializeComponent();
        }

        private void CreateUsersPanels()
        {

            Rectangle rect = pnlLayoutMain.ClientRectangle;
            
            List<string> Users = UserIdList.Split(',').ToList();
            foreach (string id in Users)
            {

            }

        }
    }
}
