using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AirMonit_Alarm
{
    public partial class Form1 : Form
    {

        XDocument documentXml = XDocument.Load("triggerRules.xml");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            
        }

        private void getConditions_Click(object sender, EventArgs e)
        {
            HandlerXML myclass = new HandlerXML(documentXml.ToString());

            listaCondicoes.DataSource = myclass.GetCondicoes();
        }
    }
}
