using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Framework.Pages
{
    public class MainPage
    {
        private const string BASE_URL = "http://www.github.com/new";
        private string errorLabel = "*//div[@class='sb-field'//div[@class='sb-error']";
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

        public void SetPiece(string from, string to)
        {
            inputFromPiece.SendKeys(from);
            inputToPiece.SendKeys(to);
        }

        public void SetDate(DateTime date)
        {
            dateTravel.SendKeys(date.ToString());
        }

        public void SetDate(DateTime? fromDate,DateTime? toDate)
        {
            tripType.SendKeys("Round-Trip");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            dateTravel.SendKeys(fromDate.ToString());
            dateReturn.SendKeys(toDate.ToString());
        }

        public void SetPeople(int count)
        {
            this.countPeople.SendKeys(count.ToString());
        }

  

        public bool IsTravelListExist()
        {
            var travelList = driver.FindElements(By.XPath("//div[@class='dwContainer']//div[@class='Results__tabsBody___2LwJ4']"));
            return travelList.Count > 0 ? true : false;
        }
         public bool isErrorExist()
        {
            var errorLabel = driver.FindElement(By.XPath(this.errorLabel));
            return errorLabel != null;
        }

    }
}
