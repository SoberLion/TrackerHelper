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
        string dateFormat = "yyyy-MM-dd hh:mm:ss:fff";
        public static string userIdList = "(2361,2374,1830,2233,1240,1383,2886,2235,1521,2232,1537,2535,551,894,3713,328)";

        public TSDashboard()
        {
            InitializeComponent();            
        }

        private void TSDashboard_Load(object sender, EventArgs e)
        {

        }

        public void updateTSPieChartProjects(LiveCharts.WinForms.PieChart pieChart)
        {
            
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            UpdateTSDashboard();
        }

        public void UpdateTSDashboard()
        {
            UpdatePieChartProjects();
            UpdatePieChartStatus();
            UpdateCartesianChart();
            UpdateGaugeClosedByWeek();
            UpdateGaugeNewByWeek();
            UpdateGaugeAssigned();
        }

        public DateTime getFirstDayofWeekDate(DateTime Date)
        {
            while (Date.DayOfWeek != DayOfWeek.Monday)
                Date = Date.AddDays(-1);
            return Date;
        }

        public void UpdatePieChartProjects()
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
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

        public void UpdatePieChartStatus()
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            string statusIdList = "(3,5,6,19,26,27,29,30)";

            DataTable dt = DBman.OpenQuery($"SELECT count (*) as IssuesCount, StatusName FROM issues WHERE AssignedToId in {userIdList} AND statusId NOT IN {statusIdList} GROUP BY StatusName ORDER BY IssuesCount desc");
            DataRow[] dr = dt.Select("");
            SeriesCollection col = new SeriesCollection();
            List<string> ls = dr.Select(p => p[0].ToString()).ToList();

            int sum = ls.Sum(p => Convert.ToInt32(p));
            int otherIssuesSum = 0;
            int otherCounter = 0;
            for (int i = 0; i < dr.Length; i++)
            {
                if (Convert.ToInt32(dr[i][0]) < (sum / 100))
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
                Title = "Другие статусы < 0.4%: " + otherCounter.ToString(),
                Values = new ChartValues<int> { otherIssuesSum },
                LabelPoint = point => point.Y.ToString(),
                DataLabels = true,
            };
            col.Add(otherSeries);

            pieChartStatus.Series = col;
        }

        public void UpdateCartesianChart()
        {
            cartesianChart.AxisX.Clear();
            cartesianChart.AxisY.Clear();

            string statusIdList = "(3,5,6,19,26,27,29,30)";


            DataTable dt = DBman.OpenQuery($"select count (*) as IssuesCount, StatusName, AssignedToName from issues where AssignedToId in {userIdList} and statusId not in {statusIdList} group by StatusName, AssignedToName order by AssignedToName, StatusName");
            DataRow[] dr = dt.Select("");
            SeriesCollection col = new SeriesCollection();
            List<int> ListIssuesCount = dr.Select(p => Convert.ToInt32(p[0])).ToList();
            List<string> ListStatusName = dr.Select(p => p[1].ToString()).Distinct().ToList();
            List<string> AssignedToNameList = dr.Select(p => p[2].ToString().Split(' ')[0]).Distinct().ToList();

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
            int rowiterator = 0;
            foreach (string Name in AssignedToNameList)
            {
                for (int i = 0; i < col.Count; i++)
                {
                    if (col[i].Title == dr[rowiterator][1].ToString())
                    {
                        col[i].Values.Add(Convert.ToInt32(dr[rowiterator][0]));
                        if (rowiterator < dr.Length)
                        {
                            rowiterator++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        col[i].Values.Add(0);
                    }
                }
            }

            Axis ax = new Axis
            {
                Separator = new Separator { Step = 1, IsEnabled = false },
                Labels = AssignedToNameList,
                LabelsRotation = 70,
                Foreground = Brushes.White
            };
            
            cartesianChart.Series = col;
            cartesianChart.AxisX.Add(ax);
        }

        private void UpdateGaugeAssigned()
        {
            sgAssigned.To = 200;
            sgAssigned.FromColor = Color.FromRgb(34, 135, 216);
            sgAssigned.ToColor = Color.FromRgb(34, 135, 216);
            sgAssigned.ForeGround = new SolidColorBrush(Color.FromRgb(34, 135, 216));

            string query = $"SELECT count(*) FROM Issues WHERE AssignedToId in {userIdList} AND StatusId = 9";

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgAssigned.Value = Convert.ToDouble(dr[0][0]);
        }

        public void UpdateGaugeNewByWeek()
        {
            sgNewIssues.FromColor = Color.FromRgb(255, 0, 0);
            sgNewIssues.ToColor = Color.FromRgb(255, 0, 0);          
            sgNewIssues.ForeGround = Brushes.Red;

            string firstDayOfWeek = getFirstDayofWeekDate(DateTime.Now).ToString("yyyy-MM-dd 00:00:00,001");
            string now = DateTime.Now.ToString(dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE CreatedOn >= '{DateTime.Now.ToString("yyyy-01-01 00:00:00")}' AND CreatedOn < '{DateTime.Now.ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%W', CreatedOn) ORDER BY cnt desc limit 1";
            string query = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{firstDayOfWeek}' AND CreatedOn < '{now}' AND AssignedToId in {userIdList}";

            sgNewIssues.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);
                                             
            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgNewIssues.Value = Convert.ToDouble(dr[0][0]);
        }

        public void UpdateGaugeNewByMonth()
        {
            sgNewIssues.FromColor = Color.FromRgb(255, 0, 0);
            sgNewIssues.ToColor = Color.FromRgb(255, 0, 0);
            sgNewIssues.ForeGround = Brushes.Red;

            string firstDayOfMonth = DateTime.Now.ToString("yyyy-MM-01 00:00:01");
            string now = DateTime.Now.ToString(dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE CreatedOn >= '{DateTime.Now.ToString("yyyy-01-01 00:00:00")}' AND CreatedOn < '{DateTime.Now.ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%m', CreatedOn) ORDER BY cnt desc limit 1";
            
            string query = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{firstDayOfMonth}' AND CreatedOn < '{now}' AND AssignedToId in {userIdList}";

            sgNewIssues.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgNewIssues.Value = Convert.ToDouble(dr[0][0]);
        }

        public void UpdateGaugeClosedByMonth()
        {
            sgClosed.FromColor = Color.FromRgb(128, 128, 128);
            sgClosed.ToColor = Color.FromRgb(128, 128, 128);
            sgClosed.ForeGround = Brushes.Gray;

            string firstDayOfMonth = DateTime.Now.ToString("yyyy-MM-01 00:00:01");
            string now = DateTime.Now.ToString(dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE ClosedOn >= '{DateTime.Now.ToString("yyyy-01-01 00:00:00")}' AND ClosedOn < '{DateTime.Now.ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%m', CreatedOn) ORDER BY cnt desc limit 1";

            string query = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{firstDayOfMonth}' AND ClosedOn < '{now}' AND AssignedToId in {userIdList}";

            sgClosed.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgClosed.Value = Convert.ToDouble(dr[0][0]);
        }

        public void UpdateGaugeClosedByWeek()
        {
            sgClosed.FromColor = Color.FromRgb(128, 128, 128);
            sgClosed.ToColor = Color.FromRgb(128, 128, 128);
            sgClosed.ForeGround = Brushes.Gray;

            string firstDayOfWeek = getFirstDayofWeekDate(DateTime.Now).ToString("yyyy-MM-dd 00:00:00,001");
            string now = DateTime.Now.ToString(dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE ClosedOn >= '{DateTime.Now.ToString("yyyy-01-01 00:00:00")}' AND ClosedOn < '{DateTime.Now.ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%m', CreatedOn) ORDER BY cnt desc limit 1";


            string query = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{firstDayOfWeek}' AND ClosedOn < '{now}' AND AssignedToId in {userIdList}";

            sgClosed.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgClosed.Value = Convert.ToDouble(dr[0][0]);
        }

        #region  ------------------------------ 
        public void UpdateGaugeNewByWeekLastYear()
        {
            sgNewLastYear.FromColor = Color.FromRgb(255, 0, 0);
            sgNewLastYear.ToColor = Color.FromRgb(255, 0, 0);
            sgNewLastYear.ForeGround = Brushes.Red;
            sgNewLastYear.BackColor = System.Drawing.Color.FromArgb(255, 158, 68);

            string firstDayOfWeek = getFirstDayofWeekDate(DateTime.Now).AddYears(-1).ToString("yyyy-MM-dd 00:00:00,001");
            string now = DateTime.Now.AddYears(-1).ToString(dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE CreatedOn >= '{DateTime.Now.AddYears(-1).ToString("yyyy-01-01 00:00:00")}' AND CreatedOn < '{DateTime.Now.AddYears(-1).ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%W', CreatedOn) ORDER BY cnt desc limit 1";
            string query = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{firstDayOfWeek}' AND CreatedOn < '{now}' AND AssignedToId in {userIdList}";

            sgNewLastYear.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgNewLastYear.Value = Convert.ToDouble(dr[0][0]);
        }

        public void UpdateGaugeNewByMonthLastYear()
        {
            sgNewLastYear.FromColor = Color.FromRgb(255, 0, 0);
            sgNewLastYear.ToColor = Color.FromRgb(255, 0, 0);
            sgNewLastYear.ForeGround = Brushes.Red;
            sgNewLastYear.BackColor = System.Drawing.Color.FromArgb(255, 158, 68);

            string firstDayOfMonth = DateTime.Now.AddYears(-1).ToString("yyyy-MM-01 00:00:01");
            string now = DateTime.Now.AddYears(-1).ToString(dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE CreatedOn >= '{DateTime.Now.AddYears(-1).ToString("yyyy-01-01 00:00:00")}' AND CreatedOn < '{DateTime.Now.AddYears(-1).ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%m', CreatedOn) ORDER BY cnt desc limit 1";

            string query = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{firstDayOfMonth}' AND CreatedOn < '{now}' AND AssignedToId in {userIdList}";

            sgNewLastYear.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgNewLastYear.Value = Convert.ToDouble(dr[0][0]);
        }

        public void UpdateGaugeClosedByMonthLastYear()
        {
            sgClosedLastYear.FromColor = Color.FromRgb(128, 128, 128);
            sgClosedLastYear.ToColor = Color.FromRgb(128, 128, 128);
            sgClosedLastYear.ForeGround = Brushes.Gray;
            sgClosedLastYear.BackColor = System.Drawing.Color.FromArgb(255, 158, 68);

            string firstDayOfMonth = DateTime.Now.AddYears(-1).ToString("yyyy-MM-01 00:00:01");
            string now = DateTime.Now.AddYears(-1).ToString(dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE ClosedOn >= '{DateTime.Now.AddYears(-1).ToString("yyyy-01-01 00:00:00")}' AND ClosedOn < '{DateTime.Now.AddYears(-1).ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%m', CreatedOn) ORDER BY cnt desc limit 1";

            string query = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{firstDayOfMonth}' AND ClosedOn < '{now}' AND AssignedToId in {userIdList}";

            sgClosedLastYear.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgClosedLastYear.Value = Convert.ToDouble(dr[0][0]);
        }

        public void UpdateGaugeClosedByWeekLastYear()
        {
            sgClosedLastYear.FromColor = Color.FromRgb(128, 128, 128);
            sgClosedLastYear.ToColor = Color.FromRgb(128, 128, 128);
            sgClosedLastYear.ForeGround = Brushes.Gray;
            sgClosedLastYear.BackColor = System.Drawing.Color.FromArgb(255, 158, 68);

            string firstDayOfWeek = getFirstDayofWeekDate(DateTime.Now).AddYears(-1).ToString("yyyy-MM-dd 00:00:00,001");
            string now = DateTime.Now.AddYears(-1).ToString(dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE ClosedOn >= '{DateTime.Now.AddYears(-1).ToString("yyyy-01-01 00:00:00")}' AND ClosedOn < '{DateTime.Now.AddYears(-1).ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%m', CreatedOn) ORDER BY cnt desc limit 1";


            string query = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{firstDayOfWeek}' AND ClosedOn < '{now}' AND AssignedToId in {userIdList}";

            sgClosedLastYear.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgClosedLastYear.Value = Convert.ToDouble(dr[0][0]);
        }

        #endregion

        private void btnMonth_Click(object sender, EventArgs e)
        {
            UpdateGaugeNewByMonth();
            UpdateGaugeClosedByMonth();
            UpdateGaugeNewByMonthLastYear();
            UpdateGaugeClosedByMonthLastYear();
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            UpdateGaugeClosedByWeek();
            UpdateGaugeNewByWeek();
            UpdateGaugeNewByWeekLastYear();
            UpdateGaugeClosedByWeekLastYear();
        }

        
    }
}
