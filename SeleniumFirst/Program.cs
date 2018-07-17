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
            driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("Opened URL");

        }

        [Test]
        public void ExecuteTest()
        {
            //Find the Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform operation
            element.SendKeys("executeautomation");
            Console.WriteLine("Executed Test");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Method");
        }

        [TearDown]
        public void CleanUp()
        {
            //close the google web browser
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
