using Framework.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Steps
{
    class Step
    {
        public string defaultDeparture { get; } = "Paris";
        public string defaultArrival { get; } = "Barselona";

        public IWebDriver webDriver;

        public void InitBrowser()
        {
            webDriver = Driver.DriverInstane.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstane.CloseBrowser();
        }

        public void SearchTravel(string from , string to)
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.OpenPage();
            mainPage.SetPiece(from, to);
            mainPage.ClickButton();
        }

        public void SerchWithDate(DateTime travelDate)
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.OpenPage();
            mainPage.SetPiece(defaultDeparture, defaultArrival);
            mainPage.SetDate(travelDate);
            mainPage.ClickButton();
        }
        public void SearchWithDate(DateTime? travelDate , DateTime? returnDate)
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.OpenPage();
            mainPage.SetPiece(defaultDeparture, defaultArrival);
            mainPage.SetDate(travelDate, returnDate);
            mainPage.ClickButton();
        }

        public void SearchWithPeople(int countPeople)
        {
            MainPage mainPage = new MainPage(webDriver);
            mainPage.OpenPage();
            mainPage.SetPiece(defaultDeparture, defaultArrival);
            mainPage.SetPeople(countPeople);
            mainPage.ClickButton();
        }

        public bool isListExist()
        {
            return new MainPage(webDriver).IsTravelListExist();
        }

        public bool isError(string message)
        {
            return new MainPage(webDriver).isErrorExist(message);
        }

        public bool isCorrectDate(DateTime fromDate, DateTime toDate)
        {
            return new MainPage(webDriver).isDateFollow(fromDate, toDate);
        }
    }
}
