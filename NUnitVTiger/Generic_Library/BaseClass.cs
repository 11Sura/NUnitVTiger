using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitVTiger.Generic_Library
{
    [Author("Sushma")]
    public class BaseClass
    {
        public IWebDriver driver;
        [SetUp]
        public void LaunchBrowser()
        {
            driver = new ChromeDriver();
            WebActions webActions = new WebActions();
            webActions.ImplicitTimeout(driver);
            webActions.MaximizeWindow(driver);
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://localhost:8888/");
            Thread.Sleep(3000);
        }

        [TearDown]
        public void QuitBrowser()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
