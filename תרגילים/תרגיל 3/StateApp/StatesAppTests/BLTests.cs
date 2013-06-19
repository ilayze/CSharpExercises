using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateApp.BL;
using StateApp.DAL;
using StateApp.Entities;

namespace StatesAppTests
{
    [TestClass]
    public class BLTests
    {
        StatesBL BL=new StatesBL(new StatesDAL());

        [TestMethod]
        public void AddStateAlreadyExistTest()
        {
            State israelState = new State("Israel", "Jerusalem", 56670, "notset");
            bool a=BL.AddState(israelState);
            Assert.IsFalse(a);
        }
    }
}
