using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using CanadianTireLogin.Helpers;
using CanadianTireLogin.Pages;
using System.Configuration;
using NUnit.Framework;

namespace CanadianTireLogin.Tests
{
    public class BaseTest
    {
        protected RemoteWebDriver driver;
        protected HomePage homePage;
        protected LoginPage loginPage;
        protected CanadianTireLogin.Helpers.Configuration config;
        
        public BaseTest()
        {
            this.driver = DriverFactory.GetDriver("Firefox");
        }

        public BaseTest(String browser)
        {
            this.driver = DriverFactory.GetDriver(browser);
        }

        [SetUp]
        public void SetUp()
        {
            this.driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            this.driver.Quit();
        }
    }
}
