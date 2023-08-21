using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitVTiger.Generic_Library
{
    [Author("Sushma")]
    public class WebActions 
    {
        //maximize the browser
        public void MaximizeWindow(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }

        //timeout ==> implicitly wait
        public void ImplicitTimeout(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        //mouse hover
        public void MouseHover(IWebElement element, IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }
    }
}
