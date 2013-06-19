using System.Collections.Generic;
using System.ComponentModel;
using StateApp.BL;
using StateApp.DAL;
using StateApp.Entities;
using System.Collections.ObjectModel;

namespace StateApp.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly StatesBL BL;
        private LinkedList<State> _states;
        

        ObservableCollection<string> _statesNames;

        public ObservableCollection<string> StatesNames
        {
            get { return _statesNames; }
            set
            {
                if (value == _statesNames)
                    return;
                _statesNames = value;
                OnPropertyChanged("StatesNames");
            }
        }

        public MainWindowViewModel()
        {
            BL=new StatesBL(new StatesDAL());
            _statesNames=new ObservableCollection<string>();
            States = BL.GetAllStates();
           
        }

        public void Refresh()
        {
            States = BL.GetAllStates();

        }


        public LinkedList<State> States
        {
            get { return _states; }
            set
            {
                if (value == States)
                    return;
                _states = value;
                StatesNames.Clear();
                ObservableCollection<string> temp = new ObservableCollection<string>();
                foreach (var state in _states)
                {
                    temp.Add(state.StateName);
                }
                StatesNames = temp;
                OnPropertyChanged("States");
                OnPropertyChanged("StatesNames");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
