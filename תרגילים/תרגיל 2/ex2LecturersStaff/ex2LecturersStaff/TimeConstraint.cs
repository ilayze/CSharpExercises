namespace ex2LecturersStaff
{
    public class TimeConstraint
    {


        #region fields

        private string _day;
        private int _beginHour;
        private int _endHour; 

        #endregion

        #region Constructor

        public TimeConstraint(string day, int begin, int end)
        {
            _day = day;
            _beginHour = begin;
            _endHour = end;
        }

        #endregion

        #region Properties

        public string Day
        {
            get { return _day; }
            set
            {
                if (value == "Sunday" || value == "Monday" || value == "Tuesday" || value == "Wednesday" ||
                    value == "Thursday")
                    _day = value;
            }
        }

        public int BeginHour
        {
            get { return _beginHour; }
            set
            {
                if (value > 7 && value < 21)
                    _beginHour = value;
            }
        }

        public int EndHour
        {
            get { return _endHour; }
            set
            {
                if (value > 7 && value < 21)
                    _endHour = value;
            }
        }

        #endregion


        public override string ToString()
        {
            return _day + ",from " + _beginHour + ":00 to " + _endHour+":00";
        }

        public int Hours()
        {
            return _endHour-_beginHour;
        }

        public bool Contains(TimeConstraint other)
        {
            if (other.BeginHour< BeginHour || other.EndHour > EndHour)
                return false;
            return true;
        }

        public TimeConstraint Union(TimeConstraint other)
        {
            if (!Day.Equals(other.Day))
                return null;

            int biggerEnd = EndHour < other.EndHour ? other.EndHour : EndHour; 
            if (BeginHour < other.BeginHour)
            {
                if (other.BeginHour > EndHour)
                {
                    return null;
                }

                
                return new TimeConstraint(Day,BeginHour,biggerEnd);
            }
            if (BeginHour > other.EndHour)
            {
                return null;
            }

            return new TimeConstraint(Day,other.BeginHour,biggerEnd);

        }



        
    }
}
