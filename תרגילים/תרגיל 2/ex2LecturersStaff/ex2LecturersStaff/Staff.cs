using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex2LecturersStaff
{
    public class Staff
    {
        private LinkedList<Lecturer> _lecturers;

        public Staff()
        {
            _lecturers=new LinkedList<Lecturer>();
            _lecturers.AddLast(new Lecturer("ilay", "zeidman"));
            Lecturer ab=new Lecturer("a","b");
            ab.AddConstraint(new TimeConstraint("Sunday", 9, 12));
            ab.AddConstraint(new TimeConstraint("Tuesday",13,18));
            _lecturers.AddLast(ab);
        }

        public LinkedList<Lecturer> Lecturers
        {
            get { return _lecturers; }
        }

        public LinkedList<TimeConstraint> GetConstraints(string first, string last)
        {
            return (from lecturer in _lecturers where lecturer.FirstName == first && lecturer.LastName == last
                    select lecturer.GetConstraints()).FirstOrDefault();
        }

        public void AddConstraints(string first, string last, LinkedList<TimeConstraint> list)
        {
            foreach (var lecturer in _lecturers.Where(lecturer => lecturer.FirstName == first && lecturer.LastName == last))
            {
                foreach (var timeConstraint in list)
                {
                    lecturer.AddConstraint(timeConstraint);
                }
                return;
            }
        }
    }
}
