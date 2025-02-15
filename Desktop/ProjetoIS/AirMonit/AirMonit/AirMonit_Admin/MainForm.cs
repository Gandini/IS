﻿using AirMonit_Service.Models;
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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
<<<<<<< HEAD
        { 
=======
        {
          //  updateEvents();
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm(listBoxCidades.SelectedItem.ToString());
            statisticsForm.ShowDialog();
        }

        private void listBoxCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCidades.SelectedItem == null) return;

            listBoxAlarms.Items.Clear(); //usar listView ou listBox? Rever qnd houverem dados
            //TODO: popular a lista de alarmes com os dados do serviço

            listBoxEvents.Items.Clear(); //usar listView ou listBox? Rever qnd houverem dados
                                          //TODO: popular a lista de eventos com os dados do serviço


            chkBoxFilterDate.Enabled = true;
            checkBoxSensorsFilterDate.Enabled = true;
<<<<<<< HEAD
=======
            dtp_sensorData.Enabled = true;
            chkBoxFilterDate.Enabled = true;
            dtp_startDate.Enabled = true;
            dtp_endDate.Enabled = true;
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27

            btnStatistics.Enabled = true;
            btnStatistics.Text = "Statistics for " + listBoxCidades.Text;


            //sensores
<<<<<<< HEAD
            listBoxCO.Items.Clear();
            HttpWebRequest requestCO = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/CO") as HttpWebRequest;
            requestCO.ContentType = "application/json";
            HttpWebResponse responseCO = requestCO.GetResponse() as HttpWebResponse;
            string jsonCO = new StreamReader(responseCO.GetResponseStream()).ReadToEnd();
            List<CO> valoresCO = JsonConvert.DeserializeObject<List<CO>>(jsonCO);

            for (int i = 0; i < valoresCO.Count; i++)
            {
                listBoxCO.Items.Add("City: " + valoresCO[i].local + "  Value: " + valoresCO[i].value + " Date: " + valoresCO[i].date);
            }

            listBoxNO2.Items.Clear();
            HttpWebRequest requestNO2 = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/NO") as HttpWebRequest;
            requestNO2.ContentType = "application/json";
            HttpWebResponse responseNO2 = requestNO2.GetResponse() as HttpWebResponse;
            string jsonNO2 = new StreamReader(responseNO2.GetResponseStream()).ReadToEnd();
            List<NO> valoresNO2 = JsonConvert.DeserializeObject<List<NO>>(jsonNO2);

            for (int i = 0; i < valoresNO2.Count; i++)
            {
                listBoxNO2.Items.Add("City: " + valoresNO2[i].local + "  Value: " + valoresNO2[i].value + " Date: " + valoresNO2[i].date);
            }

            listBoxO3.Items.Clear();
            HttpWebRequest requestO3 = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/O3") as HttpWebRequest;
            requestO3.ContentType = "application/json";
            HttpWebResponse responseO3 = requestO3.GetResponse() as HttpWebResponse;
            string jsonO3 = new StreamReader(responseO3.GetResponseStream()).ReadToEnd();
            List<O3> valoresO3 = JsonConvert.DeserializeObject<List<O3>>(jsonO3);

            for (int i = 0; i < valoresO3.Count; i++)
            {
                listBoxO3.Items.Add("City: " + valoresO3[i].local + "  Value: " + valoresO3[i].value + " Date: " + valoresO3[i].date);
            }


