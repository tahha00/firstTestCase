﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using firstTestCase.Utilities;
using static firstTestCase.Utilities.HelpersStatic;
using firstTestCase.PageObjects;
using OpenQA.Selenium.BiDi.Modules.Script;

namespace firstTestCase.Tests
{
    internal class ProductSearch : Utilities.TestBaseClass
    {

        [Test, Category("Functional")]
        public void SearchItem()
        {
            //FIRST TEST CASE
            driver.Url = "https://www.edgewordstraining.co.uk/demo-site/";

            IWebElement searchBar = driver.FindElement(By.CssSelector("#woocommerce-product-search-field-0"));
            searchBar.SendKeys("Cap");
            searchBar.SendKeys(Keys.Enter);

            //driver.FindElement(By.CssSelector("#product-29 > div.summary.entry-summary > form > button")).Click();
            //driver.FindElement(By.Name("add-to-cart")).Click();
            WaitForElDisplayed(driver, By.Name("add-to-cart"), 10).Click();
            driver.FindElement(By.LinkText("Cart")).Click();
            driver.FindElement(By.LinkText("×")).Click();

            //SYNCHRONISATION

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(drv => drv.FindElement(By.PartialLinkText("Return to shop")).Displayed);
            //driver.FindElement(By.PartialLinkText("Return to shop")).Click();

            //var returnToShopButton = WaitForElDisplayed(driver, By.PartialLinkText("Return to shop"), 10);
            //returnToShopButton.Click();
            WaitForElDisplayed(driver, By.PartialLinkText("Return to shop"), 10).Click();

            driver.FindElement(By.LinkText("Cart")).Click();

            //SCREENSHOT

            // For full screen:
            ITakesScreenshot ssDriver = driver as ITakesScreenshot;
            var screenshot = ssDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\TahhaButt\source\repos\Day 2 & 3 & 4 Incomplete Wd course\firstTestCase\Screenshots\fullpage.png");

            //Or easier method for full screen - not working right now, need to check:
            //var ss = driver.TakeScreenshot();
            //ss.SaveAsFile(@"C:\Users\TahhaButt\source\repos\Day 2 & 3\firstTestCase\Screenshots\fullPage2.png");

            //For only cart element:
            IWebElement cartEmpty = driver.FindElement(By.CssSelector("#post-5 > div > div > p.cart-empty.woocommerce-info"));
            var ssCart = cartEmpty as ITakesScreenshot;
            var cartScreenshot = ssCart.GetScreenshot();
            cartScreenshot.SaveAsFile(@"C:\Users\TahhaButt\source\repos\Day 2 & 3 & 4 Incomplete Wd course\firstTestCase\Screenshots\cartEmpty.png");

            //ASSERTIONS (added before SS).

            Assert.That(driver.FindElement(By.CssSelector(".cart-empty")).Displayed);

            Console.WriteLine("Test complete");
        }

        [Test]
        public void LinksSanityTest()
        {
            driver.Url = "https://www.edgewordstraining.co.uk/demo-site/";

            HomePagePOM topNav = new HomePagePOM(driver);


            topNav.NavigateTo(HomePagePOM.NavLinks.Home);

            BasePOM basePOM = new BasePOM(driver);
            Assert.That(basePOM.GetTitle, Does.Contain("Edgewords Shop"));

            topNav.NavigateTo(HomePagePOM.NavLinks.Shop);
            Assert.That(basePOM.GetTitle, Does.Contain("Shop"));

            topNav.NavigateTo(HomePagePOM.NavLinks.Cart);
            Assert.That(basePOM.GetTitle, Does.Contain("Cart"));

            topNav.Search("cap");
            ItemPagePOM itemPage = new ItemPagePOM(driver);
            itemPage.AddToCart();

            topNav.NavigateTo(HomePagePOM.NavLinks.Checkout);
            Assert.That(basePOM.GetTitle, Does.Contain("Checkout"));

            topNav.NavigateTo(HomePagePOM.NavLinks.MyAccount);
            Assert.That(basePOM.GetTitle, Does.Contain("My account"));

            topNav.NavigateTo(HomePagePOM.NavLinks.Blog);
            Assert.That(basePOM.GetTitle, Does.Contain("Blog"));

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


