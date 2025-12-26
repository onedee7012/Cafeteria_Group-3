using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }
        public void LoadRevenueChart(Dictionary<DateTime, float> revenueByDate)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("Main");
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Daily Revenue");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (var item in revenueByDate.OrderBy(x => x.Key))
            {
                series.Points.AddXY(item.Key.ToString("dd/MM/yyyy"), item.Value);
            }
            chart1.Series.Add(series);
            chart1.ChartAreas["Main"].AxisX.LabelStyle.Format = "dd/MM/yyyy";
            chart1.ChartAreas["Main"].AxisX.LabelStyle.Angle = -45;
            chart1.ChartAreas["Main"].AxisX.Interval = 1;
        }
        public void LoadRevenueByStaffChart(Dictionary<string, float> revenueByStaff)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("Main");
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Revenue by Staff");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (var item in revenueByStaff.OrderBy(x => x.Key))
            {
                series.Points.AddXY(item.Key, item.Value);
            }
            chart1.Series.Add(series);
            chart1.ChartAreas["Main"].AxisX.LabelStyle.Angle = -45;
            chart1.ChartAreas["Main"].AxisX.Interval = 1;
        }
    }
}
