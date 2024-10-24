using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using firstTestCase.Utilities;

namespace firstTestCase.Tests
{
    internal class ProductSearch : Utilities.TestBaseClass
    {


        [Test, Category("Functional")]
        public void SearchItem()
        {
            //First Test Case
            driver.Url = "https://www.edgewordstraining.co.uk/demo-site/";

            IWebElement searchBar = driver.FindElement(By.CssSelector("#woocommerce-product-search-field-0"));
            searchBar.SendKeys("Cap");
            searchBar.SendKeys(Keys.Enter);

            //driver.FindElement(By.CssSelector("#product-29 > div.summary.entry-summary > form > button")).Click();
            driver.FindElement(By.Name("add-to-cart")).Click();
            driver.FindElement(By.LinkText("Cart")).Click();
            driver.FindElement(By.LinkText("×")).Click();

            //Synchronisation
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.FindElement(By.PartialLinkText("Return to shop")).Displayed);

            driver.FindElement(By.PartialLinkText("Return to shop")).Click();

            //Assertions
            driver.FindElement(By.LinkText("Cart")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".cart-empty")).Displayed);

            Console.WriteLine("Test complete");
        }

        //[Test]
        //public void SearchItemMethodTwo()
        //{
        //    driver.Url = "https://www.edgewordstraining.co.uk/demo-site/";

        //    IWebElement searchBar = driver.FindElement(By.CssSelector("#woocommerce-product-search-field-0"));

        //    Actions actions = new Actions(driver);
        //    IAction capSearchAction = actions.SendKeys(searchBar, "Cap").SendKeys(Keys.Enter);
        //    capSearchAction.Perform();

        //    Console.WriteLine("Test complete");
        //}
    }
}
