
using NUnit.Framework;
using NUnitVTiger.Generic_Library;
using NUnitVTiger.Object_Repo;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V101.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vtiger_Framework.Main_Folder.ObjectRepository.ContactsRepo;
using Vtiger_Framework.Main_Folder.ObjectRepository.LoginRepo;

namespace Vtiger_Framework.Test_Scripts.Test.ContactsTest
{
    [TestFixture]
    [Category("contacts")]
    public class CreateContactTest : BaseClass
    {
        [Test]
        [Category("create")]
        public void CreateContactMain()
        {
            LoginPage loginPage = new LoginPage(driver);
            HomePage homePage = new HomePage(driver);
            ContactsPage contactsPage = new ContactsPage(driver);
            CreateNewContactPage createNewContact = new CreateNewContactPage(driver);
            ContactInformationPage contactInformation = new ContactInformationPage(driver);

            //login
            loginPage.Login("admin","password");
         //   driver.FindElement(By.Name("user_name")).SendKeys("admin");
         //   driver.FindElement(By.Name("user_password")).SendKeys("password");
         //   driver.FindElement(By.Id("submitButton")).Click();

            //create a contact
            
            homePage.Contacts();
            contactsPage.ClickCreateContact();
            string lastname = "xyz";
            createNewContact.CreateNewContact(lastname, "Manager", "Sales", lastname + "@company.com", "9078563412", "1994-09-12");
            Thread.Sleep(5000);
            createNewContact.ContactAddress("abc123 street", "Bengaluru", "Karnataka", "532098", "India");
            Thread.Sleep(5000);
            createNewContact.Description("This is a test description 123&*");
            Thread.Sleep(5000);
            createNewContact.Save();
            //verify whether the contact is created
            Thread.Sleep(8000);
            contactInformation.VerifyCreate(lastname);
        }
    }
}

