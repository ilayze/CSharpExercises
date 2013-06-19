namespace StateApp.Entities
{
    public class State
    {
        private string _stateName;
        private string _capitalCity;
        private int _population;
        private string _stateFlagFile;

        public State(string stateName, string capitalCity, int population, string stateFlagFile)
        {
            _stateName = stateName;
            _capitalCity = capitalCity;
            _population = population;
            _stateFlagFile = stateFlagFile;
        }

        public string StateName
        {
            get { return _stateName; }
            set { _stateName = value; }
        }

        public string CapitalCity
        {
            get { return _capitalCity; }
            set { _capitalCity = value; }
        }

        public int Population
        {
            get { return _population; }
            set { _population = value; }
        }

        public string StateFlagFile
        {
            get { return _stateFlagFile; }
            set { _stateFlagFile = value; }
        }
    }
}
