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
    public class CreateNewContactPage
    {
        //declaration
        [FindsBy(How = How.Name, Using = "lastname")]   //lastname web element
        private IWebElement lastNameTextBox;
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='Organization Name']/..//img[@title='Select']")]
        private IWebElement organizationLookup;         //oragnization web element
        [FindsBy(How = How.Id, Using = "title")]         //title web element
        private IWebElement titleTextBox;
        [FindsBy(How = How.Id, Using = "department")]   //department webelement
        private IWebElement departmentTextBox;
        [FindsBy(How = How.Id, Using = "email")]        //email web element
        private IWebElement emailTextBox;
        [FindsBy(How = How.Name, Using = "emailoptout")] //email opt out web element
        private IWebElement emailOptOutCheckBox;
        [FindsBy(How = How.Id, Using = "mobile")]       //mobile web element
        private IWebElement mobileTextBox;
        [FindsBy(How = How.Name, Using = "birthday")]   //birthday web element
        private IWebElement birthdayTextBox;
        [FindsBy(How = How.Name, Using = "mailingstreet")]   //mailing street web element
        private IWebElement streetTextBox;
        [FindsBy(How = How.Id, Using = "mailingcity")]   //mailing city web element
        private IWebElement cityTextBox;
        [FindsBy(How = How.Id, Using = "mailingstate")]   //mailing state web element
        private IWebElement stateTextBox;
        [FindsBy(How = How.Id, Using = "mailingzip")]   //mailing postal code web element
        private IWebElement postalCodeTextBox;
        [FindsBy(How = How.Id, Using = "mailingcountry")]  //mailing country web element
        private IWebElement countryTextBox;
        [FindsBy(How = How.XPath, Using = "//input[@onclick='return copyAddressRight(EditView)']")]
        private IWebElement copyMailingAddRadioBtn;         //copy mailing address webelement
        [FindsBy(How = How.Name, Using = "description")]    //description web element
        private IWebElement descriptionTextBox;
        [FindsBy(How = How.XPath, Using = "//input[@class='crmbutton small save']")]    //save web element
        private IWebElement saveButton;

        //initialization
        public CreateNewContactPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //business logic
        public void CreateNewContact(string lastName, string title, string department, string email, string mobile, string birthday)
        {
            lastNameTextBox.SendKeys(lastName);
            titleTextBox.SendKeys(title);
            departmentTextBox.SendKeys(department);
            emailTextBox.SendKeys(email);
            emailOptOutCheckBox.Click();
            mobileTextBox.SendKeys(mobile);
            birthdayTextBox.SendKeys(birthday);
        }
        public void ContactAddress(string street, string city, string state, string postalCode, string country)
        {
            streetTextBox.SendKeys(street);
            cityTextBox.SendKeys(city);
            stateTextBox.SendKeys(state);
            postalCodeTextBox.SendKeys(postalCode);
            countryTextBox.SendKeys(country);
            copyMailingAddRadioBtn.Click();
        }
        public void Description(string description)
        {
            descriptionTextBox.SendKeys(description);
        }
        public void Save()
        {
            saveButton.Click();
        }
    }
}

