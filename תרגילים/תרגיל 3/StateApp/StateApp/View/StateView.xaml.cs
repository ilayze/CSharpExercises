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
using System.Windows.Navigation;
using System.Windows.Shapes;
using StateApp.Entities;

namespace StateApp.View
{
    /// <summary>
    /// Interaction logic for StateView.xaml
    /// </summary>
    public partial class StateView : Window
    {
        State state;

        public StateView(State s)
        {
            InitializeComponent();
            state = s;

            FillDetails();
        }

        private void FillDetails()
        {
            if (state == null)
                return;
            
            txtState1.Text = state.StateName;
            txtCapital.Text = state.CapitalCity;
            txtPopulation.Text = getPopulationString();//state.Population.ToString();

            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri(state.StateFlagFile);
            logo.EndInit();

            image1.Source = logo;

        }

        private string getPopulationString()
        {
            string populationString = state.Population.ToString();
            if (populationString.Length < 4)
                return populationString;
            else
            {
                int counter = 0;
                for (int i = populationString.Length - 1; i > 0; i--)
                {
                    counter++;
                    string delimiter = ",";
                    if (counter % 3 == 0)
                    {
                        populationString=populationString.Insert(i, delimiter);
                    }
                }
                return populationString;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
