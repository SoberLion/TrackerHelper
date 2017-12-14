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
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
           // e.Cancel = false;
        }


        private void pnlHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnTechSupp_Click(object sender, EventArgs e)
        {
            Toggle(sender);
            lblCaption.Text = "ISSUES";

            DashboardIssues dash = Controls.Find("DashboardIssues", true).FirstOrDefault() as DashboardIssues;

            if (dash != null)
            {
                dash.BringToFront();
            }
            else
            {
                DashboardIssues newDash = new DashboardIssues
                {
                    Parent = this.pnlDashboard,
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(41, 53, 65),
                    Name = "DashboardIssues"
                };
                newDash.UpdateTSDashboard();
                newDash.BringToFront();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblCaption.Text = "Новые";
            Toggle(sender);

            DashboardIssuesStatus dash = Controls.Find("Новые", true).FirstOrDefault() as DashboardIssuesStatus;
            if (dash != null)
            {
                dash.BringToFront();
            }
            else
            {
                DashboardIssuesStatus newDash = new DashboardIssuesStatus
                {
                    Parent = this.pnlDashboard,
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(255, 53, 65),
                    Name = "Новые",
                    StatusIdList = new int[] { 1 }
                };
                newDash.GetDataTable();
                newDash.BringToFront();
            }
        }

        private void Toggle(object sender)
        {
            btnTechSupp.Check = false;
            btnTechSupp.BackColor = Color.FromArgb(41, 53, 65);
            btnNew.Check = false;
            btnNew.BackColor = Color.FromArgb(41, 53, 65);
            btnAssigned.Check = false;
            btnAssigned.BackColor = Color.FromArgb(41, 53, 65);
            btnNeedInfoEmpl.Check = false;
            btnNeedInfoEmpl.BackColor = Color.FromArgb(41, 53, 65);
            btnEscalated.Check = false;
            btnEscalated.BackColor = Color.FromArgb(41, 53, 65);

            (sender as CheckedButton).Check = true;
            (sender as CheckedButton).BackColor = Color.FromArgb(21, 33, 45);
        }

        private void btnAssigned_Click(object sender, EventArgs e)
        {
            lblCaption.Text = "Назначена";
            Toggle(sender);

            DashboardIssuesStatus dash = Controls.Find("Назначена", true).FirstOrDefault() as DashboardIssuesStatus;
            if (dash != null)
            {
                dash.BringToFront();
            }
            else
            {
                DashboardIssuesStatus newDash = new DashboardIssuesStatus
                {
                    Parent = this.pnlDashboard,
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(41, 53, 65),
                    Name = "Назначена",
                    StatusIdList = new int[] { 9 }
                };
                newDash.GetDataTable();
                newDash.BringToFront();
            }
        }

        private void btnNeedInfoEmpl_Click(object sender, EventArgs e)
        {
            lblCaption.Text = "Нужна информация (сотрудники)";
            Toggle(sender);

            DashboardIssuesStatus dash = Controls.Find("Нужна информация (сотрудники)", true).FirstOrDefault() as DashboardIssuesStatus;
            if (dash != null)
            {
                dash.BringToFront();
            }
            else
            {
                DashboardIssuesStatus newDash = new DashboardIssuesStatus
                {
                    Parent = this.pnlDashboard,
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(41, 53, 65),
                    Name = "Нужна информация (сотрудники)",
                    StatusIdList = new int[] { 18 }
                };
                newDash.GetDataTable();
                newDash.BringToFront();
            }
        }

        private void btnEscalated_Click(object sender, EventArgs e)
        {
            lblCaption.Text = "Эскалирована";
            Toggle(sender);

            DashboardIssuesStatus dash = Controls.Find("Эскалирована", true).FirstOrDefault() as DashboardIssuesStatus;
            if (dash != null)
            {
                dash.BringToFront();
            }
            else
            {
                DashboardIssuesStatus newDash = new DashboardIssuesStatus
                {
                    Parent = this.pnlDashboard,
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(41, 53, 65),
                    Name = "Эскалирована",
                    StatusIdList = new int[] { 22 }
                };
                newDash.GetDataTable();
                newDash.BringToFront();
            }
        }
    }
}
