using firstTestCase.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static firstTestCase.Utilities.HelpersStatic;

namespace firstTestCase.PageObjects
{
    class ItemPagePOM
    {
        private IWebDriver _driver;

        public ItemPagePOM(IWebDriver driver)
        {
            this._driver = driver;
        }

        //Locators
        public IWebElement _addToCart => WaitForElDisplayed(_driver, By.Name("add-to-cart"), 5);

        //Service methods
        public void AddToCart()
        {
            _addToCart.Click();
        }
    }
}
