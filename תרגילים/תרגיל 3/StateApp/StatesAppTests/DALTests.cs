using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateApp.DAL;
using StateApp.Entities;

namespace StatesAppTests
{
    [TestClass]
    public class DALTests
    {
        readonly StatesDAL dal=new StatesDAL();

        [TestMethod]
        public void ConnectionTest()
        {

            try
            {
                dal.ConnectDb();

            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void GetStateReturnNullTest()
        {
            try
            {
                State state;
                state = dal.GetState("notExistState");
                Assert.AreEqual(null, state);
            }
            catch (Exception e)
            { 
               Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void GetStateExistStateTest()
        {
            State state;
            state = dal.GetState("Israel");

            State israelState = new State("Israel", "Jerusalem", 56670,"notset");

            Assert.AreEqual(israelState.CapitalCity,state.CapitalCity);
            Assert.AreEqual(israelState.StateName,state.StateName);
        }

        [TestMethod]
        public void GetAllStatesTest()
        {
           

            int statasNumber = dal.GetAllStates().Count;
            Assert.IsTrue(statasNumber>1);
        }


    }
}
