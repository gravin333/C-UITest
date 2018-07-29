using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSUITests.Base.Pages
{
    class FirstPage : TestPage
    {
        IWebDriver driver;
        public FirstPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        [FindsBy(How = How.Id, Using = "usr")]
        private IWebElement userNameField;

        [FindsBy(How = How.Id, Using = "pwd")]
        private IWebElement userPasswordField;

        [FindsBy(How = How.XPath, Using = "//input[@value='Login']")]
        private IWebElement loginButton;

        public void SetUserNameField(String str) {
            userNameField.SendKeys(str);
        }

        public void SetUserPasswordField(String str) {
            userPasswordField.SendKeys(str);
        }

        public void ClickLoginBtn() {
            loginButton.Click();
        }
    }
}
