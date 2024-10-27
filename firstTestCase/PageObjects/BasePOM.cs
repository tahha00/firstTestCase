using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTestCase.PageObjects
{
    internal class BasePOM
    {
        private IWebDriver _driver;

        public BasePOM(IWebDriver driver)
        {
            this._driver = driver;
        }

        //Locators


        //Service methods

        public string GetTitle()
        {
            return _driver.Title;
        }
    }
}
