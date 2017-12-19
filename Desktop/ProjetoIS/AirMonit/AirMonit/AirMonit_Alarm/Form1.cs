using AirSensorNodeDll;
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
using System.Xml.Linq;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace AirMonit_Alarm
{
    public partial class Form1 : Form
    {
        AirSensorNodeDll.AirSensorNodeDll dll = new AirSensorNodeDll.AirSensorNodeDll();
        MqttClient m_cClient = new MqttClient("127.0.0.1");

        const String STR_CHANNEL_NAME = "airValues";
        string[] m_strTopicsInfo = { STR_CHANNEL_NAME };

<<<<<<< HEAD
=======
        const String STR_CHANNEL_NAME1 = "airAlarm";

>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
        bool trigger = false;

        public Form1()
        {
            InitializeComponent();
            Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            if (m_cClient.IsConnected)
            {
                m_cClient.Unsubscribe(m_strTopicsInfo);
                m_cClient.Disconnect();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listaCondicoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCondicao.Text = listaCondicoes.SelectedValue.ToString();
        }

        private void getConditions_Click(object sender, EventArgs e)
        {           
            listaCondicoes.DataSource= GetConditions();         
        }

        private List<String> GetConditions()
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(@"trigger-rules.xml");

            List<String> lista = new List<string>();

            XmlNodeList condicoes = doc.SelectNodes("/conditions/condition/id");

            foreach (XmlNode item in condicoes)
            {
                /*string elemento = "->";
                elemento += "estado: " + item["state"].InnerText + ". ";
                elemento += "molecula: " + item["molecule"].InnerText + ". ";
                elemento += "operador: " + item["operador"].InnerText + ". ";
                elemento += item["value1"].InnerText;
                elemento += item["value2"].InnerText;
                elemento += item["message"].InnerText;
                lista.Add(elemento);*/

                lista.Add(item.InnerText);
            }

            return lista;           
        }

        private void editCondition_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(@"trigger-rules.xml");

            string condicaoSelecionada = labelCondicao.Text;
            
            XmlNode state = doc.SelectSingleNode("/conditions/condition[id='" + condicaoSelecionada + "']/state");
            if (radioButton1.Checked) {
                state.InnerText = "ativado";
            } else if (radioButton2.Checked)
            {
                state.InnerText = "desativado";
            } else
            {
                MessageBox.Show("State nao alterado");
            }

            XmlNode molecule = doc.SelectSingleNode("/conditions/condition[id='" + condicaoSelecionada + "']/molecule");
            if (radioButton3.Checked)
            {
                molecule.InnerText = "NO2";
            } else if (radioButton4.Checked)
            {
                molecule.InnerText = "CO";
            } else if (radioButton5.Checked)
            {
                molecule.InnerText = "O3";
            } else
            {
                MessageBox.Show("Molecule nao alterado");
            }

            XmlNode operador = doc.SelectSingleNode("/conditions/condition[id='" + condicaoSelecionada + "']/operador");
            if (radioButton6.Checked)
            {
                operador.InnerText = "equal";
            } else if (radioButton7.Checked)
            {
                operador.InnerText = "bigger";
            } else if (radioButton8.Checked)
            {
                operador.InnerText = "smaller";
            } else if (radioButton9.Checked)
            {
                operador.InnerText = "between";
            } else
            {
                MessageBox.Show("Operador nao alterado");
            }

            string txtvalue1 = textBox1.Text;
            XmlNode value1 = doc.SelectSingleNode("/conditions/condition[id='" + condicaoSelecionada + "']/value1");
            value1.InnerText = txtvalue1;

            string txtvalue2 = textBox2.Text;
            XmlNode value2 = doc.SelectSingleNode("/conditions/condition[id='" + condicaoSelecionada + "']/value2");
            value2.InnerText = txtvalue2;

            string txtmessage = textBox3.Text;
            XmlNode message = doc.SelectSingleNode("/conditions/condition[id='" + condicaoSelecionada + "']/message");
            message.InnerText = txtmessage;

            MessageBox.Show("Condicao alterada!");
            doc.Save(@"trigger-rules.xml");

        }

        private void labelCondicao_Click(object sender, EventArgs e)
<<<<<<< HEAD
        {

        }

        private void activate_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"trigger-rules.xml");

            string condicaoSelecionada = labelCondicao.Text;

            XmlNode state = doc.SelectSingleNode("/conditions/condition[id='" + condicaoSelecionada + "']/state");

            if (state.InnerText == "ativado")
            {
                state.InnerText = "desativado";
                MessageBox.Show("Condicao desativada");
            } else if (state.InnerText == "desativado")
            {
                state.InnerText = "ativado";
                MessageBox.Show("Condicao ativada");
            } else
            {
                MessageBox.Show("Estado da condicao nao reconhecido! Impossivel mudar!");
            }
            

            doc.Save(@"trigger-rules.xml");
        }

        private void addCondition_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(@"trigger-rules.xml");

            XmlElement rootConditions = doc.DocumentElement;

            XmlElement newCondition = doc.CreateElement("condition");

            XmlElement newId = doc.CreateElement("id");
            newId.InnerText = "100";

            XmlElement newState = doc.CreateElement("state");
            if (radioButton1.Checked)
            {
                newState.InnerText = "ativado";
            }
            else if (radioButton2.Checked)
            {
                newState.InnerText = "desativado";
            }
            else
            {
                MessageBox.Show("State nao inserido");
            }

            XmlElement newMolecule = doc.CreateElement("molecule");
            if(radioButton3.Checked)
            {
                newMolecule.InnerText = "NO2";
            } else if (radioButton4.Checked)
            {
                newMolecule.InnerText = "CO";
            }
            else if (radioButton5.Checked)
            {
                newMolecule.InnerText = "O3";
            }
            else
            {
                MessageBox.Show("Molecule nao inserido");
            }

            XmlElement newOperador = doc.CreateElement("operador");
            if (radioButton6.Checked)
            {
                newOperador.InnerText = "equal";
            }
            else if (radioButton7.Checked)
            {
                newOperador.InnerText = "bigger";
            }
            else if (radioButton8.Checked)
            {
                newOperador.InnerText = "smaller";
            }
            else if (radioButton9.Checked)
            {
                newOperador.InnerText = "between";
            }
            else
            {
                MessageBox.Show("Operador nao inserido");
            }

            string txtvalue1 = textBox1.Text;
            XmlElement newValue1 = doc.CreateElement("value1");
            newValue1.InnerText = txtvalue1;

            string txtvalue2 = textBox2.Text;
            XmlElement newValue2 = doc.CreateElement("value2");
            newValue2.InnerText = txtvalue2;

            string txtmessage = textBox3.Text;
            XmlElement newMessage = doc.CreateElement("message");
            newMessage.InnerText = txtmessage;
            
            newCondition.AppendChild(newState);
            newCondition.AppendChild(newMolecule);
            newCondition.AppendChild(newOperador);
            newCondition.AppendChild(newValue1);
            newCondition.AppendChild(newValue2);
            newCondition.AppendChild(newMessage);

            XmlNode newConditions = rootConditions.FirstChild;

            rootConditions.AppendChild(newCondition);

            MessageBox.Show("Condicao adicionada!");
            doc.Save(@"trigger-rules.xml");
        }

        private void delCondition_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(@"trigger-rules.xml");

            string condicaoAEliminar = labelCondicao.Text;

            XmlNode root = doc.DocumentElement;

            XmlNode nodeAEliminar = doc.SelectSingleNode("/conditions/condition[id='" + condicaoAEliminar + "']");

            XmlNode node = doc.SelectSingleNode("/conditions/condition[id='" + condicaoAEliminar + "']");

            foreach (XmlNode child in node.ChildNodes)
            {
                node.ParentNode.AppendChild(child);
            }
            node.ParentNode.RemoveChild(node);

            MessageBox.Show("Condicao eliminada!");            
            doc.Save(@"trigger-rules.xml");
        }

        private void buttonLigar_Click(object sender, EventArgs e)
        {
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
            String strTemp = Encoding.UTF8.GetString(e.Message);

            if (!strTemp.Contains("Alarm"))
            {
                string[] arrParts = extractFieldsFromXmlstr(strTemp);

                this.Invoke((MethodInvoker)delegate
                {
                    richTextBoxDadosSensor.AppendText("-> Molecule: " + arrParts[0] + " - Valor: " + arrParts[1] + " - Data e Hora: " + arrParts[2] + " - Localização: " + arrParts[3] + Environment.NewLine);
                });

                //Converter a string to XML
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(Encoding.UTF8.GetString(e.Message));

                //Obter Mensagem
                string molecule = doc.SelectSingleNode("/Airmessage/molecule").InnerText;

                XmlDocument xml_trigger = new XmlDocument();
                xml_trigger.Load(@"trigger-rules.xml");

                XmlNodeList lista = xml_trigger.SelectNodes("/conditions/condition[molecule='" + molecule + "' and state='ativado']");
                ///conditions/condition[molecule='O3' and state='ativado']/operador
                switch (molecule)
                {
                    case "O3":
                        validateMolecule(lista, molecule, arrParts);                        
                        break;
                    case "NO2":
                        validateMolecule(lista, molecule, arrParts);
                        break;
                    case "CO":
                        validateMolecule(lista, molecule, arrParts);
                        break;
                    default:
                        break;
                }
            }           
        }

        private void validateMolecule(XmlNodeList lista, String molecule, string[] arrParts)
        {
            foreach (XmlNode item in lista)
            {
                if (item["operador"].InnerText == "equal")
                {
                    MessageBox.Show(arrParts[6]);
                    if (item["value1"].InnerText == arrParts[1])
                    {
                        trigger = true;
                        arrParts[4] = "Alarm: " + molecule + " é igual a " + item["value1"].InnerText + "! Message: " + item["message"].InnerText + "\n";
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxAlarmes.AppendText("Alarm: " + molecule + " igual a " + item["value1"].InnerText + " -> Message: " + item["message"].InnerText + Environment.NewLine);
                        });
                        sendData(molecule, arrParts[1], arrParts[2], arrParts[3], arrParts[4]);
                    }
                }
                else if (item["operador"].InnerText == "bigger")
                {
                    if (Int32.Parse(arrParts[1]) > Int32.Parse(item["value1"].InnerText))
                    {
                        trigger = true;
                        arrParts[4] = "Alarm: " + molecule + " é maior que " + item["value1"].InnerText + "! Message: " + item["message"].InnerText + "\n";
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxAlarmes.AppendText("Alarm: " + molecule + " maior que " + item["value1"].InnerText + " -> Message: " + item["message"].InnerText + Environment.NewLine);
                        });
                        sendData(molecule, arrParts[1], arrParts[2], arrParts[3], arrParts[4]);
                    }
                }
                else if (item["operador"].InnerText == "smaller")
                {
                    if (Int32.Parse(arrParts[1]) < Int32.Parse(item["value1"].InnerText))
                    {
                        trigger = true;
                        arrParts[4] = "Alarm: " + molecule + " é menor que " + item["value1"].InnerText + "! Message: " + item["message"].InnerText + "\n";
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxAlarmes.AppendText("Alarm: " + molecule + " menor que " + item["value1"].InnerText + " -> Message: " + item["message"].InnerText + Environment.NewLine);
                        });
                        sendData(molecule, arrParts[1], arrParts[2], arrParts[3], arrParts[4]);
                    }
                }
                else if (item["operador"].InnerText == "between")
                {
                    if (Int32.Parse(arrParts[1]) > Int32.Parse(item["value1"].InnerText) && Int32.Parse(arrParts[1]) < Int32.Parse(item["value2"].InnerText))
                    {
                        trigger = true;
                        arrParts[4] = "Alarm: " + molecule + " está entre " + item["value1"].InnerText + " e " + item["value2"].InnerText + "! Message: " + item["message"].InnerText + "\n";
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxAlarmes.AppendText("Alarm: " + molecule + " entre " + item["value1"].InnerText + " e " + item["value2"].InnerText + " -> Message: " + item["message"].InnerText + Environment.NewLine);
                        });
                        sendData(molecule, arrParts[1], arrParts[2], arrParts[3], arrParts[4]);
                    }
                }
            }
        }

