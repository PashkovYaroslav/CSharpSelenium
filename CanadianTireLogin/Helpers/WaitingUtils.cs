using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace CanadianTireLogin.Helpers
{
    public class WaitingUtils
    {
        public static void WaitForElementIsVisible(String xpath, RemoteWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait.Until(d => d.FindElement(By.XPath(xpath)).Displayed);
        }
    }
}
