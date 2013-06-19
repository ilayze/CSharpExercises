using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlParserTool;

namespace XmlToolTests
{
    [TestClass]
    public class TransformBLTests
    {
        readonly TransformBL BL=new TransformBL();

        [TestMethod]
        public void CreateClassFromXmlTest()
        {
             string xmlFile = "../../MoqData/classData.xml";
             string outputFile = "../../MoqData/";
             BL.CreateClassFromXML(xmlFile, outputFile);
        }

        [TestMethod]
        public void MissClassNameTest()
        {
            string xmlFile = "../../MoqData/InvalidDataScenarios/missClassName.xml";
            string outputFile = "../../MoqData/";
            bool success= BL.CreateClassFromXML(xmlFile, outputFile);
            Assert.AreEqual(success,false);
            Console.WriteLine(TransformBL.ErrorMessage);
        }

        [TestMethod]
        public void MissClassTagTest()
        {
            string xmlFile = "../../MoqData/InvalidDataScenarios/missClassTag.xml";
            string outputFile = "../../MoqData/";
            bool success = BL.CreateClassFromXML(xmlFile, outputFile);
            Assert.AreEqual(success, false);
            Console.WriteLine(TransformBL.ErrorMessage);
        }

        [TestMethod]
        public void CreateAPITest()
        {
            string xmlFile = "../../MoqData/classData.xml";
             string outputFile = "../../MoqData/test.html";
            BL.CreateAPI(xmlFile, outputFile);
        }
    }
}
