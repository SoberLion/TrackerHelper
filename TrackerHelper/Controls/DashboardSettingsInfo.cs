using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerHelper.DB;

namespace TrackerHelper.Controls
{
    public partial class DashboardSettingsInfo : UserControl
    {
        private DashboardPreset _preset;

        public DashboardPreset Preset
        {
            get { return _preset; }
            set { _preset = value; }
        }

        public List<IdName> dbEmp = new List<IdName>();
        public List<IdName> dbProj { get; set; } = new List<IdName>();
        public List<Status> dbStatus { get; set; } = new List<Status>();

        public DashboardSettingsInfo()
        {
            InitializeComponent();
        }

        public void GetDict()
        {
            string Employees = "SELECT DISTINCT AssignedToId, AssignedToName FROM Issues ORDER BY AssignedToName";
            string Projects = "SELECT DISTINCT ProjectId, ProjectName FROM Issues ORDER BY ProjectName";
            string Statuses = "SELECT DISTINCT StatusId, StatusName FROM Issues ORDER BY StatusId";

            DataRow[] EmplData = DBman.OpenQuery(Employees).Select("");
            List<IdName> emplList = EmplData.Select(p => new IdName { id = Convert.ToInt32(p[0]), name = p[1].ToString() }).ToList<IdName>();

            DataRow[] ProjData = DBman.OpenQuery(Projects).Select("");
            List<IdName> projList = ProjData.Select(p => new IdName { id = Convert.ToInt32(p[0]), name = p[1].ToString() }).ToList<IdName>();

            DataRow[] StatData = DBman.OpenQuery(Statuses).Select("");
            List<Status> statList = StatData.Select(p => new Status { ID = Convert.ToInt32(p[0]), Name = p[1].ToString() }).ToList<Status>();

            IdName newIdname = new IdName
            {
                id = 1223,
                name = "AA SS"
            };
            _preset.Employees.Add(newIdname);

            List<IdName> IntersectEmplList = emplList.Intersect(_preset.Employees, new IdNameComparer()).ToList();
            List<IdName> ExceptEmplList = emplList.Except(_preset.Employees, new IdNameComparer()).ToList();

            for (int i = 0; i < IntersectEmplList.Count; i++)
            {
                clbEmployees.Items.Add($"{IntersectEmplList[i].name} ({IntersectEmplList[i].id})", true);
            }
            for (int i = 0; i < ExceptEmplList.Count; i++)
            {
                clbEmployees.Items.Add($"{ExceptEmplList[i].name} ({ExceptEmplList[i].id})", false);
            }


            List<IdName> IntersectProjList = projList.Intersect(_preset.Projects).ToList();
            List<IdName> ExceptProjList = projList.Except(_preset.Projects).ToList();

            for (int i = 0; i < IntersectProjList.Count; i++)
            {
                clbProjects.Items.Add($"{IntersectProjList[i].name} ({IntersectProjList[i].id})", true);
            }
            for (int i = 0; i < ExceptProjList.Count; i++)
            {
                clbProjects.Items.Add($"{ExceptProjList[i].name} ({ExceptProjList[i].id})", false);
            }

            List<Status> IntersectStatList = statList.Intersect(_preset.Statuses).ToList();
            List<Status> ExceptStatList = statList.Except(_preset.Statuses).ToList();

            for (int i = 0; i < IntersectStatList.Count; i++)
            {
                clbStatus.Items.Add($"{IntersectStatList[i].Name} ({IntersectStatList[i].ID})", true);
            }
            for (int i = 0; i < ExceptStatList.Count; i++)
            {
                clbStatus.Items.Add($"{ExceptStatList[i].Name} ({ExceptStatList[i].ID})", false);
            }

        }

        private void Dict(CheckedListBox clb, string query)
        {           
            DataRow[] dr = DBman.OpenQuery(query).Select("");
            for (int i = 0; i < dr.Length; i++)
            {
                IdName newIdName = new IdName
                {
                    id = Convert.ToInt32(dr[i][0]),
                    name = dr[i][1].ToString()
                };
                clb.Items.Add($"{dr[i][1]} ({dr[i][0].ToString()})");
                //list.Add()
            }    
            
        }

        private void clbStatus_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<string> ls = new List<string>();
        }
    }
}