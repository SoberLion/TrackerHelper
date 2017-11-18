using System;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
//using LiveCharts.WinForms;

namespace TrackerHelper
{
    public partial class PieChartEx : Form
    {
        public PieChartEx()
        {
            //InitializeComponent();

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            PieChart pieChart1 = new PieChart();            
            pieChart1.Width = 500;
            pieChart1.Height = 500;

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Maria",
                    Values = new ChartValues<double> {3},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Charles",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frida",
                    Values = new ChartValues<double> {6},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frederic",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PieChartEx
            // 
            this.ClientSize = new System.Drawing.Size(313, 301);
            this.Name = "PieChartEx";
            this.Load += new System.EventHandler(this.PieChartEx_Load);
            this.ResumeLayout(false);

        }

        private void PieChartEx_Load(object sender, EventArgs e)
        {

        }
    }
}