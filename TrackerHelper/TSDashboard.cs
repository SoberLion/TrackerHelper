using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;
using TrackerHelper.DB;
using System.Text;

namespace TrackerHelper
{
    public partial class TSDashboard : UserControl
    {
        string _dateFormat = "yyyy-MM-dd HH:mm:ss:fff";
        static string _userIdList = "2361,2374,1830,2233,1240,1383,2886,2235,1521,2232,1537,2535,551,894,3713,328";
        static string _statusIdList = "3,5,6,19,26,27,29,30";

        public TSDashboard()
        {
            InitializeComponent();
            cartesianChart.DataTooltip.Background = Brushes.Gainsboro;
            pieChartProjects.DataTooltip.Background = Brushes.Gainsboro;
            pieChartStatus.DataTooltip.Background = Brushes.Gainsboro;
            pieChartCategory.DataTooltip.Background = Brushes.Gainsboro;
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
            UpdatePieChartProjects(_userIdList);
            UpdatePieChartStatus(_userIdList);
            UpdatePieChartCategory(_userIdList);
            CartesianChartStackedColumns(_userIdList);
            btnWeek_Click(btnWeek, EventArgs.Empty);

            UpdateLblStatusValue(lblStatusNewValue, "1", _userIdList);
            UpdateLblStatusValue(lblStatusAssignedValue, "9", _userIdList);
            UpdateLblStatusValue(lblStatusEscalatedValue, "22", _userIdList);

            CheckStatusOverdue(lblStatusNewOverduedValue,pnlStatusNew, 10, 18, 5, _userIdList, "1");
            CheckStatusOverdue(lblStatusAssignedOverduedValue, pnlStatusAssigned, 10, 18, 72, _userIdList, "9");
            CreateUsersButtons(_userIdList);
        }

        private DateTime getFirstDayofWeekDate(DateTime Date)
        {
            while (Date.DayOfWeek != DayOfWeek.Monday)
                Date = Date.AddDays(-1);
            return Date;
        }

        private void CreateUsersButtons(string userIdList)
        {
            if (pnlTopRight.Controls.Count > 0)
                return;

            string query = $"SELECT DISTINCT AssignedToName, AssignedToId FROM Issues WHERE AssignedToId IN ({userIdList}) ORDER BY AssignedToName desc";

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            for(int i = 0; i < dr.Length; i++)
            {
                CheckedButton btn = new CheckedButton
                {
                    Name = "btn"+dr[i][0].ToString(),
                    Parent = pnlTopRight,
                    Text = dr[i][0].ToString(),
                    Tag = dr[i][1],
                    Dock = DockStyle.Top,
                    Height = 30,
                    ForeColor = System.Drawing.Color.FromArgb(86, 88, 86),
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                    TextAlign = System.Drawing.ContentAlignment.MiddleRight
                    
            };
                btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
                btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += btnUsers_Click;
                btn.CheckedChange += btnUsersCheckedChange;
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (sender is CheckedButton cb)
            {
                BtnUsersToggle(sender);
                string id = cb.Tag.ToString();

                UpdatePieChartProjects(id);
                UpdatePieChartStatus(id);
                UpdateLblStatusValue(lblStatusNewValue, "1", id);
                UpdateLblStatusValue(lblStatusAssignedValue, "9", id);
                CartesianChartColumns(id);
            }            
        }

        private void UpdatePieChartProjects(string userIdList)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);            

            DataTable dt = DBman.OpenQuery($"select count (*) as IssuesCount, projectName from issues where AssignedToId in ({userIdList}) and statusId not in ({_statusIdList}) group by ProjectName order by IssuesCount desc");
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
                Title = "Другие проекты < 1%: " + otherCounter.ToString(),
                Values = new ChartValues<int> { otherIssuesSum },
                LabelPoint = point => point.Y.ToString(),
                DataLabels = true,
            };
            col.Add(otherSeries);

