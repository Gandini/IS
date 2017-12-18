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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Statistics statisticsForm = new Statistics();
            statisticsForm.ShowDialog();
        }

        private void chkBoxFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            listBoxAlarms.Items.Clear();

            if (chkBoxFilterDate.Checked == true) //filtro por data ativo
            {
                HttpWebRequest requestAlarms = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/alarms/" + dtp_startDate.ToString() + "/" + dtp_endDate.ToString()) as HttpWebRequest;
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

        private void listBoxCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBoxCidades.Items.Clear();
            //TODO: popular a lista de cidades com os dados do serviço

            listBoxAlarms.Items.Clear(); //usar listView ou listBox? Rever qnd houverem dados
            //TODO: popular a lista de alarmes com os dados do serviço

            listViewEvents.Items.Clear(); //usar listView ou listBox? Rever qnd houverem dados
                                          //TODO: popular a lista de eventos com os dados do serviço

            btnStatistics.Enabled = true;
            btnStatistics.Text = "Statistics for " + listBoxCidades.Text;


            //sensores
            HttpWebRequest requestSensors = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/sensors") as HttpWebRequest;
            requestSensors.ContentType = "application/json";
            HttpWebResponse responseSensors = requestSensors.GetResponse() as HttpWebResponse;
            string jsonSensors = new StreamReader(responseSensors.GetResponseStream()).ReadToEnd();
            List<SensorValue> valoresSensors = JsonConvert.DeserializeObject<List<SensorValue>>(jsonSensors);

            for (int i = 0; i < valoresSensors.Count; i++)
            {
                listBoxSensors.Items.Add("City: " + valoresSensors[i].local + "  Value: " + valoresSensors[i].value + " Date: " + valoresSensors[i].date);
            }

            //alarmes
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

        private void btn_sensorData_Click(object sender, EventArgs e)
        {
            //  [Route("api/O3/date/{date}/local/{local}")]
            DateTime date = dtp_sensorData.Value; //valor correto?
            HttpWebRequest request = WebRequest.Create(@"http://localhost:52643/api/city/" + listBoxCidades.SelectedItem.ToString() + "/" + date) as HttpWebRequest;
            request.ContentType = "application/json";
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
            List<Alarm> lista = JsonConvert.DeserializeObject<List<Alarm>>(json);


            for (int i = 0; i < lista.Count; i++)
            {
                listBoxSensors.Items.Add("Name: " + lista[i].molecule + "  Value: " + lista[i].value + " Date: " + lista[i].errorMessage);
            }
        }
    }


      //codigo dos sensores individuais
      /*
            HttpWebRequest requestO3 = WebRequest.Create(@"http://localhost:52643/api/o3") as HttpWebRequest;
            requestO3.ContentType = "application/json";
            HttpWebResponse responseO3 = requestO3.GetResponse() as HttpWebResponse;
            string jsonO3 = new StreamReader(responseO3.GetResponseStream()).ReadToEnd();
            List<O3> listaO3 = JsonConvert.DeserializeObject<List<O3>>(jsonO3);


            for (int i = 0; i<listaO3.Count; i++)
            {
                lbx_sensors.Items.Add("Name: " + listaO3[i].local + "  Value: " + listaO3[i].value + " Date: " + listaO3[i].date);
            }

            HttpWebRequest requestCO = WebRequest.Create(@"http://localhost:52643/api/co") as HttpWebRequest;
            requestCO.ContentType = "application/json";
            HttpWebResponse responseCO = requestCO.GetResponse() as HttpWebResponse;
            string jsonCO = new StreamReader(responseCO.GetResponseStream()).ReadToEnd();
            List<CO> listaCO = JsonConvert.DeserializeObject<List<CO>>(jsonCO);


            for (int i = 0; i<listaCO.Count; i++)
            {
                lbx_sensors.Items.Add("Name: " + listaCO[i].local + "  Value: " + listaCO[i].value + " Date: " + listaCO[i].date);
            }

            HttpWebRequest requestNO = WebRequest.Create(@"http://localhost:52643/api/no") as HttpWebRequest;
            requestNO.ContentType = "application/json";
            HttpWebResponse response = requestNO.GetResponse() as HttpWebResponse;
            string jsonNO = new StreamReader(response.GetResponseStream()).ReadToEnd();
            List<NO> listaNO = JsonConvert.DeserializeObject<List<NO>>(jsonNO);


            for (int i = 0; i<listaNO.Count; i++)
            {
                lbx_sensors.Items.Add("Local: " + listaNO[i].local + "  Value: " + listaNO[i].value + " Date: " + listaNO[i].date);
            }
      */
}
