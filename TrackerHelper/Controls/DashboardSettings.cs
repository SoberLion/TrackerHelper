﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerHelper.DB;
using TrackerHelper.Controls;

namespace TrackerHelper
{
    public partial class DashboardSettings : UserControl
    {
        private List<DashboardPreset> _presetsList;

        public DashboardSettings()
        {
            InitializeComponent();
            GetPresets();
        }

        private void GetPresets()
        {
            string query = $@"select issueid from issues where issueid = 112546";
            DataRow[] rows = DBman.OpenQuery(query).Select("");
            IList<string> list = rows.Select(p => p[0].ToString()).ToArray();
            cbPresets.DataSource = list;         
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DashboardPreset newPreset = new DashboardPreset();
            DashboardSettingsInfo newSettings = new DashboardSettingsInfo
            {
                Parent = this.pnlSettings,
                Preset = newPreset,
                Name = "newSettings"
            };
            newSettings.GetDict();           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}
