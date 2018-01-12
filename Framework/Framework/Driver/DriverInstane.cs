

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace Framework.Driver
{
    public class DriverInstane
    {
        static IWebDriver webDriver;

        private DriverInstane() { }

        public static IWebDriver GetInstance()
        {
            if(webDriver==null)
            {
                webDriver = new ChromeDriver();
                webDriver.Manage().Window.Maximize();
            }

            return webDriver;
        }

        public static void CloseBrowser()
        {
            if(webDriver!=null)
            {
                webDriver.Quit();
                webDriver = null;

                foreach (var process in Process.GetProcessesByName("geckodriver"))
                {
                    process.Kill();
                }
            }
        }
    }
}
