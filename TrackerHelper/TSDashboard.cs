using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace TrackerHelper
{
    public partial class TSDashboard : UserControl
    {
        public TSDashboard()
        {
            InitializeComponent();
            sgNewIssues.FromColor = Color.FromRgb(255, 0, 0);
            sgNewIssues.ToColor = Color.FromRgb(255, 0, 0);
            sgNewIssues.To = 100;
            sgNewIssues.Value = 78;
        }

        private void TSDashboard_Load(object sender, EventArgs e)
        {

        }

        public void updateTSPieChartProjects(LiveCharts.WinForms.PieChart pieChart)
        {
            
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            UpdatePieChartProjects();
            UpdateCartesianChart();
        }

        public void UpdatePieChartProjects()
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            string userIdList = "(2361,2374,1830,2233,1240,1383,2886,2235,1521,2232,1537,2535,551,894,3713,328)";
            string statusIdList = "(3,5,6,19,26,27,29,30)";

            DataTable dt = DBman.OpenQuery($"select count (*) as IssuesCount, projectName from issues where AssignedToId in {userIdList} and statusId not in {statusIdList} group by ProjectName order by IssuesCount desc");
            DataRow[] dr = dt.Select("");
            SeriesCollection col = new SeriesCollection();
            List<string> ls = dr.Select(p => p[0].ToString()).ToList();

            int sum = ls.Sum(p => Convert.ToInt32(p));
            int otherIssuesSum = 0;
            int otherCounter = 0;
            for (int i = 0; i < dr.Length; i++)
            {
                if (Convert.ToInt32(dr[i][0]) < (sum / 250))
                {
                    otherIssuesSum += Convert.ToInt32(dr[i][0]);
                    otherCounter++;
                    continue;
                }
                PieSeries columnSeries = new PieSeries
                {
                    Title = dr[i][1].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dr[i][0]) },
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                };
                col.Add(columnSeries);
            }
            PieSeries otherSeries = new PieSeries
            {
                Title = "Другие проекты < 0.4%: " + otherCounter.ToString(),
                Values = new ChartValues<int> { otherIssuesSum },
                LabelPoint = point => point.Y.ToString(),
                DataLabels = true,
            };
            col.Add(otherSeries);

            pieChartProjects.Series = col;
        }

        public void UpdateCartesianChart()
        {
            cartesianChart.AxisX.Clear();
            cartesianChart.AxisY.Clear();

            string userIdList = "(2361,2374,1830,2233,1240,1383,2886,2235,1521,2232,1537,2535,551,894,3713,328)";
            string statusIdList = "(3,5,6,19,26,27,29,30)";


            DataTable dt = DBman.OpenQuery($"select count (*) as IssuesCount, StatusName, AssignedToName from issues where AssignedToId in {userIdList} and statusId not in {statusIdList} group by StatusId, AssignedToName order by AssignedToName");
            DataRow[] dr = dt.Select("");
            SeriesCollection col = new SeriesCollection();
            List<int> ListIssuesCount = dr.Select(p => Convert.ToInt32(p[0])).ToList();
            List<string> ListStatusName = dr.Select(p => p[1].ToString()).Distinct().ToList();

            foreach (var item in ListStatusName)
            {
                StackedColumnSeries columnSeries = new StackedColumnSeries
                {
                    Title = item,
                    Values = new ChartValues<int>(),
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                };
                col.Add(columnSeries);
            }

        /*    for (int i = 0; i < dr.Length; i++)
            {
                if (col[i].Title == dr[i][1].ToString())
                {
                    col[i].Values.Add(Convert.ToInt32(dr[i][0]));
                }
                else
                {
                    col[i].Values.Add(0);
                }
            }*/



            cartesianChart.Series = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Values = new ChartValues<double> {4, 5, 6, 8},
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<double> {2, 5, 6, 7},
                    StackMode = StackMode.Values,
                    DataLabels = true
                }
            };

            //adding series updates and animates the chart
            cartesianChart.Series.Add(new StackedColumnSeries
            {
                Values = new ChartValues<double> { 6, 2, 7 },
                StackMode = StackMode.Values
            });

            //adding values also updates and animates
            cartesianChart.Series[2].Values.Add(4d);

            cartesianChart.AxisX.Add(new Axis
            {
                Title = "Browser",
                Labels = new[] { "Chrome", "Mozilla", "Opera", "IE" },
                Separator = DefaultAxes.CleanSeparator,
                Foreground = Brushes.White
            });

            cartesianChart.AxisY.Add(new Axis
            {
                Title = "Usage",
                LabelFormatter = value => value + " Mill",
                Foreground = Brushes.White
            });
        }
    }
}
