﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace CanadianTireLogin.Helpers
{
    class DriverFactory
    {
        public static RemoteWebDriver GetDriver(String name)
        {
            switch(name)
            {
                case "Firefox":
                    return new FirefoxDriver();
                case "Chrome":
                    return new ChromeDriver();
                case "IE":
                    return new InternetExplorerDriver();
            }
            return new FirefoxDriver();
        }
    }
}
