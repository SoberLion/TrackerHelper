using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerHelper.Controls;

namespace TrackerHelper
{
    public partial class Dashboard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(IntPtr hObject);

        public Dashboard()
        {
           InitializeComponent();
          /*   IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 25, 25); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.Region = Region.FromHrgn(ptr);
            DeleteObject(ptr);

            IntPtr pnlptr = CreateRoundRectRgn(0, 0, pnlLogo.Width, pnlLogo.Height, 25, 25); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            pnlLogo.Region = Region.FromHrgn(pnlptr);
            DeleteObject(pnlptr);*/

        }

        private void Charts_Shown(object sender, EventArgs e)
        {
            
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Dashboard_Paint(object sender, PaintEventArgs e)
        {       
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
           // e.Cancel = false;
        }

        private void tsDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void pnlHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnTechSupp_Click(object sender, EventArgs e)
        {
            Toggle(sender);
            lblCaption.Text = "TECH SUPPORT";
            //this.SuspendLayout();
            DashboardIssues newTSDashboard = new DashboardIssues
            {
                Parent = this.pnlDashboard,
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(41, 53, 65),
                Name = "DashboardIssues"
            };
            
            //newTSDashboard.UpdateTSDashboard();
            //this.ResumeLayout();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblCaption.Text = "USERS";
            Toggle(sender);
            DashboardIssues tsdb = Controls.Find("DashboardIssues", true).FirstOrDefault() as DashboardIssues;
            tsdb?.Dispose();

            DashboardTime dbTime = new DashboardTime
            {
                Parent = this.pnlDashboard,
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(41, 53, 65),
                Name = "Users"
            };

        }

        private void Toggle(object sender)
        {
            btnTechSupp.Check = false;
            btnTechSupp.BackColor = Color.FromArgb(41, 53, 65);
            btn1.Check = false;
            btn1.BackColor = Color.FromArgb(41, 53, 65);
            btn2.Check = false;
            btn2.BackColor = Color.FromArgb(41, 53, 65);
            btn3.Check = false;
            btn3.BackColor = Color.FromArgb(41, 53, 65);
            btn4.Check = false;
            btn4.BackColor = Color.FromArgb(41, 53, 65);

            (sender as CheckedButton).Check = true;
            (sender as CheckedButton).BackColor = Color.FromArgb(21, 33, 45);

        }
    }
}
