
using NUnitVTiger.Generic_Library;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindsByAttribute = OpenQA.Selenium.Support.PageObjects.FindsByAttribute;
using How = OpenQA.Selenium.Support.PageObjects.How;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.LoginRepo
{
  
    public class LoginPage 
    {
        
        //declaration
        [FindsBy(How = How.Name, Using = "user_name")]
        private IWebElement username;
        [FindsBy(How = How.Name, Using = "user_password")]
        private IWebElement password;
        [FindsBy(How = How.Id, Using = "submitButton")]
        private IWebElement loginbutton;

        //initialization
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        
        
       //business logic
        public void Login(string Username, string Password)
        {
            username.SendKeys(Username);
            password.SendKeys(Password);
            loginbutton.Click();
        }
    }
}

