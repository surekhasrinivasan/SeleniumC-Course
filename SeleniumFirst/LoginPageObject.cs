using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObject
    {
        [Obsolete("The PageFactory implementation in the .NET bindings is deprecated and will be removed in a future release. This portion of the code has been migrated to the DotNetSeleniumExtras repository on GitHub (https://github.com/DotNetSeleniumTools/DotNetSeleniumExtras)")]
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObject Login(string userName, string password)
        {
            //Username
            txtUserName.SendKeys(userName);

            //password
            txtPassword.SendKeys(password);

            //Login
            btnLogin.Submit();

            //Return the page object
            return new EAPageObject();
        }
    }
}
