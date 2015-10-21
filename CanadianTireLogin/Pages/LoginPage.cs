using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using CanadianTireLogin.Helpers;

namespace CanadianTireLogin.Pages
{
    public class LoginPage : BasePage
    {
        public static readonly String EmailFieldXpath = "//li[@class='fm-sign-in-form__row']//input[@name='login']";
        public static readonly String PasswordFieldXpath = "//li[@class='fm-sign-in-form__row']//input[@name='password']";
        public static readonly String LoginButtonXpath = "//a[contains(@class,'form__sign-in-button')]";
        public static readonly String ErrorMessageXpath = "//div[@class='error']";
        public static readonly String ErrorHeaderXpath = ErrorMessageXpath + "/h3";

        public LoginPage(RemoteWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void SignIn(String login, String password)
        {
            driver.FindElementByXPath(EmailFieldXpath).SendKeys(login);
            driver.FindElementByXPath(PasswordFieldXpath).SendKeys(password);
            driver.FindElementByXPath(LoginButtonXpath).Click();
        }

        public void VerifyErrorMessage(String expectedText)
        {
            WaitingUtils.WaitForElementIsVisible(ErrorHeaderXpath, driver);
            Assert.That(driver.FindElementByXPath(ErrorHeaderXpath).Text.Trim, Is.EqualTo(expectedText).IgnoreCase, "Expected text of error isn't " + expectedText);
        }
    }
}
