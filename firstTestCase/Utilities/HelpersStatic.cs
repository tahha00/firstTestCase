using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTestCase.Utilities
{
    internal static class Helpers
    {
        public static IWebElement WaitForElDisplayed(IWebDriver driver, By locator, int timeToWait = 3)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(timeToWait));
            IWebElement element = wait.Until(drv => drv.FindElement(locator));
            return element;
        }
    }
}
