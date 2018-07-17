using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args) 
        {
            //create the reference for our browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to Google page
            driver.Navigate().GoToUrl("https://www.google.com");

            //Find the Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform operation
            element.SendKeys("executeautomation");

            //close the google web browser
            driver.Close();
        }
    }
}
