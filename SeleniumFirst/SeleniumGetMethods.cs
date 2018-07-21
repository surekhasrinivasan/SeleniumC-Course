using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {
        //Get the text out of the controls
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        //Get the value of selected text from drop down list
        public static string GetTextFromDDL(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;            
        }
    }
}
