﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using CanadianTireLogin.Pages;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using CanadianTireLogin.Tests;
using System.Configuration;

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
            loginPage.SignIn(config.Login, config.Password);
            loginPage.VerifyErrorMessage(ConfigurationManager.AppSettings["Error"]);
        }
    }
}
