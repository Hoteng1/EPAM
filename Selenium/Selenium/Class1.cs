using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium
{
    [TestFixture]
    public class WebTest
    {
        
        [Test]
        public void Test()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Navigate().GoToUrl("https://github.com/");
            chrome.FindElement(By.XPath("//child::span//child::div//child::a")).Click();
            IWebElement webElementLogin=chrome.FindElement(By.Name("login"));
            webElementLogin.SendKeys("testautomationuser");
            IWebElement webElementPassword = chrome.FindElement(By.Name("password"));
            webElementPassword.SendKeys("Time4Death!");
            IWebElement webElementSubmit = chrome.FindElement(By.Name("commit"));
            webElementSubmit.Click();
           

        }
        


    }
}
