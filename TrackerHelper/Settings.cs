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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            tb_Name.Text = Test.Name;
            tb_Surname.Text = Test.Surname;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Test.Name = tb_Name.Text;
            Test.Surname = tb_Surname.Text;
        }
    }
}
