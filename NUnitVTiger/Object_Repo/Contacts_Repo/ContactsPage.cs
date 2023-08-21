using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
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
    public class ContactsPage
    {
        //declaration
        [FindsBy(How = How.XPath, Using = "//img[@title='Create Contact...']")]  //create contact web element
        private IWebElement createContactBtn;
        [FindsBy(How = How.Name, Using = "search_text")]           //search web element
        private IWebElement searchTextBox;
        [FindsBy(How = How.Id, Using = "bas_searchfield")]           //In dropdown web element
        private IWebElement inDropdown;
        [FindsBy(How = How.Name, Using = "submit")]             //search web element
        private IWebElement searchButton;

        //initialization
        public ContactsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //utilization
        public IWebElement GetCreateContactBtn
        {
            get { return createContactBtn; }
        }
        public IWebElement GetInDropdown()
        {
            return inDropdown;
        }

        //business logic
        public void ClickCreateContact()
        {
            createContactBtn.Click();
        }

        public void InLastName()
        {
            inDropdown.Click();
            IWebElement element = GetInDropdown();
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue("lastname");
        }

        public void SearchContact(string lastName)
        {
            searchTextBox.SendKeys(lastName);
            searchButton.Click();

        }
    }
}

