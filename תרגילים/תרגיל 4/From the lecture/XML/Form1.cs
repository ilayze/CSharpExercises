using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XML
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> l = XMLUtils.GetCoins();
            foreach (string s in l)
                cboFrom.Items.Add(s);
        }

        private void cmdLoadFile_Click(object sender, EventArgs e)
        {
            DialogResult res =  openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string xmlText = XMLUtils.LoadXML(path);
                txtOutput.Text = xmlText;
            }
        }

        private void cmdLoadString_Click(object sender, EventArgs e)
        {
            string xmlRes = XMLUtils.LoadXMLString(txtOutput.Text);
            txtOutput.Text = xmlRes;
        }

        private void cmdCountries_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string xmlText = XMLUtils.GetCountriesAndCoins(path);
                txtOutput.Text = xmlText;
            }
        }

        private void cmdConvert_Click(object sender, EventArgs e)
        {
            
            if (!ValidInput())
                MessageBox.Show("Invalid input");
            else
            {
                string xmlConvert = "<ConvertData>";
                string code = (string)cboFrom.SelectedItem;
                char[] del = {',', ' '};
                string[] res = code.Split(del);
                xmlConvert = xmlConvert + "<Code>" + res[2] + "</Code>";
                xmlConvert = xmlConvert + "<Amount>" + txtAmount.Text + "</Amount>";
                xmlConvert = xmlConvert + "</ConvertData>";
                txtTotal.Text = XMLUtils.Convert(xmlConvert);
            }
             
           
        }

        private bool ValidInput()
        {
            bool valid = true;
            if (cboFrom.SelectedIndex == -1)
                valid = false;
            if (txtAmount.Text == "")
                valid = false;
            try
            {
                int.Parse(txtAmount.Text);
            }
            catch (FormatException e)
            {
                valid = false;
            }
            return valid;
        }

       

        private void cmdXSL_Click(object sender, EventArgs e)
        {
            string xmlFile, xslFile;
            openFileDialog1.ShowDialog();
            xmlFile = openFileDialog1.FileName;
            openFileDialog1.ShowDialog();
            xslFile = openFileDialog1.FileName;
            XMLUtils.Transform(xmlFile, xslFile);

        }

        private void cmdSerialize_Click(object sender, EventArgs e)
        {
            string[] a = {"yossi", "Shimon"};
            Book b = new Book("XML gor Dummies", "McGrew Hill", 300, a);
            XMLUtils.XmlSerialize(b);
        }

        

        

    }
}