=======
            getSensors();
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27


            //alarmes
            listBoxAlarms.Items.Clear();
            HttpWebRequest requestAlarms = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/alarms") as HttpWebRequest;
            requestAlarms.ContentType = "application/json";
            HttpWebResponse responseAlarms = requestAlarms.GetResponse() as HttpWebResponse;
            string jsonAlarms = new StreamReader(responseAlarms.GetResponseStream()).ReadToEnd();
            List<Alarm> valoresAlarms = JsonConvert.DeserializeObject<List<Alarm>>(jsonAlarms);

            for (int i = 0; i < valoresAlarms.Count; i++)
            {
                listBoxAlarms.Items.Add("Molecule: " + valoresAlarms[i].molecule + "  Value: " + valoresAlarms[i].value + " Error Message: " + valoresAlarms[i].errorMessage);
            }

            chkBoxFilterDate.Checked = false;

        }

        private void chkBoxFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            listBoxAlarms.Items.Clear();

            if (chkBoxFilterDate.Checked == true) //filtro por data ativo
            {
                HttpWebRequest requestAlarms = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/alarms/" + dtp_startDate.Value.ToShortDateString().Replace("/", "-") + "/" + dtp_endDate.Value.ToShortDateString().Replace("/", "-")) as HttpWebRequest;
                requestAlarms.ContentType = "application/json";
                HttpWebResponse responseAlarms = requestAlarms.GetResponse() as HttpWebResponse;
                string jsonAlarms = new StreamReader(responseAlarms.GetResponseStream()).ReadToEnd();
                List<Alarm> valoresAlarms = JsonConvert.DeserializeObject<List<Alarm>>(jsonAlarms);
                for (int i = 0; i < valoresAlarms.Count; i++)
                {
                    listBoxAlarms.Items.Add("Molecule: " + valoresAlarms[i].molecule + "  Value: " + valoresAlarms[i].value + " Error Message: " + valoresAlarms[i].errorMessage);
                }
            }
            else
            {
                HttpWebRequest requestAlarms = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/alarms") as HttpWebRequest;
                requestAlarms.ContentType = "application/json";
                HttpWebResponse responseAlarms = requestAlarms.GetResponse() as HttpWebResponse;
                string jsonAlarms = new StreamReader(responseAlarms.GetResponseStream()).ReadToEnd();
                List<Alarm> valoresAlarms = JsonConvert.DeserializeObject<List<Alarm>>(jsonAlarms);

                for (int i = 0; i < valoresAlarms.Count; i++)
                {
                    listBoxAlarms.Items.Add("Molecule: " + valoresAlarms[i].molecule + "  Value: " + valoresAlarms[i].value + " Error Message: " + valoresAlarms[i].errorMessage);
                }
            }
        }

        private void btn_sensorData_Click(object sender, EventArgs e)
        {
            //   [Route("api/{local}/NO2/{date}")]
            

        }

        private void checkBoxSensorsFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSensorsFilterDate.Checked)
            {
                getSensorsByDate();
            }
            else
            {
                getSensors();
            }

            
        }

       

        private void dtp_sensorData_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxSensorsFilterDate.Checked)
            {
                getSensorsByDate();
            }
        }

        private void getSensors()
        {
            listBoxCO.Items.Clear();
            HttpWebRequest requestCO = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/CO") as HttpWebRequest;
            requestCO.ContentType = "application/json";
            HttpWebResponse responseCO = requestCO.GetResponse() as HttpWebResponse;
            string jsonCO = new StreamReader(responseCO.GetResponseStream()).ReadToEnd();
            List<CO> valoresCO = JsonConvert.DeserializeObject<List<CO>>(jsonCO);
            for (int i = 0; i < valoresCO.Count; i++)
            {
                listBoxCO.Items.Add("City: " + valoresCO[i].local + "  Value: " + valoresCO[i].value + " Date: " + valoresCO[i].date);
            }

            listBoxNO2.Items.Clear();
<<<<<<< HEAD
            HttpWebRequest requestNO2 = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/NO") as HttpWebRequest;
=======
            HttpWebRequest requestNO2 = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/NO2") as HttpWebRequest;
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            requestNO2.ContentType = "application/json";
            HttpWebResponse responseNO2 = requestNO2.GetResponse() as HttpWebResponse;
            string jsonNO2 = new StreamReader(responseNO2.GetResponseStream()).ReadToEnd();
            List<NO> valoresNO2 = JsonConvert.DeserializeObject<List<NO>>(jsonNO2);
            for (int i = 0; i < valoresNO2.Count; i++)
            {
                listBoxNO2.Items.Add("City: " + valoresNO2[i].local + "  Value: " + valoresNO2[i].value + " Date: " + valoresNO2[i].date);
            }

            listBoxO3.Items.Clear();
            HttpWebRequest requestO3 = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/O3") as HttpWebRequest;
            requestO3.ContentType = "application/json";
            HttpWebResponse responseO3 = requestO3.GetResponse() as HttpWebResponse;
            string jsonO3 = new StreamReader(responseO3.GetResponseStream()).ReadToEnd();
            List<O3> valoresO3 = JsonConvert.DeserializeObject<List<O3>>(jsonO3);
            for (int i = 0; i < valoresO3.Count; i++)
            {
                listBoxO3.Items.Add("City: " + valoresO3[i].local + "  Value: " + valoresO3[i].value + " Date: " + valoresO3[i].date);
            }
        }

        private void getSensorsByDate()
        {
            listBoxCO.Items.Clear();
            HttpWebRequest requestCO = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/CO/" + dtp_sensorData.Value.ToShortDateString().Replace("/", "-")) as HttpWebRequest;
            requestCO.ContentType = "application/json";
            HttpWebResponse responseCO = requestCO.GetResponse() as HttpWebResponse;
            string jsonCO = new StreamReader(responseCO.GetResponseStream()).ReadToEnd();
            List<CO> valoresCO = JsonConvert.DeserializeObject<List<CO>>(jsonCO);
            for (int i = 0; i < valoresCO.Count; i++)
            {
                listBoxCO.Items.Add("City: " + valoresCO[i].local + "  Value: " + valoresCO[i].value + " Date: " + valoresCO[i].date);
            }

            listBoxNO2.Items.Clear();
            HttpWebRequest requestNO2 = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/NO2/" + dtp_sensorData.Value.ToShortDateString().Replace("/", "-")) as HttpWebRequest;
            requestNO2.ContentType = "application/json";
            HttpWebResponse responseNO2 = requestNO2.GetResponse() as HttpWebResponse;
            string jsonNO2 = new StreamReader(responseNO2.GetResponseStream()).ReadToEnd();
            List<NO> valoresNO2 = JsonConvert.DeserializeObject<List<NO>>(jsonNO2);
            for (int i = 0; i < valoresNO2.Count; i++)
            {
                listBoxNO2.Items.Add("City: " + valoresNO2[i].local + "  Value: " + valoresNO2[i].value + " Date: " + valoresNO2[i].date);
            }

            listBoxO3.Items.Clear();
            HttpWebRequest requestO3 = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/O3/" + dtp_sensorData.Value.ToShortDateString().Replace("/", "-")) as HttpWebRequest;
            requestO3.ContentType = "application/json";
            HttpWebResponse responseO3 = requestO3.GetResponse() as HttpWebResponse;
            string jsonO3 = new StreamReader(responseO3.GetResponseStream()).ReadToEnd();
            List<O3> valoresO3 = JsonConvert.DeserializeObject<List<O3>>(jsonO3);
            for (int i = 0; i < valoresO3.Count; i++)
            {
                listBoxO3.Items.Add("City: " + valoresO3[i].local + "  Value: " + valoresO3[i].value + " Date: " + valoresO3[i].date);
            }
<<<<<<< HEAD
=======
        }

        private void updateEvents()
        {
            listBoxEvents.Items.Clear();
            HttpWebRequest requestEvents = WebRequest.Create(@"http://localhost:52643/api/Event") as HttpWebRequest;
            requestEvents.ContentType = "application/json";
            HttpWebResponse responseEvents = requestEvents.GetResponse() as HttpWebResponse;
            string jsonEvents = new StreamReader(responseEvents.GetResponseStream()).ReadToEnd();
            List<O3> valoresEvents = JsonConvert.DeserializeObject<List<O3>>(jsonEvents);
            for (int i = 0; i < valoresEvents.Count; i++)
            {
                listBoxEvents.Items.Add("City: " + valoresEvents[i].local + "  Value: " + valoresEvents[i].value + " Date: " + valoresEvents[i].date);
            }
        }

        private void btnUpdateEvents_Click(object sender, EventArgs e)
        {
            updateEvents();
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
        }
    }
}
