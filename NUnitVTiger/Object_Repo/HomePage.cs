using NUnitVTiger.Generic_Library;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using FindsByAttribute = OpenQA.Selenium.Support.PageObjects.FindsByAttribute;
using How = OpenQA.Selenium.Support.PageObjects.How;


namespace NUnitVTiger.Object_Repo
{
    public class HomePage
    {
        //declaration
        [FindsBy(How = How.XPath, Using = "//table[@class='hdrTabBg']/descendant::a[text()='Contacts']")]
        private IWebElement contacts { get; set; }
        [FindsBy(How = How.XPath, Using = "//table[@class='hdrTabBg']/descendant::a[text()='More']")]
        public IWebElement more;
        [FindsBy(How = How.XPath, Using = "//span[text()=' Administrator']/parent::td/following-sibling::td/child::img[@src='themes/softed/images/user.PNG']")]
        public IWebElement administrator;
        [FindsBy(How = How.XPath, Using = "//a[text()='Sign Out']")]
        public IWebElement signout;


        //initialization
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }

        //business logic
        public void Contacts()
        {
            contacts.Click();
        }
        public void Logout(IWebDriver driver)
        {
            WebActions webActions = new WebActions();
            webActions.MouseHover(administrator,driver);
            signout.Click();
        }

    }
}
