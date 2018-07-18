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
        //create the reference for our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args) 
        {
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to Google page
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");

        }

        [Test]
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");

            //Click
            SeleniumSetMethods.Click(driver, "Save", "Name");

            Console.WriteLine("The value from Title is: " + SeleniumGetMethods.GetTextFromDDL(driver, "TitleId", "Id"));

            Console.WriteLine("The value from Initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));
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
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
