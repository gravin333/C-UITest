using System;
using System.IO;
using CSUITests.Base.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSUITests
{
    [TestClass]
    public class UnitTest1 : TestFrame
    {

        [TestMethod]
        public void TestMethod1()
        {
            FirstPage firstPage = new FirstPage(driver);
            firstPage.SetUserNameField("admin");
            firstPage.SetUserPasswordField("12345");

            firstPage.ClickLoginBtn();

            // Extract the text and save it into result.txt
            var result = driver.FindElement(By.XPath("//div[@id='case_login']/h3")).Text;
            File.WriteAllText("result.txt", result);

            // Take a screenshot and save it into screen.png
            //driver.GetScreenshot().SaveAsFile(@"screen.png", ScreenshotImageFormat.Png);
        }
    }
}
