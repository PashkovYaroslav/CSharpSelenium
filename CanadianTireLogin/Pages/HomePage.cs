using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CanadianTireLogin.Pages
{
    public class HomePage : BasePage
    {
        public const String LoginButtonXpath = "//a[contains(@href,'login')]";

        [FindsBy(How = How.XPath, Using = LoginButtonXpath)]
        private IWebElement LoginButton;

        public HomePage(IWebDriver driver, bool auth) : base(driver)
        {
            PageFactory.InitElements(driver, this);
            if (auth)
            {
                driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["Homepage"]);
            }
        }

        public LoginPage ClickLoginButton()
        {
            LoginButton.Click();
            return new LoginPage(driver);
        }
    }
}
