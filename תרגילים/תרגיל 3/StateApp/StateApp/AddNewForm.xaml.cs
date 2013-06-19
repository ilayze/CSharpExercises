using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using StateApp.BL;
using StateApp.Entities;

namespace StateApp
{
    /// <summary>
    /// Interaction logic for AddNewForm.xaml
    /// </summary>
    public partial class AddNewForm : Window
    {
        StatesBL BL;

        public AddNewForm(StatesBL bl)
        {
            InitializeComponent();
            BL = bl;
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
                txtFlagFile.Text = filename;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateData())
            {
                State state=GenerateState();
                BL.AddState(state);
                this.Close();
            }
        }

        private State GenerateState()
        {
            int population = Convert.ToInt32(txtPopulation.Text);

            State s = new State(txtStateName.Text, txtCapitalCity.Text, population, txtFlagFile.Text);
            return s;
        }


        /// <summary>
        /// check the data in the textbox is valid
        /// </summary>
        /// <returns></returns>
        private bool ValidateData()
        {
            if (String.IsNullOrEmpty(txtStateName.Text))
            {
                MessageBox.Show("Please enter state name","ERROR");
                return false;
            }
            if (String.IsNullOrEmpty(txtCapitalCity.Text))
            {
                MessageBox.Show("Please enter Capital city name","ERROR");
                return false;
            }
            if(String.IsNullOrEmpty(txtPopulation.Text))
            {
                MessageBox.Show("Please enter population","ERROR");
                return false;
            }
            string str=txtPopulation.Text.Trim();
            int num;
            bool isNum=int.TryParse(str,out num);
            if(!isNum)
            {
                MessageBox.Show("Please enter a number in population","ERROR");
            }

            if(String.IsNullOrEmpty(txtFlagFile.Text))
            {
                MessageBox.Show("Please enter Flag File path ","ERROR");
                return false;
            }

            if (BL.IsStateExist(txtStateName.Text))
            {
                MessageBox.Show("State " + txtStateName.Text + " already exists in the database");
                return false;
            }

            return true;

            
            

            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
