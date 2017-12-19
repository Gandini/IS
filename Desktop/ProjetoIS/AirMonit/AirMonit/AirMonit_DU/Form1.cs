using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace AirMonit_DU
{
    public partial class Form1 : Form
    {
        AirSensorNodeDll.AirSensorNodeDll dll = new AirSensorNodeDll.AirSensorNodeDll();
        const String STR_CHANNEL_NAME = "airValues";
        string ipAddressDefLocal = "127.0.0.1";
        MqttClient m_cClient;
        string[] m_strTopicsInfo = { STR_CHANNEL_NAME };
        string[] values = new string[3];

        public Form1()
        {
            Connect();
            dll.Initialize(dllStarted, 1000);

        }

        private void Connect()
        {
            m_cClient = new MqttClient(ipAddressDefLocal);
            m_cClient.Connect(Guid.NewGuid().ToString());
            if (!m_cClient.IsConnected)
            {
                Console.WriteLine("Error connecting to message broker...");
                return;
            }
            Console.WriteLine("Sending connection");

            //Subscribe chat channel

            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };//QoS
            m_cClient.Subscribe(m_strTopicsInfo, qosLevels);
            
        }

        private void regexValidation(string text)
        {

            // VALUES [0 = id, 1 = nome da molecula, 2 = Valor da medida, 3 = data, 4 = Local]
            values = Regex.Split(text, @"\;");

        }

        private void sendData()
        {
            //Prepara string para ser lançada no Communication Channel

            string strMsgtoSend = buildXmlMessage(values[1], values[2], values[3], values[4]);

            //Send
            m_cClient.Publish(STR_CHANNEL_NAME, Encoding.UTF8.GetBytes(strMsgtoSend));
            resetValues();
        }

        private string buildXmlMessage(string t_molecule, string t_value, string t_time, string t_local)
        {
            //Estrutura da string XML
            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateElement("Airmessage");

            XmlNode mol = doc.CreateElement("molecule");
            mol.InnerText = t_molecule;
            root.AppendChild(mol);

            XmlNode value = doc.CreateElement("value");
            value.InnerText = t_value;
            root.AppendChild(value);

            XmlNode time = doc.CreateElement("time");
            time.InnerText = t_time;
            root.AppendChild(time);

            XmlNode location = doc.CreateElement("local");
            location.InnerText = t_local;
            root.AppendChild(location);

            doc.AppendChild(root);

            return doc.OuterXml;
        }

        public void resetValues()
        {
            //Elimina Valores que já foram transmitidos na Communication Channel
            values[0] = null;
            values[1] = null;
            values[2] = null;
            values[3] = null;
        }


        public void dllStarted(string str)
        {
            regexValidation(str);
            sendData();
        }

    }


}
