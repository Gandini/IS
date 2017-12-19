using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace AirMonit_DLog
{
    public partial class Form1 : Form
       
    {
        MqttClient m_cClient = new MqttClient("127.0.0.1");
        const String STR_CHANNEL_NAME = "airValues";
        const String STR_CHANNEL_NAME1 = "airAlarm";
        string[] m_strTopicsInfo = { STR_CHANNEL_NAME};
        SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = AirDB; Integrated Security = True");
        

        public Form1()
        {

            InitializeComponent();
            Connect();
            

        }

        private void Connect()
        {
            m_cClient.Connect(Guid.NewGuid().ToString());
            if (!m_cClient.IsConnected)
            {
                Console.WriteLine("Error connecting to message broker...");
                return;
            }
            else
            {
                Console.WriteLine("Succesfully connected to DLog");
                //Subscribe chat channel


                m_cClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

                byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };//QoS
                m_cClient.Subscribe(m_strTopicsInfo, qosLevels);
            }

        }

        void client_MqttMsgPublishReceived(Object sender, MqttMsgPublishEventArgs e)
        {
            //Recebe a mensagem e determina qual o tipo de molecula ao qual a informação corresponde
            String strTemp = Encoding.UTF8.GetString(e.Message);
            string[] arrParts = extractFieldsFromXmlstr(strTemp);
            if (strTemp.Contains("Alarm"))
            {
                Console.WriteLine("\n Insert Alarm \n");
                insertAlarm(arrParts);
            }
            else
            {
                if (arrParts[0].Equals("O3", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n Insert O3 \n");
                    insertO3(arrParts);
                }
                else
                {
                    if (arrParts[0].Equals("NO2", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("\n Insert NO2 \n");
                        insertNO2(arrParts);
                    }
                    else
                    {
                        if (arrParts[0].Equals("CO", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("\n Insert CO \n");
                            insertCO(arrParts);
                        }
                    }

                }
            }

        }

        private void insertAlarm(string[] arrParts)
        {
            // DB Insert into Table Alarm
            string queryString = "INSERT INTO Alarm(molecule, value ,local, , errorMessage) VALUES(@value, @date, @local)";
            SqlCommand cmd = new SqlCommand(queryString, con);

            cmd.Parameters.AddWithValue("@value", arrParts[1]);
            cmd.Parameters.AddWithValue("@date", arrParts[2]);
            cmd.Parameters.AddWithValue("@local", arrParts[3]);
            cmd.Parameters.AddWithValue("@errorMessage", arrParts[4]);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                Console.WriteLine("\nAlarm Insert Success");
            }

        }

        private void insertNO2(string[] arrParts)
        {
            // DB Insert into Table NO2
            string queryString = "INSERT INTO NO2(value, date, local) VALUES(@value, @date, @local)";
            SqlCommand cmd = new SqlCommand(queryString, con);

            cmd.Parameters.AddWithValue("@value", arrParts[1]);
            cmd.Parameters.AddWithValue("@date", arrParts[2]);
            cmd.Parameters.AddWithValue("@local", arrParts[3]);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                Console.WriteLine("\nNO2 Insert Success");
            }

        }

        private void insertCO(string[] arrParts)
        {
            // DB Insert into Table CO
            string queryString = "INSERT INTO CO(value, date, local) VALUES(@value, @date, @local)";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Parameters.AddWithValue("@value", arrParts[1]);
            cmd.Parameters.AddWithValue("@date", arrParts[2]);
            cmd.Parameters.AddWithValue("@local", arrParts[3]);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                Console.WriteLine("\nCO Insert Success");
            }
        }

        private void insertO3(string[] arrParts)
        {
            // DB Insert into Table O3
            string queryString = "INSERT INTO O3(value, date, local) VALUES(@value, @date, @local)";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Parameters.AddWithValue("@value", arrParts[1]);
            cmd.Parameters.AddWithValue("@date", arrParts[2]);
            cmd.Parameters.AddWithValue("@local", arrParts[3]);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                Console.WriteLine("\nO3 Insert Success");
            }
        }


        private string[] extractFieldsFromXmlstr(string strTemp)
        {

            //Separa os valores do XML num array para ser manipulado mais facilmente
            
            String[] messageReceived = new string[4];

            if (strTemp.Contains("Alarm"))
            {
                messageReceived = extractFieldsFromXmlAlarm(strTemp);
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strTemp);

                messageReceived[0] = doc.SelectSingleNode("/Airmessage/molecule").InnerText;
                messageReceived[1] = doc.SelectSingleNode("/Airmessage/value").InnerText;
                messageReceived[2] = doc.SelectSingleNode("/Airmessage/time").InnerText;
                messageReceived[3] = doc.SelectSingleNode("/Airmessage/local").InnerText;
            }



            return messageReceived;
        }

        private string[] extractFieldsFromXmlAlarm(string strTemp)
        {

            //Separa os valores do XML num array para ser manipulado mais facilmente

            String[] messageReceived = new string[5];

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(strTemp);

            messageReceived[0] = doc.SelectSingleNode("/Airmessage/molecule").InnerText;
            messageReceived[1] = doc.SelectSingleNode("/Airmessage/value").InnerText;
            messageReceived[2] = doc.SelectSingleNode("/Airmessage/time").InnerText;
            messageReceived[3] = doc.SelectSingleNode("/Airmessage/local").InnerText;
            messageReceived[4] = doc.SelectSingleNode("/Airmessage/errorMessage").InnerText;



            return messageReceived;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_cClient.IsConnected)
            {
                m_cClient.Unsubscribe(m_strTopicsInfo); //Put this in a button to see notif!
                m_cClient.Disconnect(); //Free process and process's resources
            }
        }

    }
}