=======
        {

        }

        private void activate_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"trigger-rules.xml");

            string condicaoSelecionada = labelCondicao.Text;

            XmlNode state = doc.SelectSingleNode("/conditions/condition[id='" + condicaoSelecionada + "']/state");

            if (state.InnerText == "ativado")
            {
                state.InnerText = "desativado";
                MessageBox.Show("Condicao desativada");
            } else if (state.InnerText == "desativado")
            {
                state.InnerText = "ativado";
                MessageBox.Show("Condicao ativada");
            } else
            {
                MessageBox.Show("Estado da condicao nao reconhecido! Impossivel mudar!");
            }
            

            doc.Save(@"trigger-rules.xml");
        }

        private void addCondition_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(@"trigger-rules.xml");

            XmlElement rootConditions = doc.DocumentElement;

            XmlElement newCondition = doc.CreateElement("condition");

            XmlElement newId = doc.CreateElement("id");
            newId.InnerText = "100";

            XmlElement newState = doc.CreateElement("state");
            if (radioButton1.Checked)
            {
                newState.InnerText = "ativado";
            }
            else if (radioButton2.Checked)
            {
                newState.InnerText = "desativado";
            }
            else
            {
                MessageBox.Show("State nao inserido");
            }

            XmlElement newMolecule = doc.CreateElement("molecule");
            if(radioButton3.Checked)
            {
                newMolecule.InnerText = "NO2";
            } else if (radioButton4.Checked)
            {
                newMolecule.InnerText = "CO";
            }
            else if (radioButton5.Checked)
            {
                newMolecule.InnerText = "O3";
            }
            else
            {
                MessageBox.Show("Molecule nao inserido");
            }

            XmlElement newOperador = doc.CreateElement("operador");
            if (radioButton6.Checked)
            {
                newOperador.InnerText = "equal";
            }
            else if (radioButton7.Checked)
            {
                newOperador.InnerText = "bigger";
            }
            else if (radioButton8.Checked)
            {
                newOperador.InnerText = "smaller";
            }
            else if (radioButton9.Checked)
            {
                newOperador.InnerText = "between";
            }
            else
            {
                MessageBox.Show("Operador nao inserido");
            }

            string txtvalue1 = textBox1.Text;
            XmlElement newValue1 = doc.CreateElement("value1");
            newValue1.InnerText = txtvalue1;

            string txtvalue2 = textBox2.Text;
            XmlElement newValue2 = doc.CreateElement("value2");
            newValue2.InnerText = txtvalue2;

            string txtmessage = textBox3.Text;
            XmlElement newMessage = doc.CreateElement("message");
            newMessage.InnerText = txtmessage;
            
            newCondition.AppendChild(newState);
            newCondition.AppendChild(newMolecule);
            newCondition.AppendChild(newOperador);
            newCondition.AppendChild(newValue1);
            newCondition.AppendChild(newValue2);
            newCondition.AppendChild(newMessage);

            XmlNode newConditions = rootConditions.FirstChild;

            rootConditions.AppendChild(newCondition);

            MessageBox.Show("Condicao adicionada!");
            doc.Save(@"trigger-rules.xml");
        }

        private void delCondition_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(@"trigger-rules.xml");

            string condicaoAEliminar = labelCondicao.Text;

            XmlNode root = doc.DocumentElement;

            XmlNode nodeAEliminar = doc.SelectSingleNode("/conditions/condition[id='" + condicaoAEliminar + "']");

            XmlNode node = doc.SelectSingleNode("/conditions/condition[id='" + condicaoAEliminar + "']");

            foreach (XmlNode child in node.ChildNodes)
            {
                node.ParentNode.AppendChild(child);
            }
            node.ParentNode.RemoveChild(node);

            MessageBox.Show("Condicao eliminada!");            
            doc.Save(@"trigger-rules.xml");
        }

        private void buttonLigar_Click(object sender, EventArgs e)
        {
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
            String strTemp = Encoding.UTF8.GetString(e.Message);

            if (!strTemp.Contains("Alarm"))
            {
                string[] arrParts = extractFieldsFromXmlstr(strTemp);

                this.Invoke((MethodInvoker)delegate
                {
                    richTextBoxDadosSensor.AppendText("-> Molecule: " + arrParts[0] + " - Valor: " + arrParts[1] + " - Data e Hora: " + arrParts[2] + " - Localização: " + arrParts[3] + Environment.NewLine);
                });

                //Converter a string to XML
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(Encoding.UTF8.GetString(e.Message));

                //Obter Mensagem
                string molecule = doc.SelectSingleNode("/Airmessage/molecule").InnerText;

                XmlDocument xml_trigger = new XmlDocument();
                xml_trigger.Load(@"trigger-rules.xml");

                XmlNodeList lista = xml_trigger.SelectNodes("/conditions/condition[molecule='" + molecule + "' and state='ativado']");
                ///conditions/condition[molecule='O3' and state='ativado']/operador
                switch (molecule)
                {
                    case "O3":
                        validateMolecule(lista, molecule, arrParts);                        
                        break;
                    case "NO2":
                        validateMolecule(lista, molecule, arrParts);
                        break;
                    case "CO":
                        validateMolecule(lista, molecule, arrParts);
                        break;
                    default:
                        break;
                }
            }           
        }

        private void validateMolecule(XmlNodeList lista, String molecule, string[] arrParts)
        {
            foreach (XmlNode item in lista)
            {
                if (item["operador"].InnerText == "equal")
                {
                    MessageBox.Show(arrParts[6]);
                    if (item["value1"].InnerText == arrParts[1])
                    {
                        trigger = true;
                        arrParts[4] = "Alarm: " + molecule + " é igual a " + item["value1"].InnerText + "! Message: " + item["message"].InnerText + "\n";
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxAlarmes.AppendText("Alarm: " + molecule + " igual a " + item["value1"].InnerText + " -> Message: " + item["message"].InnerText + Environment.NewLine);
                        });
                        sendData(molecule, arrParts[1], arrParts[2], arrParts[3], arrParts[4]);
                    }
                }
                else if (item["operador"].InnerText == "bigger")
                {
                    if (Int32.Parse(arrParts[1]) > Int32.Parse(item["value1"].InnerText))
                    {
                        trigger = true;
                        arrParts[4] = "Alarm: " + molecule + " é maior que " + item["value1"].InnerText + "! Message: " + item["message"].InnerText + "\n";
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxAlarmes.AppendText("Alarm: " + molecule + " maior que " + item["value1"].InnerText + " -> Message: " + item["message"].InnerText + Environment.NewLine);
                        });
                        sendData(molecule, arrParts[1], arrParts[2], arrParts[3], arrParts[4]);
                    }
                }
                else if (item["operador"].InnerText == "smaller")
                {
                    if (Int32.Parse(arrParts[1]) < Int32.Parse(item["value1"].InnerText))
                    {
                        trigger = true;
                        arrParts[4] = "Alarm: " + molecule + " é menor que " + item["value1"].InnerText + "! Message: " + item["message"].InnerText + "\n";
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxAlarmes.AppendText("Alarm: " + molecule + " menor que " + item["value1"].InnerText + " -> Message: " + item["message"].InnerText + Environment.NewLine);
                        });
                        sendData(molecule, arrParts[1], arrParts[2], arrParts[3], arrParts[4]);
                    }
                }
                else if (item["operador"].InnerText == "between")
                {
                    if (Int32.Parse(arrParts[1]) > Int32.Parse(item["value1"].InnerText) && Int32.Parse(arrParts[1]) < Int32.Parse(item["value2"].InnerText))
                    {
                        trigger = true;
                        arrParts[4] = "Alarm: " + molecule + " está entre " + item["value1"].InnerText + " e " + item["value2"].InnerText + "! Message: " + item["message"].InnerText + "\n";
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxAlarmes.AppendText("Alarm: " + molecule + " entre " + item["value1"].InnerText + " e " + item["value2"].InnerText + " -> Message: " + item["message"].InnerText + Environment.NewLine);
                        });
                        sendData(molecule, arrParts[1], arrParts[2], arrParts[3], arrParts[4]);
                    }
                }
            }
        }

