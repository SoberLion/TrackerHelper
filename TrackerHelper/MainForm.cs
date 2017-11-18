using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerHelper
{
    public partial class MainForm : Form
    {              
        public MainForm()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settings = new Settings();
            settings.MdiParent = this;
            settings.WindowState = FormWindowState.Maximized;
            settings.Show();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form workForm = new WorkForm();
            workForm.MdiParent = this;
            workForm.WindowState = FormWindowState.Maximized;
            workForm.Show();
        }

        private void techSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form repform = new PieChartEx
            {
                MdiParent = this,
                WindowState = FormWindowState.Normal
            };
            /*DateTimePicker dtpFrom = new DateTimePicker
            {
                Parent = repform,
                Top = 10,
                Left = 10,
                Width = repform.Size.Width - 35,
                MinDate = DateTime.Parse("01-01-2015"),
                Anchor = (AnchorStyles)13
            };
            DateTimePicker dtpTo = new DateTimePicker
            {
                Parent = repform,
                Top = 40,
                Left = 10,
                Width = repform.Size.Width - 35,
                MinDate = DateTime.Parse("01-01-2015"),
                Anchor = (AnchorStyles)13
            };
            Button btnOk = new Button
            {
                Parent = repform,
                Left = repform.Size.Width / 2 - 60,
                Top = repform.Size.Height - 80,
                Text = "OK",
                Width = 100,
                Height = 20
            };*/
            

            repform.Show();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form repform = new Form
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };

        }
    }
}
