using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AirMonit_Alarm
{
    public class HandlerXML
    {

        public HandlerXML(string xmlFilePath, string xsdFilePath)
        {
            XmlFilePath = xmlFilePath;
            XsdFilePath = xsdFilePath;
        }

        public HandlerXML(string xmlFilePath)
        {
            XmlFilePath = xmlFilePath;
        }

        public string XmlFilePath { get; set; }
        public string XsdFilePath { get; set; }

        public List<string> GetCondicoes()
        {
            List<string> lista = new List<string>();

            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilePath);

            XmlNodeList condicoes = doc.SelectNodes("/condicoes/condicao/molecule");

            foreach (XmlNode item in condicoes)
            {
                lista.Add(item.InnerText);
            }

            return lista;
        }
    }
}
