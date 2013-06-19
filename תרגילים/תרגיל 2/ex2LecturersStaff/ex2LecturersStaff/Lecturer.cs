using System.Collections.Generic;
using System.Linq;

namespace ex2LecturersStaff
{
    public class Lecturer
    {
        #region fields

        private string _firstName;
        private string _lastName;
        private LinkedList<TimeConstraint> _constraints=new LinkedList<TimeConstraint>();

        #endregion

        #region Properties

        public string LastName
        {
            get { return _lastName; }
        }


        public string FirstName
        {
            get { return _firstName; }
        }

        public LinkedList<TimeConstraint> Constraints
        {
            get { return _constraints; }
        }

        #endregion

        #region Constructor

        public Lecturer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        #endregion

        #region Methods

        public void AddConstraint(TimeConstraint t)
        {
            if (_constraints.Contains(t))
                return;
            foreach (var constraint in _constraints.Where(constraint => constraint.Day == t.Day))
            {
                //case 1
                if (constraint.Contains(t) || t.Contains(constraint) )
                {
                    _constraints.Remove(constraint);
                    _constraints.AddLast(constraint.Union(t));
                    return;
                }

                //case 2
                if (constraint.BeginHour < t.BeginHour && t.BeginHour < constraint.EndHour )
                {
                    _constraints.Remove(constraint);
                    _constraints.AddLast(constraint.Union(t));
                    return;
                }

                //case 3
                if (t.BeginHour < constraint.BeginHour && constraint.BeginHour < t.EndHour)
                {
                    _constraints.Remove(constraint);
                    _constraints.AddLast(constraint.Union(t));
                    return;
                }
                
            }
            _constraints.AddLast(t);
        }


        public LinkedList<TimeConstraint> GetConstraints()
        {
            return _constraints;
        }

        public int DifferentDays()
        {
            int counter = 0;
            var days=new List<string>();
            foreach (var timeConstraint in _constraints.Where(timeConstraint => !days.Contains(timeConstraint.Day)))
            {
                days.Add(timeConstraint.Day);
                counter++;
            }
            return counter;
        }

        public int Hours()
        {
            return _constraints.Sum(timeConstraint => timeConstraint.EndHour - timeConstraint.BeginHour);
        }

        #endregion





    }
}