            pieChartProjects.Series = col;
        }

        private void PieChartOtherProjects(string userIdList)
        {
            string query = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}",
                "SELECT * ",
                    "FROM (SELECT count (*) as IssuesCount,projectName ",
                          "FROM Issues ",
                         $"WHERE AssignedToId in ({userIdList}) and statusId not in ({_statusIdList}) ",
                          "GROUP BY issues.ProjectName) GroupedIssues ",
                   "WHERE GroupedIssues.IssuesCount < ",
                          $"(select Count(*) from issues where AssignedToId in ({userIdList}) and statusId not in ({_statusIdList})) / 100 ",
                   "ORDER BY IssuesCount desc"
                          );

            DataTable dt = DBman.OpenQuery(query);

            SeriesCollection col = new SeriesCollection();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PieSeries columnSeries = new PieSeries
                {
                    Title = dt.Rows[i][1].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dt.Rows[i][0]) },
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                };
                col.Add(columnSeries);
            }

            pieChartProjects.Series = col;
        }

        private void UpdatePieChartStatus(string userIdList)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataTable dt = DBman.OpenQuery($"SELECT count (*) as IssuesCount, StatusName FROM issues WHERE AssignedToId in ({userIdList}) AND statusId NOT IN ({_statusIdList}) GROUP BY StatusName ORDER BY IssuesCount desc");
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
                Title = "Другие статусы < 1%: " + otherCounter.ToString(),
                Values = new ChartValues<int> { otherIssuesSum },
                LabelPoint = point => point.Y.ToString(),
                DataLabels = true,
            };
            col.Add(otherSeries);

            pieChartStatus.Series = col;
        }

        private void UpdatePieChartCategory(string userIdList)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataTable dt = DBman.OpenQuery($"SELECT count (*) as IssuesCount, CategoryName FROM issues WHERE AssignedToId in ({userIdList}) AND statusId NOT IN ({_statusIdList}) GROUP BY CategoryName ORDER BY IssuesCount desc");
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
                Title = "Другие категории < 1%: " + otherCounter.ToString(),
                Values = new ChartValues<int> { otherIssuesSum },
                LabelPoint = point => point.Y.ToString(),
                DataLabels = true,
            };
            col.Add(otherSeries);

            pieChartCategory.Series = col;
        }

        private void CartesianChartStackedColumns(string userIdList)
        {
            string query = $"select count (*) as IssuesCount, StatusName, AssignedToName from issues where AssignedToId in ({userIdList}) and statusId not in ({_statusIdList}) group by StatusName, AssignedToName order by AssignedToName, StatusName";
            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");

            SeriesCollection col = new SeriesCollection();

            List<int> ListIssuesCount = dr.Select(p => Convert.ToInt32(p[0])).ToList();
            List<string> ListStatusName = dr.Select(p => p[1].ToString()).Distinct().ToList();
            List<string> AssignedToNameList = dr.Select(p => p[2].ToString().Split(' ')[0]).Distinct().ToList();
            ListStatusName.Sort();

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
                        if (rowiterator < dr.Length -1)
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
                Foreground = Brushes.Gainsboro
            };

            cartesianChart.AxisX.Clear();
            cartesianChart.AxisY.Clear();

            cartesianChart.Series = col;
            cartesianChart.AxisX.Add(ax);
        }

        private void CartesianChartColumns(string userIdList)
        {
            string query = $"select count (*) as StatusCount, StatusName from issues where AssignedToId in ({userIdList}) and statusId not in ({_statusIdList}) group by StatusName order by StatusCount desc";
            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");

            SeriesCollection col = new SeriesCollection();            

            Axis ay = new Axis { LabelFormatter = value => value.ToString(), Separator = new Separator(), MinValue = 0 };

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ColumnSeries columnSeries = new ColumnSeries
                {
                    Title = dt.Rows[i][1].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dt.Rows[i][0]) },
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                    Foreground = Brushes.Gainsboro
                };
                col.Add(columnSeries);
            }

            cartesianChart.AxisX.Clear();
            cartesianChart.AxisY.Clear();

            cartesianChart.Series = col;
            cartesianChart.AxisY.Add(ay);


         //   cartesianChart.DataTooltip. .SelectionMode = LiveCharts.TooltipSelectionMode.OnlySender;

        }

        public void CheckStatusOverdue(object label, object panel, int hoursFrom, int hoursTo, int hoursToOverdue, string userIdList, string statusId)
        {
            string overdue;            

            overdue = DateTime.Now.AddHours(-GetHours(hoursFrom, hoursTo, hoursToOverdue)).ToString(_dateFormat);

            string query = $"SELECT count(*) from issues WHERE statusid = {statusId} AND createdOn < '{overdue}' AND AssignedToId in ({userIdList}) and projectId in (26, 220)";

            DataTable dt = DBman.OpenQuery(query);

            (label as Label).Text = dt.Rows[0][0].ToString();
            (panel as Panel).Tag = overdue + "," + statusId;
        }

        public int GetHours(int hoursFrom, int hoursTo, int hoursToOverdue)
        {
            int hours = hoursToOverdue;
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && (DateTime.Now.Hour - hours) < hoursFrom)
            {
                hours = 24 * 3 - hoursTo + hoursFrom + hours;
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                hours = 24 * 2 - hoursTo + hoursFrom + hours;
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                hours = 24 - hoursTo + hoursFrom + hours;
            }
            if ((DateTime.Now.DayOfWeek == DayOfWeek.Tuesday ||
               DateTime.Now.DayOfWeek == DayOfWeek.Wednesday ||
               DateTime.Now.DayOfWeek == DayOfWeek.Thursday ||
               DateTime.Now.DayOfWeek == DayOfWeek.Friday) && ((DateTime.Now.Hour - hours) < hoursFrom))
            {
                hours = 24 - hoursTo + hoursFrom + hours;
            }
            return hours;
        }

        public void UpdateLblStatusValue(object obj, string statusId, string userIdList)
        {
            string query = $"SELECT count(*) FROM Issues WHERE AssignedToId in ({userIdList}) AND StatusId = {statusId}";
            DataTable dt = DBman.OpenQuery(query);
            (obj as Label).Text = dt.Rows[0][0].ToString();
        }

        #region  ------------------------------ GAUGES -------------------------------

        private void UpdateGaugeNewByWeek(string userIdList)
        {
            sgNewIssues.FromColor = Color.FromRgb(255, 0, 0);
            sgNewIssues.ToColor = Color.FromRgb(255, 0, 0);          
            sgNewIssues.ForeGround = Brushes.Red;

            string firstDayOfWeek = getFirstDayofWeekDate(DateTime.Now).ToString("yyyy-MM-dd 00:00:00,001");
            string now = DateTime.Now.ToString(_dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE CreatedOn >= '{DateTime.Now.ToString("yyyy-01-01 00:00:00")}' AND CreatedOn < '{DateTime.Now.ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%W', CreatedOn) ORDER BY cnt desc limit 1";
            string query = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{firstDayOfWeek}' AND CreatedOn < '{now}' AND AssignedToId in ({userIdList})";

            sgNewIssues.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);
                                             
            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgNewIssues.Value = Convert.ToDouble(dr[0][0]);
        }

        private void UpdateGaugeNewByMonth(string userIdList)
        {
            sgNewIssues.FromColor = Color.FromRgb(255, 0, 0);
            sgNewIssues.ToColor = Color.FromRgb(255, 0, 0);
            sgNewIssues.ForeGround = Brushes.Red;

            string firstDayOfMonth = DateTime.Now.ToString("yyyy-MM-01 00:00:01");
            string now = DateTime.Now.ToString(_dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE CreatedOn >= '{DateTime.Now.ToString("yyyy-01-01 00:00:00")}' AND CreatedOn < '{DateTime.Now.ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%m', CreatedOn) ORDER BY cnt desc limit 1";
            
            string query = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{firstDayOfMonth}' AND CreatedOn < '{now}' AND AssignedToId in ({userIdList})";

            sgNewIssues.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgNewIssues.Value = Convert.ToDouble(dr[0][0]);
        }

        private void UpdateGaugeClosedByMonth(string userIdList)
        {
            sgClosed.FromColor = Color.FromRgb(128, 128, 128);
            sgClosed.ToColor = Color.FromRgb(128, 128, 128);
            sgClosed.ForeGround = Brushes.Gray;

            string firstDayOfMonth = DateTime.Now.ToString("yyyy-MM-01 00:00:01");
            string now = DateTime.Now.ToString(_dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE ClosedOn >= '{DateTime.Now.ToString("yyyy-01-01 00:00:00")}' AND ClosedOn < '{DateTime.Now.ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%m', CreatedOn) ORDER BY cnt desc limit 1";

            string query = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{firstDayOfMonth}' AND ClosedOn < '{now}' AND AssignedToId in ({userIdList})";

            sgClosed.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgClosed.Value = Convert.ToDouble(dr[0][0]);
        }

        private void UpdateGaugeClosedByWeek(string userIdList)
        {
            sgClosed.FromColor = Color.FromRgb(128, 128, 128);
            sgClosed.ToColor = Color.FromRgb(128, 128, 128);
            sgClosed.ForeGround = Brushes.Gray;

            string firstDayOfWeek = getFirstDayofWeekDate(DateTime.Now).ToString("yyyy-MM-dd 00:00:00,001");
            string now = DateTime.Now.ToString(_dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE ClosedOn >= '{DateTime.Now.ToString("yyyy-01-01 00:00:00")}' AND ClosedOn < '{DateTime.Now.ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%m', CreatedOn) ORDER BY cnt desc limit 1";


            string query = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{firstDayOfWeek}' AND ClosedOn < '{now}' AND AssignedToId in ({userIdList})";

            sgClosed.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgClosed.Value = Convert.ToDouble(dr[0][0]);
        }
       
        public void UpdateGaugeNewByWeekLastYear(string userIdList)
        {
            sgNewLastYear.FromColor = Color.FromRgb(255, 0, 0);
            sgNewLastYear.ToColor = Color.FromRgb(255, 0, 0);
            sgNewLastYear.ForeGround = Brushes.Red;
            

            string firstDayOfWeek = getFirstDayofWeekDate(DateTime.Now.AddYears(-1)).ToString("yyyy-MM-dd 00:00:00,001");
            string now = DateTime.Now.AddYears(-1).ToString(_dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE CreatedOn >= '{DateTime.Now.AddYears(-1).ToString("yyyy-01-01 00:00:00")}' AND CreatedOn < '{DateTime.Now.AddYears(-1).ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%W', CreatedOn) ORDER BY cnt desc limit 1";
            string query = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{firstDayOfWeek}' AND CreatedOn < '{now}' AND AssignedToId in ({userIdList})";

            sgNewLastYear.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgNewLastYear.Value = Convert.ToDouble(dr[0][0]);
        }

        public void UpdateGaugeNewByMonthLastYear(string userIdList)
        {
            sgNewLastYear.FromColor = Color.FromRgb(255, 0, 0);
            sgNewLastYear.ToColor = Color.FromRgb(255, 0, 0);
            sgNewLastYear.ForeGround = Brushes.Red;

            string firstDayOfMonth = DateTime.Now.AddYears(-1).ToString("yyyy-MM-01 00:00:01");
            string now = DateTime.Now.AddYears(-1).ToString(_dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE CreatedOn >= '{DateTime.Now.AddYears(-1).ToString("yyyy-01-01 00:00:00")}' AND CreatedOn < '{DateTime.Now.AddYears(-1).ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%m', CreatedOn) ORDER BY cnt desc limit 1";

            string query = $"SELECT count(*) FROM Issues WHERE CreatedOn >= '{firstDayOfMonth}' AND CreatedOn < '{now}' AND AssignedToId in ({userIdList})";

            sgNewLastYear.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgNewLastYear.Value = Convert.ToDouble(dr[0][0]);
        }

        public void UpdateGaugeClosedByMonthLastYear(string userIdList)
        {
            sgClosedLastYear.FromColor = Color.FromRgb(128, 128, 128);
            sgClosedLastYear.ToColor = Color.FromRgb(128, 128, 128);
            sgClosedLastYear.ForeGround = Brushes.Gray;
         //   sgClosedLastYear.BackColor = System.Drawing.Color.FromArgb(255, 158, 68);

            string firstDayOfMonth = DateTime.Now.AddYears(-1).ToString("yyyy-MM-01 00:00:01");
            string now = DateTime.Now.AddYears(-1).ToString(_dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE ClosedOn >= '{DateTime.Now.AddYears(-1).ToString("yyyy-01-01 00:00:00")}' AND ClosedOn < '{DateTime.Now.AddYears(-1).ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%m', CreatedOn) ORDER BY cnt desc limit 1";

            string query = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{firstDayOfMonth}' AND ClosedOn < '{now}' AND AssignedToId in ({userIdList})";

            sgClosedLastYear.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgClosedLastYear.Value = Convert.ToDouble(dr[0][0]);
        }

        public void UpdateGaugeClosedByWeekLastYear(string userIdList)
        {
            sgClosedLastYear.FromColor = Color.FromRgb(128, 128, 128);
            sgClosedLastYear.ToColor = Color.FromRgb(128, 128, 128);
            sgClosedLastYear.ForeGround = Brushes.Gray;

            string firstDayOfWeek = getFirstDayofWeekDate(DateTime.Now).AddYears(-1).ToString("yyyy-MM-dd 00:00:00,001");
            string now = DateTime.Now.AddYears(-1).ToString(_dateFormat);

            string maxCntQuery = $"SELECT count(*) as cnt FROM Issues WHERE ClosedOn >= '{DateTime.Now.AddYears(-1).ToString("yyyy-01-01 00:00:00")}' AND ClosedOn < '{DateTime.Now.AddYears(-1).ToString("yyyy-12-31 00:00:00")}' and ProjectId=26 GROUP BY strftime('%m', CreatedOn) ORDER BY cnt desc limit 1";


            string query = $"SELECT count(*) FROM Issues WHERE ClosedOn >= '{firstDayOfWeek}' AND ClosedOn < '{now}' AND AssignedToId in ({userIdList})";

            sgClosedLastYear.To = Convert.ToDouble(DBman.OpenQuery(maxCntQuery).Rows[0][0]);

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            sgClosedLastYear.Value = Convert.ToDouble(dr[0][0]);
        }

        #endregion

        private void btnMonth_Click(object sender, EventArgs e)
        {
            BtnFiltersToggle(sender);
            UpdateGaugeNewByMonth(_userIdList);
            UpdateGaugeClosedByMonth(_userIdList);
            UpdateGaugeNewByMonthLastYear(_userIdList);
            UpdateGaugeClosedByMonthLastYear(_userIdList);
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            BtnFiltersToggle(sender);
            UpdateGaugeClosedByWeek(_userIdList);
            UpdateGaugeNewByWeek(_userIdList);
            UpdateGaugeNewByWeekLastYear(_userIdList);
            UpdateGaugeClosedByWeekLastYear(_userIdList);
        }

        private void pieChartProjects_DataClick(object sender, ChartPoint chartPoint)
        {
            PieChartOtherProjects(_userIdList);
            /*
            var chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;
            var selectedSeries = (PieSeries)chartPoint.SeriesView;  
            var chart = (LiveCharts.WinForms.PieChart)chartPoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartPoint.SeriesView;
            selectedSeries.PushOut = 8;*/
        }

        private void BtnUsersToggle(object sender)
        {
            foreach (var item in pnlTopRight.Controls)
            {
                if (item is CheckedButton cb)
                {
                    cb.Check = false;
                }
            }

            (sender as CheckedButton).Check = true;
        }

        private void btnUsersCheckedChange(object sender, EventArgs e)
        {
            if(sender is CheckedButton cb)
                cb.BackColor = cb.Check == false ? System.Drawing.Color.FromArgb(21, 33, 45) : System.Drawing.Color.FromArgb(41, 53, 65);
        }


        private void BtnFiltersToggle(object sender)
        {
            btnWeek.Check = false;
            btnWeek.BackColor = System.Drawing.Color.FromArgb(41, 53, 65);
            btnMonth.Check = false;
            btnMonth.BackColor = System.Drawing.Color.FromArgb(41, 53, 65);

            (sender as CheckedButton).Check = true;
            (sender as CheckedButton).BackColor = System.Drawing.Color.FromArgb(21, 33, 45);
        }

        private void pnlStatusNew_Click(object sender, EventArgs e)
        {
            StatusPanelClick(sender);
        }

        private void StatusPanelClick(object sender)
        {           
            string[] overdue = (sender as Panel).Tag?.ToString().Split(',');
            if (overdue == null || overdue.Length < 2)
                return;
            string query = $"SELECT IssueId, AssignedToName from issues WHERE statusid = {overdue[1]} AND createdOn < '{overdue[0]}' AND AssignedToId in ({_userIdList}) and projectId in (26, 220)";

            DataTable dt = DBman.OpenQuery(query);
            DataRow[] dr = dt.Select("");
            StringBuilder sb = new StringBuilder();
            foreach (var item in dr)
            {
                sb.AppendLine($"{item[0].ToString()}: {item[1].ToString()}");
            }
            MessageBox.Show(sb.ToString());
        }

        private void pnlStatusAssigned_Click(object sender, EventArgs e)
        {
            StatusPanelClick(sender);
        }
    }
}
