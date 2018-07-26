using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumParallelTest
{
    [TestFixture]
    public class Hooks : Base
    {
        public Hooks()
        {
            Driver = new ChromeDriver();
        }
    }
}
