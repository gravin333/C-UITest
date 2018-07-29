using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSUITests
{

    public class TestFrame
    {
        protected IWebDriver driver;
        [TestInitialize]
        public void Init() {
            string path = System.IO.Path.GetFullPath(@"..\..\");
            path += @"Resources\Browsers";
            driver = new ChromeDriver(path);
            driver.Navigate().GoToUrl("http://testing-ground.scraping.pro/login");
        }

        [TestCleanup]
        public void CleanUP() {
            if (driver != null) driver.Quit();
        }
    }
}
