using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args) 
        {
        }

        [SetUp]
        public void Initialize()
        {
            //create the reference for our browser
            PropertiesCollection.driver = new ChromeDriver();

            //Navigate to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Initialize the page by calling its reference 
            EAPageObject page = new EAPageObject();

            page.txtInitial.SendKeys("executeautomation");

            page.btnSave.Click();

            Console.WriteLine("Executed Test");

            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            ////Initial
            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            ////Click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);

            //Console.WriteLine("The value from Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));

            //Console.WriteLine("The value from Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Method");
        }

        [TearDown]
        public void CleanUp()
        {
            //close the web browser
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
