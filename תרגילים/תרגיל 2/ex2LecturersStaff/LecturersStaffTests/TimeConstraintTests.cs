using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex2LecturersStaff;

namespace LecturersStaffTests
{
    [TestClass]
    public class TimeConstraintTests
    {
        TimeConstraint tc=new TimeConstraint("Sunday",9,12);
        TimeConstraint tcOther = new TimeConstraint("Sunday", 10, 11);
       


        [TestMethod]
        public void CheckHoursFunction()
        {
            Assert.AreEqual(tc.Hours(),3);
        }
        
        [TestMethod]
        public void CheckToStringMethod()
        {
            string s = tc.ToString();
            Assert.AreEqual(s, "Sunday,from 9:00 to 12:00");

        }

        [TestMethod]
        public void CheckContainsMethod()
        {
            Assert.AreEqual(true, tc.Contains(tcOther));
        }

        [TestMethod]
        public void CheckUnionMethod()
        {
            TimeConstraint unionTc = tc.Union(tcOther);
            Assert.AreEqual(tc.ToString(),unionTc.ToString());
        }
    }
}
