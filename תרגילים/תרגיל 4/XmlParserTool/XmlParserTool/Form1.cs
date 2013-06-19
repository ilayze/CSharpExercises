using System;
using System.Windows.Forms;
using XmlParserTool.Properties;

namespace XmlParserTool
{
    public partial class Form1 : Form
    {
        private string _xmlPath;
        private string _outputPath;
        private TransformBL BL;

        public Form1()
        {
            InitializeComponent();
            BL=new TransformBL();
        }

        private void LoadXml_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
           
            if (result == DialogResult.OK) // Test result.
            {
                if (!openFileDialog1.FileName.EndsWith(".xml"))
                {
                    txtResults.Text = Resources.xml_error_message;
                }
                else
                {
                    txtResults.Text = Resources.xml_success;
                }

                _xmlPath = openFileDialog1.FileName;
                string[] splitFileName = openFileDialog1.FileName.Split('\\');
                txtXmlpath.Text = splitFileName[splitFileName.Length-1];
            }
        }

        private void SetOutput_Click(object sender, EventArgs e)
        {
             // Show the dialog and get result.
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                _outputPath = folderBrowserDialog1.SelectedPath;
                txtResults.Text = Resources.output_success;
                txtOutput.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_outputPath))
            {
                txtResults.Text = "missed output path";
                return;
            }
            if (String.IsNullOrEmpty(_xmlPath))
            {
                txtResults.Text = "missed xml path";
                return;   
            }

           bool success= BL.CreateAPI(_xmlPath, _outputPath);
           if (success)
           {
               txtResults.Text = "SUCCESS:The Tranform was successful!";
           }
           else
           {
               txtResults.Text= "ERROR:The tranform failed!!!";
           }
        }
    }
}
