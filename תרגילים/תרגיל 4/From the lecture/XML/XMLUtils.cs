using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Xml.Serialization; 

using System.IO;namespace XML
{
    class XMLUtils
    {
        private const string PATH = "H:\\Knowledge Base\\Web Applications\\DotNet\\Code\\XML\\Currency.xml";
        public static string LoadXML(string xmlFile)
        {
            XmlDocument dom = new XmlDocument();
            try
            {
                dom.Load(xmlFile);
                return dom.OuterXml;
            }
            catch(XmlException e)
            {
                return "Unable to load XML file";
            }
        }

        public static string LoadXMLString(string xmlString)
        {
            XmlDocument dom = new XmlDocument();
            try
            {
                dom.LoadXml(xmlString);
                return dom.OuterXml;
            }
            catch (XmlException e)
            {
                return "Unable to load XML file";
            }
        }

        public static string GetCountriesAndCoins(string xmlFile)
        {
            string res = "";
            XmlDocument dom = new XmlDocument();
            try
            {
                dom.Load(xmlFile);
               
                XmlNodeList countries = dom.SelectNodes("CURRENCIES/CURRENCY/COUNTRY");
                XmlNodeList coins = dom.SelectNodes("CURRENCIES/CURRENCY/NAME");
                for (int i = 0; i < countries.Count; i++)
                    res = res + countries[i].InnerText + ": " + coins[i].InnerText + Environment.NewLine;
            }
            catch (XmlException e)
            {
                res = "Unable to load XML file";
            }
            return res;
        }

        public static List<string> GetCoins()
        {
            
            XmlDocument dom = new XmlDocument();
            List<string> l = new List<string>();
            try
            {
                dom.Load(PATH);
                foreach (XmlNode curr in dom.SelectNodes("CURRENCIES/CURRENCY"))
                {
                    string name = curr.SelectSingleNode("NAME").InnerText;
                    string code = curr.SelectSingleNode("CURRENCYCODE").InnerText;
                    l.Add(name + ", " + code);
                }
            }
            catch (XmlException e)
            {
                
            }
            return l;

        }
        public static string Convert(string xmlData)
        {
            XmlDocument dom = new XmlDocument();
            XmlDocument dom2 = new XmlDocument();
            string res = "";
            try
            {
                dom.LoadXml(xmlData);
                string code = dom.SelectSingleNode("ConvertData/Code").InnerText;
                double amount = double.Parse(dom.SelectSingleNode("ConvertData/Amount").InnerText);
                
                dom2.Load(PATH);
                foreach (XmlNode node in dom2.SelectNodes("CURRENCIES/CURRENCY"))
                {
                    if (node.SelectSingleNode("CURRENCYCODE").InnerText == code)
                    {
                        double rate = double.Parse(node.SelectSingleNode("RATE").InnerText);
                        double unit = double.Parse(node.SelectSingleNode("UNIT").InnerText);
                        res = "" + ((rate / unit) * amount);
                        break;
                        
                    }
                }
            }
            catch (XmlException e)
            {
                res = "Unable to load XML file";
            }
            return res;
        }

        public static void SaxParser(string xmlData)
        {
           
            XmlTextReader reader = new XmlTextReader(PATH);
                

            while (reader.Read())
            {
                       
            }
            
        }

        public static void Transform(string xmlFile, string xslPath)
        {
            XPathDocument xml = new XPathDocument(xmlFile);
            XslCompiledTransform trans = new XslCompiledTransform();
            trans.Load(xslPath);
            XmlTextWriter output = new XmlTextWriter("H:\\Knowledge Base\\Web Applications\\DotNet\\Code\\XML\\CV.txt", null);
            trans.Transform(xml, null, output);
            output.Close();
        }

        public static void XmlSerialize(Book b)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Book));
            StreamWriter output = new StreamWriter("C:\\Users\\Shay\\Documents\\Companies\\ARX\\Book.xml");
            ser.Serialize(output, b);
            output.Close();
        }
       
    }
}
