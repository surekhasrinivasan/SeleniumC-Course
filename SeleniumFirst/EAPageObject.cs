using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;


namespace SeleniumFirst
{
    class EAPageObject
    {
        [Obsolete("The PageFactory implementation in the .NET bindings is deprecated and will be removed in a future release. This portion of the code has been migrated to the DotNetSeleniumExtras repository on GitHub (https://github.com/DotNetSeleniumTools/DotNetSeleniumExtras)")]
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How= How.Id, Using ="TitleId")]
        public IWebElement ddlTitleID { get; set; }

        [FindsBy(How=How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using ="FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using ="MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How =How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial, string firstName, string middleName)
        {
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            btnSave.Clicks();

            //SeleniumSetMethods.EnterText(txtInitial, initial);
            //SeleniumSetMethods.EnterText(txtFirstName, firstName);
            //SeleniumSetMethods.EnterText(txtMiddleName, middleName);
            //SeleniumSetMethods.Click(btnSave);

            //txtInitial.SendKeys(initial);
            //txtFirstName.SendKeys(firstName);
            //txtMiddleName.SendKeys(middleName);
            //btnSave.Click();
        }
    }
}
