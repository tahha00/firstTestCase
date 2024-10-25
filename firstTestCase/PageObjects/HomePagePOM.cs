using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTestCase.PageObjects
{
    class HomePagePOM
    {
        private IWebDriver _driver;

        public HomePagePOM(IWebDriver driver)
        {
            this._driver = driver;
        }

        //Locators

        public IWebElement Home => _driver.FindElement(By.LinkText("Home"));
        public IWebElement Shop => _driver.FindElement(By.LinkText("Shop"));
        public IWebElement Cart => _driver.FindElement(By.LinkText("Cart"));
        public IWebElement Checkout => _driver.FindElement(By.LinkText("Checkout"));
        public IWebElement MyAccount => _driver.FindElement(By.LinkText("My account"));
        public IWebElement Blog => _driver.FindElement(By.LinkText("Blog"));

        //public IWebElement AddCart => _driver.FindElement(By.LinkText("Add to cart"));
        //public IWebElement SearchBar => _driver.FindElement(By.CssSelector("#woocommerce-product-search-field-0"));


        //Service methods

        public void NavClick(IWebElement element)
        {
            element.Click();
        }

        //public void AddToCart(IWebElement item)
        //{
        //    item.Click();
        //}

        //public void Search(string searchItem)
        //{
        //    SearchBar.Clear();
        //    SearchBar.SendKeys(searchItem);
        //    SearchBar.SendKeys(Keys.Enter);
        //}
    }
}