>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
        private string[] extractFieldsFromXmlstr(string strTemp)
        {
            //Separa os valores do XML num array para ser manipulado mais facilmente
            String[] messageReceived = new string[5];

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(strTemp);
            
            messageReceived[0] = doc.SelectSingleNode("/Airmessage/molecule").InnerText;
            messageReceived[1] = doc.SelectSingleNode("/Airmessage/value").InnerText;
            messageReceived[2] = doc.SelectSingleNode("/Airmessage/time").InnerText;
<<<<<<< HEAD
            messageReceived[3] = doc.SelectSingleNode("/Airmessage/local").InnerText;
=======
            messageReceived[3] = doc.SelectSingleNode("/Airmessage/location").InnerText;
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27

            return messageReceived;
        }

        private void buttonDesligar_Click(object sender, EventArgs e)
        {
           if (m_cClient.IsConnected)
           {
                m_cClient.Disconnect();
                MessageBox.Show("Desligado!");
           }
        }

        private void richTextBoxDadosSensor_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxDadosSensor_TextChanged_1(object sender, EventArgs e)
        {
            richTextBoxDadosSensor.ScrollToCaret();
        }

        private void richTextBoxAlarmes_TextChanged(object sender, EventArgs e)
        {
            richTextBoxAlarmes.ScrollToCaret();
        }

        private void sendData(string molecule, string valor, string time, string local, string msg)
        {
            // Prepara string para ser lançada no Communication Channel

            string strMsgtoSend = buildXmlMessage(molecule, valor, time, local, msg);

            //Send
<<<<<<< HEAD
            m_cClient.Publish(STR_CHANNEL_NAME, Encoding.UTF8.GetBytes(strMsgtoSend));
=======
            m_cClient.Publish(STR_CHANNEL_NAME1, Encoding.UTF8.GetBytes(strMsgtoSend));
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            resetValues(molecule, valor, time, local, msg);
        }

        private string buildXmlMessage(string t_molecule, string t_value, string t_time, string t_local, string t_error)
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

<<<<<<< HEAD
            XmlNode location = doc.CreateElement("local");
=======
            XmlNode location = doc.CreateElement("location");
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
            location.InnerText = t_local;
            root.AppendChild(location);

            XmlNode error = doc.CreateElement("error");
            location.InnerText = t_local;
            root.AppendChild(location);

            doc.AppendChild(root);

            return doc.OuterXml;
        }

        private void resetValues(string molecule, string valor, string time, string local, string msg)
        {
            molecule = null;
            valor = null;
            time = null;
            local = null;
            msg = null;
        }

        /*private void regexValidation(string str)
        {
            valuesAlarmes = Regex.Split(str, @"\;");
        }*/
    
    }
}
