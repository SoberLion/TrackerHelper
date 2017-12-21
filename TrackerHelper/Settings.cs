using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerHelper.DB;

namespace TrackerHelper
{
    public partial class Settings : Form
    {
        Person user = new Person();
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_Id.Text, out int id))
            {
                user.Id = tb_Id.Text;
                user.InternalPhone = tb_internalPhone.Text;
                user.Name = tb_Name.Text;
                user.CompanyName = tb_CompanyName.Text;
                user.BaseAddress = tb_BaseAddress.Text;
                user.Telephone = tb_Phone.Text;
                user.Position = tb_Position.Text;
                user.ApiKey = tb_ApiKey.Text;
                DBman.InsertUser(user);
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_Id.Text, out int id))
            {
                user = DBman.GetUserById(tb_Id.Text);
                tb_internalPhone.Text = user.InternalPhone;
                tb_Name.Text = user.Name;
                tb_CompanyName.Text = user.CompanyName;
                tb_BaseAddress.Text = user.BaseAddress;
                tb_Phone.Text = user.Telephone;
                tb_Position.Text = user.Position;
                tb_ApiKey.Text = user.ApiKey;
            }
            else
            {
                user = new Person();
  //              Redmine.GetUserIssueList(user);
                if (user.Issues.issue.Count > 0)
                {
                    tb_Name.Text = user.Issues.issue[0].assigned_to.name.ToString();
                    tb_Id.Text = user.Issues.issue[0].assigned_to.id.ToString();
                }
            }
        }
    }
}
