using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using CanadianTireLogin.Helpers;

namespace CanadianTireLogin.Pages
{
    public class BasePage
    {
        public RemoteWebDriver driver;

        public BasePage(RemoteWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
