using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Framework.Pages
{
    public class MainPage
    {
        private const string BASE_URL = "http://www.github.com/new";
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "departureCity")]
        private IWebElement inputFromPiece;

        [FindsBy(How = How.Id, Using = "arrivalCity")]
        private IWebElement inputToPiece;

        [FindsBy(How = How.XPath, Using = "//div[@class='sb-col sb-span-3-t sb-span-3-d  departure-calendar']//span[@class='sb-msg']")]
        private IWebElement dateTravel;


        [FindsBy(How = How.XPath, Using = "//div[@class='sb-col sb-span-3-d sb-span-3-t return-calendar']//span[@class='sb-msg']")]
        private IWebElement dateReturn;

        [FindsBy(How = How.ClassName, Using = "sb-col sb-span-3-t sb-span-3-d sb-searchBtn sb-inner-shadow")]
        private IWebElement butttonCreate;

        [FindsBy(How = How.ClassName, Using = "sb-counter sb-small")]
        private IWebElement countPeople;

        [FindsBy(How = How.Id, Using = "tripType")]
        private IWebElement tripType;


        public MainPage(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        } 

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void ClickButton()
        {
            butttonCreate.Click();
        }

        public void CaseTests(string from , string to, string date,string dateReturn, bool isReturn, int countPeople)
        {
            inputFromPiece.SendKeys(from);
            inputFromPiece.SendKeys(to);
            dateTravel.SendKeys(date);
            this.countPeople.SendKeys(countPeople.ToString());
            if(isReturn)
            {
                tripType.SendKeys("Round-Trip");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                this.dateReturn.SendKeys("dateRetrun");
                
            }
            ClickButton();
            
        }

        public bool isWork()
        {
            var url = driver.Url;
            return url == BASE_URL ? false : true;
        }

    }
}
