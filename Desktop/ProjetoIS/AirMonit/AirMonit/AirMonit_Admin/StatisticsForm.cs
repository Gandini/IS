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

namespace AirMonit_Admin
{
    public partial class StatisticsForm : Form
    {
        private String city;
        public StatisticsForm(String city)
        {
            this.city = city;
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            HttpWebRequest requestCO = WebRequest.Create(@"http://localhost:52643/api/" + "/CO/date/" + dtpDay.Value.ToShortDateString().Replace("/", "-") + "/local/" + city ) as HttpWebRequest;
            requestCO.ContentType = "application/json";
            HttpWebResponse responseCO = requestCO.GetResponse() as HttpWebResponse;
            string jsonCO = new StreamReader(responseCO.GetResponseStream()).ReadToEnd();
            List<Statistics> valoresCO = JsonConvert.DeserializeObject<List<Statistics>>(jsonCO);

            chartCO.Series["Average"].Points.Clear();
            chartCO.Series["Minimum"].Points.Clear();
            chartCO.Series["Maximum"].Points.Clear();
            chartCO.Legends["Media"].DockedToChartArea = "ChartAreaCO";
            chartCO.Legends["Media"].IsDockedInsideChartArea = true;
            for (int i = 0; i < 7; i++)
            {
                chartCO.Series["Average"].Points.Add().SetValueXY(valoresCO[i].Date.Day, Math.Round((decimal)valoresCO[i].avg, 2));
                chartCO.Series["Minimum"].Points.Add().SetValueXY(valoresCO[i].Date.Day, Math.Round((decimal)valoresCO[i].min, 2));
                chartCO.Series["Maximum"].Points.Add().SetValueXY(valoresCO[i].Date.Day, Math.Round((decimal)valoresCO[i].max, 2));
            }

            float maximum = 0;
            int index = 0;
            for (int i = 0; i < 7; i++)
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
            for (int i = 0; i < 7; i++)
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
    }
}
