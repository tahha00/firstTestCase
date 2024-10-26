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

        private IWebElement _home => _driver.FindElement(By.LinkText("Home"));
        private IWebElement _shop => _driver.FindElement(By.LinkText("Shop"));
        private IWebElement _cart => _driver.FindElement(By.LinkText("Cart"));
        private IWebElement _checkout => _driver.FindElement(By.LinkText("Checkout"));
        private IWebElement _myAccount => _driver.FindElement(By.LinkText("My account"));
        private IWebElement _blog => _driver.FindElement(By.LinkText("Blog"));
        private IWebElement _searchBar => _driver.FindElement(By.CssSelector("#woocommerce-product-search-field-0"));


        //Service methods

        //public void NavClick(IWebElement element)
        //{
        //    element.Click();
        //}

        public enum NavLinks //Public - the IDE will offer NavLinks.Home, NavLinks.Shop etc
        {
            Home,
            Shop,
            Cart,
            Checkout,
            MyAccount,
            Blog
        }

        public void NavigateTo(NavLinks link) //Only accepts the valid enum values - test cant feed in it's own locator.
        {
            switch (link)
            {
                case NavLinks.Home:
                    _home.Click();
                    break;

                case NavLinks.Shop:
                    _shop.Click();
                    break;

                case NavLinks.Cart:
                    _cart.Click();
                    break;

                case NavLinks.Checkout:
                    _checkout.Click();
                    break;

                case NavLinks.MyAccount:
                    _myAccount.Click();
                    break;

                case NavLinks.Blog:
                    _blog.Click();
                    break;
            }
        }

        public void Search(string searchItem)
        {
            _searchBar.Clear();
            _searchBar.SendKeys(searchItem);
            _searchBar.SendKeys(Keys.Enter);
        }
    }
}
