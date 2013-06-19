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
using StateApp.BL;
using StateApp.Entities;
using StateApp.DAL;
using StateApp.ViewModel;
using StateApp.View;

namespace StateApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StatesDAL repository;
        StatesBL BL;
        MainWindowViewModel vm;

         

        public MainWindow(MainWindowViewModel viewModel)
        {
            InitializeComponent();
            repository = new StatesDAL();
            BL = new StatesBL(repository);
            vm = viewModel;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddNewForm(BL);
            window.Closed+=new EventHandler(Addnew_Closed);
            this.IsEnabled = false;
            window.Show();
        }

        private void Addnew_Closed(object sender,EventArgs e)
        {
            this.IsEnabled = true;
            vm.Refresh();
        }


        private void sv_Closed(object sender, EventArgs e)
        {
            this.IsEnabled = true;
           
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            if (listStates.SelectedItem != null)
            {
                string stateName = (string)listStates.SelectedItem;
                if (BL.IsStateExist(stateName))
                {
                    State state = BL.GetState(stateName);
                    StateView sv = new StateView(state);
                    sv.Closed+=new EventHandler(sv_Closed);
                    this.IsEnabled = false;
                    sv.Show();

                }
            }
            else if (!String.IsNullOrEmpty(txtSearch.Text))
            {
                string stateName = txtSearch.Text;
                if (BL.IsStateExist(stateName))
                {
                    State state = BL.GetState(stateName);
                    StateView sv = new StateView(state);
                    sv.Closed += new EventHandler(sv_Closed);
                    this.IsEnabled = false;
                    sv.Show();
                }
                else
                {
                    MessageBox.Show("state " + txtSearch.Text + " does not exist in database!");
                }
            }
            else
            {
                MessageBox.Show("Please choose state from list or type in search box", "ERROR");
            }
        }
    }
}
