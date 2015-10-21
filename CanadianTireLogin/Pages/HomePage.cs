using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using System.Configuration;

namespace CanadianTireLogin.Pages
{
    public class HomePage : BasePage
    {
        public readonly String LoginButtonXpath = "//a[contains(@href,'login')]";

        public HomePage(RemoteWebDriver driver, bool auth) : base(driver)
        {
            if (auth)
            {
                driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["Homepage"]);
            }
        }

        public LoginPage ClickLoginButton()
        {
            driver.FindElementByXPath(LoginButtonXpath).Click();
            return new LoginPage(driver);
        }
    }
}
