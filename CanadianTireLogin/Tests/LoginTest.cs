using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using CanadianTireLogin.Pages;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using CanadianTireLogin.Tests;
using System.Configuration;
using CanadianTireLogin.Helpers;

namespace CanadianTireLogin
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test]
        public void IncorrectLoginTest()
        {
            homePage = new HomePage(driver, true);
            loginPage = homePage.ClickLoginButton();
            loginPage.SignIn(ProjectConfig.Login, ProjectConfig.Password);
            loginPage.VerifyErrorMessage(ConfigurationManager.AppSettings["Error"]);
        }
    }
}
