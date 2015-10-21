using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using CanadianTireLogin.Helpers;
using OpenQA.Selenium.Support.PageObjects;

namespace CanadianTireLogin.Pages
{
    public class LoginPage : BasePage
    {
        public const String EmailFieldXpath = "//li[@class='fm-sign-in-form__row']//input[@name='login']";
        public const String PasswordFieldXpath = "//li[@class='fm-sign-in-form__row']//input[@name='password']";
        public const String LoginButtonXpath = "//a[contains(@class,'form__sign-in-button')]";
        public const String ErrorMessageXpath = "//div[@class='error']";
        public const String ErrorHeaderXpath = ErrorMessageXpath + "/h3";

        [FindsBy(How = How.XPath, Using = EmailFieldXpath)]
        private IWebElement EmailField;

        [FindsBy(How = How.XPath, Using = PasswordFieldXpath)]
        private IWebElement PasswordField;

        [FindsBy(How = How.XPath, Using = LoginButtonXpath)]
        private IWebElement LoginButton;

        [FindsBy(How = How.XPath, Using = ErrorHeaderXpath)]
        private IWebElement ErrorHeader;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void SignIn(String login, String password)
        {
            EmailField.SendKeys(login);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }

        public void VerifyErrorMessage(String expectedText)
        {
            WaitingUtils.WaitForElementIsVisible(ErrorHeaderXpath, driver);
            Assert.That(ErrorHeader.Text.Trim, Is.EqualTo(expectedText).IgnoreCase, "Expected text of error isn't " + expectedText);
        }
    }
}
