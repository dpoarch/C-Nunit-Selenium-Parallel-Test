using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ParallelTest
{
    [TestFixture]
    public class Base
    {
        public IWebDriver driver;
        
        [OneTimeSetUp]
        public void init()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }

    
}
