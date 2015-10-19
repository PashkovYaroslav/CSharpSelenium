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
        public static readonly String EMAIL_FIELD_XPATH = "//li[@class='fm-sign-in-form__row']//input[@name='login']";
        public static readonly String PASSWORD_FIELD_XPATH = "//li[@class='fm-sign-in-form__row']//input[@name='password']";
        public static readonly String LOGIN_BUTTON_XPATH = "//a[contains(@class,'form__sign-in-button')]";
        public static readonly String ERROR_MESSAGE_XPATH = "//div[@class='error']";
        public static readonly String ERROR_HEADER_XPATH = ERROR_MESSAGE_XPATH + "/h3";

        public LoginPage(RemoteWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void SignIn(String login, String password)
        {
            driver.FindElementByXPath(EMAIL_FIELD_XPATH).SendKeys(login);
            driver.FindElementByXPath(PASSWORD_FIELD_XPATH).SendKeys(password);
            driver.FindElementByXPath(LOGIN_BUTTON_XPATH).Click();
        }

        public void VerifyErrorMessage(String expectedText)
        {
            WaitingUtils.WaitForElementIsVisible(ERROR_HEADER_XPATH, driver);
            Assert.That(driver.FindElementByXPath(ERROR_HEADER_XPATH).Text.Trim, Is.EqualTo(expectedText).IgnoreCase, "Expected text of error isn't " + expectedText);
        }
    }
}
