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

        private void listBoxCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCidades.SelectedItem == null) return;
            listBoxAlarms.Items.Clear(); //usar listView ou listBox? Rever qnd houverem dados
            //TODO: popular a lista de alarmes com os dados do serviço

            listViewEvents.Items.Clear(); //usar listView ou listBox? Rever qnd houverem dados
                                          //TODO: popular a lista de eventos com os dados do serviço

            
            chkBoxFilterDate.Enabled = true;
            btn_sensorData.Enabled = true;

            btnStatistics.Enabled = true;
            btnStatistics.Text = "Statistics for " + listBoxCidades.Text;


            //sensores
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




            //alarmes
            /*listBoxAlarms.Items.Clear();
            HttpWebRequest requestAlarms = WebRequest.Create(@"http://localhost:52643/api/" + listBoxCidades.SelectedItem.ToString() + "/alarms") as HttpWebRequest;
            requestAlarms.ContentType = "application/json";
            HttpWebResponse responseAlarms = requestAlarms.GetResponse() as HttpWebResponse;
            string jsonAlarms = new StreamReader(responseAlarms.GetResponseStream()).ReadToEnd();
            List<Alarm> valoresAlarms = JsonConvert.DeserializeObject<List<Alarm>>(jsonAlarms);

            for (int i = 0; i < valoresAlarms.Count; i++)
            {
                listBoxAlarms.Items.Add("Molecule: " + valoresAlarms[i].molecule + "  Value: " + valoresAlarms[i].value + " Error Message: " + valoresAlarms[i].errorMessage);
            }*/

            chkBoxFilterDate.Checked = false;

        }

        private void btn_sensorData_Click(object sender, EventArgs e)
        {
            //   [Route("api/{local}/NO2/{date}")]
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
