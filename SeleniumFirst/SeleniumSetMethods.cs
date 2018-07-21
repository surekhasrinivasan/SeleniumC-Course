using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        ///<summary>
        ///Extended method for entering Text in the control
        /// </summary>
        ///<param name="element"></param>
        ///<param name="value"></param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        ///<summary>
        ///Click on a button, checkbox, option etc
        /// </summary>
        ///<param name="element"></param>        
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        ///<summary>
        ///Selecting a drop down control
        /// </summary>
        ///<param name="element"></param>
        ///<param name="value"></param>        
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);            
        }

        ///<summary>
        ///Click on Submit botton control in the Login page
        /// </summary>
        ///<param name="element"></param>
        public static void ClickSubmit(this IWebElement element)
        {
            element.Submit();
        }


    }
}
