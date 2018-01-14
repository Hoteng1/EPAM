using Framework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Tests
{
    [TestClass]
    public class Test
    {
        private readonly string ERROR_EMPTY_FIELD = "Please fill in destination";
        private readonly string ERROR_EQUEL_FILEDS = "Destination and point of departure cannot be the same";
        Steps.Step steps = new Steps.Step();
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;
        int tomorowDay = DateTime.Now.Day + 1;
        DateTime today;
        DateTime tomorow;
        public Test()
        {
            today= DateTime.Now; 
            tomorow = new DateTime(year, month, tomorowDay); 
        }

        private TestContext testContextInstance;


        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void TestCommot()
        {
            steps.InitBrowser();
            steps.SearchTravel("Paris", "Barselona");


            Assert.IsTrue(steps.isListExist());
        }

        [TestMethod]
        public void TestTwo()
        {

            steps.InitBrowser();
            steps.SearchWithPeople(3);

            Assert.IsTrue(steps.isListExist());
        }

        [TestMethod]
        public void TestWithDate()
        {
            steps.InitBrowser();


            steps.SearchWithDate(today, tomorow);


            Assert.IsTrue(steps.isListExist());
        }

        [TestMethod]
        public void TestWithNullFirstDate()
        {
            steps.InitBrowser();

            
            steps.SearchWithDate(null, tomorow);


            Assert.IsTrue(steps.isError(ERROR_EMPTY_FIELD));
        }

        [TestMethod]
        public void TestWithNullDeparture()
        {
            steps.InitBrowser();
            steps.SearchTravel( "Barselona", null);

            Assert.IsTrue(steps.isError(ERROR_EMPTY_FIELD));
        }

        [TestMethod]
        public void TestWithWrongDate()
        {
            steps.InitBrowser();


            steps.SearchWithDate(tomorow, today);


            Assert.IsTrue(steps.isCorrectDate(tomorow,today));
        }

        [TestMethod]
        public void TestSeven()
        {
            steps.InitBrowser();
            steps.SearchTravel("London", "London");

            Assert.IsTrue(steps.isError(ERROR_EQUEL_FILEDS));
        }


    }
}
