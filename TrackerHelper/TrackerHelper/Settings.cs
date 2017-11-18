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
    public partial class SetForm : Form
    {
        public SetForm()
        {
            InitializeComponent();
        }

        private void btnSettingsClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTPFrom.Value.ToString("yyyy-MM-dd"));
        }
        public string Getdate()
        {
            return dateTPFrom.Value.ToString("yyyy-MM-dd");
        }
    }
}
