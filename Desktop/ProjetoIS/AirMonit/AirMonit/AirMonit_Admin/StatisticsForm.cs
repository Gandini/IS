using AirMonit_Service.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AirMonit_Admin
{
    public partial class StatisticsForm : Form
    {
        private String city;
        public StatisticsForm(String city)
        {
            this.city = city;
            InitializeComponent();
            init();
        }

        private void init()
        {
           // chartCO.Series.Add("Maximum");
           // chartCO.Series.Add("Average");
           // chartCO.Series.Add("Minimum");
            chartCO.ChartAreas.Add("ChartAreaPH");
            chartCO.Legends.Add(new Legend("Media"));
            // chartNH3.Legends.Add(new Legend("Media"));
            // chartCI2.Legends.Add(new Legend("Media"));

            chartCO.Series["Minimum"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartCO.Series["Minimum"].IsXValueIndexed = true;
            chartCO.Series["Minimum"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartCO.Series["Minimum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartCO.Series["Average"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartCO.Series["Average"].IsXValueIndexed = true;
            chartCO.Series["Average"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartCO.Series["Average"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartCO.Series["Maximum"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartCO.Series["Maximum"].IsXValueIndexed = true;
            chartCO.Series["Maximum"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartCO.Series["Maximum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartCO.ChartAreas["ChartAreaPH"].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.FixedCount;
            chartCO.ChartAreas["ChartAreaPH"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartCO.ChartAreas["ChartAreaPH"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartCO.ChartAreas["ChartAreaPH"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartCO.ChartAreas["ChartAreaPH"].AxisX.MajorGrid.Interval = 1;
            chartCO.ChartAreas["ChartAreaPH"].AxisX.Title = "Hours";
            chartCO.ChartAreas["ChartAreaPH"].AxisY.Title = "Values";

            /*  chartNH3.Series.Add("Maximum");
              chartNH3.Series.Add("Average");
              chartNH3.Series.Add("Minimum");
              chartNH3.ChartAreas.Add("ChartAreaNH3");

              chartNH3.Series["Minimum"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
              chartNH3.Series["Minimum"].IsXValueIndexed = true;
              chartNH3.Series["Minimum"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
              chartNH3.Series["Minimum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
              chartNH3.Series["Average"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
              chartNH3.Series["Average"].IsXValueIndexed = true;
              chartNH3.Series["Average"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
              chartNH3.Series["Average"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
              chartNH3.Series["Maximum"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
              chartNH3.Series["Maximum"].IsXValueIndexed = true;
              chartNH3.Series["Maximum"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
              chartNH3.Series["Maximum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
              chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.FixedCount;
              chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
              chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
              chartNH3.ChartAreas["ChartAreaNH3"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
              chartNH3.ChartAreas["ChartAreaNH3"].AxisX.MajorGrid.Interval = 1;
              chartNH3.ChartAreas["ChartAreaNH3"].AxisX.Title = "Hours";
              chartNH3.ChartAreas["ChartAreaNH3"].AxisY.Title = "Values";

              chartCI2.Series.Add("Maximum");
              chartCI2.Series.Add("Average");
              chartCI2.Series.Add("Minimum");
              chartCI2.ChartAreas.Add("ChartAreaCI2");

              chartCI2.Series["Minimum"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
              chartCI2.Series["Minimum"].IsXValueIndexed = true;
              chartCI2.Series["Minimum"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
              chartCI2.Series["Minimum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
              chartCI2.Series["Average"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
              chartCI2.Series["Average"].IsXValueIndexed = true;
              chartCI2.Series["Average"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
              chartCI2.Series["Average"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
              chartCI2.Series["Maximum"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
              chartCI2.Series["Maximum"].IsXValueIndexed = true;
              chartCI2.Series["Maximum"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
              chartCI2.Series["Maximum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
              chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.FixedCount;
              chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
              chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
              chartCI2.ChartAreas["ChartAreaCI2"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
              chartCI2.ChartAreas["ChartAreaCI2"].AxisX.MajorGrid.Interval = 1;
              chartCI2.ChartAreas["ChartAreaCI2"].AxisX.Title = "Hours";
              chartCI2.ChartAreas["ChartAreaCI2"].AxisY.Title = "Values";
              */
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //  [Route("api/CO/date/{date}/local/{local}")]   
            HttpWebRequest requestCO = WebRequest.Create(@"http://localhost:52643/api/CO/date/" + dtpDay.Value.ToShortDateString().Replace("/", "-") + "/local/" + city ) as HttpWebRequest;
            //checkBox1.Text = "http://localhost:52643/api/CO/date/" + dtpDay.Value.ToShortDateString().Replace("/", "-") + "/local/" + city ;
            
            requestCO.ContentType = "application/json";
            HttpWebResponse responseCO = requestCO.GetResponse() as HttpWebResponse;
            string jsonCO = new StreamReader(responseCO.GetResponseStream()).ReadToEnd();
            List<Statistics> valoresCO = JsonConvert.DeserializeObject<List<Statistics>>(jsonCO);

            chartCO.Series["Average"].Points.Clear();
            chartCO.Series["Minimum"].Points.Clear();
            chartCO.Series["Maximum"].Points.Clear();
            chartCO.Legends["Media"].DockedToChartArea = "ChartAreaCO";
            chartCO.Legends["Media"].IsDockedInsideChartArea = true;
            for (int i = 0; i < valoresCO.Count; i++)
            {
                chartCO.Series["Average"].Points.Add().SetValueXY(valoresCO[i].date, Math.Round((decimal)valoresCO[i].avg, 2));
                chartCO.Series["Minimum"].Points.Add().SetValueXY(valoresCO[i].date, Math.Round((decimal)valoresCO[i].min, 2));
                chartCO.Series["Maximum"].Points.Add().SetValueXY(valoresCO[i].date, Math.Round((decimal)valoresCO[i].max, 2));
            }

            float maximum = 0;
            int index = 0;
            for (int i = 0; i < 7 && i < valoresCO.Count; i++)
            {
                if (valoresCO[i].max > maximum)
                {
                    maximum = valoresCO[i].max;
                    index = i;
                }
            }

            chartCO.ChartAreas["ChartAreaCO"].AxisY.Maximum = Math.Round((double)valoresCO[index].max + 3);

            float minimum = 10;
            index = 0;
            for (int i = 0; i < 7 && i < valoresCO.Count; i++)
            {
                if (valoresCO[i].min < minimum)
                {
                    minimum = valoresCO[i].min;
                    index = i;
                }
            }
            if (valoresCO[index].min > 2)
            {
                chartCO.ChartAreas["ChartAreaCO"].AxisY.Minimum = Math.Round((double)valoresCO[index].min - 2);
            }
            else
            {
                chartCO.ChartAreas["ChartAreaCO"].AxisY.Minimum = 0;
            }

          /*  for (int i = 0; i < valoresCO.Count; i++)
            {
                listBoxCO.Items.Add("City: " + valoresCO[i].local + "  Value: " + valoresCO[i].value + " Date: " + valoresCO[i].date);
            }*/
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
