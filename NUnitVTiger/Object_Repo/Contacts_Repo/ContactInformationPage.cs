
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindsByAttribute = OpenQA.Selenium.Support.PageObjects.FindsByAttribute;
using How = OpenQA.Selenium.Support.PageObjects.How;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.ContactsRepo
{
    public class ContactInformationPage
    {
        //declaration
        [FindsBy(How = How.XPath, Using = "//span[@class='dvHeaderText']")]
        private IWebElement headerText;
        [FindsBy(How = How.Id, Using = "dtlview_Email Opt Out")]
        private IWebElement emailOptOutText;

        //initialization
        public ContactInformationPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //business logic
        public void VerifyCreate(string lastname)
        {
            string actualHeader = headerText.Text;
            Assert.IsTrue(actualHeader.Contains(lastname), "FAIL : Unable to create contact");
            Console.WriteLine("Contact created successfully");
        }

        public void VerifyEdit()
        {
            string actualEmailOptOut = emailOptOutText.Text;
            Assert.IsTrue(actualEmailOptOut.Equals("no"), "FAIL : Unable to edit contact");
            Console.WriteLine("Contact updated successfully");
        }
    }
}

