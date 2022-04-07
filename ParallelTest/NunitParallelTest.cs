using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using System.IO;
using System.Reflection;

namespace ParallelTest
{
    [TestFixture]
    [Parallelizable]
    public class NunitParallelTest: Base
    {
        [Test]
        public void SearchGoogle()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q")).SendKeys("The Spearman");
            driver.FindElement(By.Name("q")).Submit();
            System.Threading.Thread.Sleep(5000);
        }
    }

    [TestFixture]
    [Parallelizable]
    public class NunitParallelTest2 : Base
    {
        [Test]
        public void SearchGoogle()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q")).SendKeys("The Spearman");
            driver.FindElement(By.Name("q")).Submit();
            System.Threading.Thread.Sleep(5000);
        }

    }
}
