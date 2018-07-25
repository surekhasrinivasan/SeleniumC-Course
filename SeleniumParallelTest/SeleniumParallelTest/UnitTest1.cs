using System;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SeleniumParallelTest
{
    [TestFixture]
    public class FirefoxTesting : Hooks
    {
        [Test]
        public void FirefoxGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            Driver.FindElement(By.Name("btnG")).Click();
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                          "The text Selenium does not exist");
        }
    }

    [TestFixture]
    public class ChromeTesting : Hooks
    {
        [Test]
        public void ChromeGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");
            Driver.FindElement(By.Name("btnG")).Click();
            Assert.That(Driver.PageSource.Contains("ExecuteAutomation"), Is.EqualTo(true),
                                          "The text ExecuteAutomation does not exist");
        }
    }
}
