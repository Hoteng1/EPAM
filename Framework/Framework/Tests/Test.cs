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

        public Test()
        {

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
        public void TestOne()
        {
            var webDriver = Driver.DriverInstane.GetInstance();
            MainPage mainPage = new MainPage(webDriver);
            mainPage.OpenPage();
            mainPage.CaseTests("Paris", "Barselona", "13.01.2018", null, false, 1);

            Assert.IsTrue(mainPage.isWork());
        }

        [TestMethod]
        public void TestTwo()
        {
            var webDriver = Driver.DriverInstane.GetInstance();
            MainPage mainPage = new MainPage(webDriver);
            mainPage.OpenPage();
            mainPage.CaseTests("Paris", "Barselona", "13.01.2018", null, false, 3);

            Assert.IsTrue(mainPage.isWork());
        }

        [TestMethod]
        public void TestThree()
        {
            var webDriver = Driver.DriverInstane.GetInstance();
            MainPage mainPage = new MainPage(webDriver);
            mainPage.OpenPage();
            mainPage.CaseTests("Paris", "Barselona", "13.01.2018", "14.02.2018",true , 1);

            Assert.IsTrue(mainPage.isWork());
        }

        [TestMethod]
        public void TestFour()
        {
            var webDriver = Driver.DriverInstane.GetInstance();
            MainPage mainPage = new MainPage(webDriver);
            mainPage.OpenPage();
            mainPage.CaseTests("Paris", "", "13.01.2018", null, false, 1);

            Assert.IsTrue(mainPage.isWork());
        }

        [TestMethod]
        public void TestFive()
        {
            var webDriver = Driver.DriverInstane.GetInstance();
            MainPage mainPage = new MainPage(webDriver);
            mainPage.OpenPage();
            mainPage.CaseTests("", "Barselona", "13.01.2018", null, false, 1);

            Assert.IsTrue(mainPage.isWork());
        }

        [TestMethod]
        public void TestSix()
        {
            var webDriver = Driver.DriverInstane.GetInstance();
            MainPage mainPage = new MainPage(webDriver);
            mainPage.OpenPage();
            mainPage.CaseTests("Paris", "Barselona", "15.01.2018", "14.01.2018", true, 1);

            Assert.IsTrue(mainPage.isWork());
        }

        [TestMethod]
        public void TestSeven()
        {
            var webDriver = Driver.DriverInstane.GetInstance();
            MainPage mainPage = new MainPage(webDriver);
            mainPage.OpenPage();
            mainPage.CaseTests("London", "London", "13.01.2018", null, false, 1);

            Assert.IsTrue(mainPage.isWork());
        }

       
    }
}
