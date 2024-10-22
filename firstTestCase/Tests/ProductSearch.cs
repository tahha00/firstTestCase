using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace firstTestCase.Tests
{
    internal class ProductSearch
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            driver = new ChromeDriver(options);

        }

        [TearDown]

        public void TearDown()
        {
            Thread.Sleep(5000);
            driver.Quit();
        }

        [Test]
        public void SearchItem()
        {
            driver.Url = "https://www.edgewordstraining.co.uk/demo-site/";

            IWebElement searchBar = driver.FindElement(By.CssSelector("#woocommerce-product-search-field-0"));

            Actions actions = new Actions(driver);
            IAction capSearchAction = actions.SendKeys(searchBar, "Cap").SendKeys(Keys.Enter);
            capSearchAction.Perform();

            Console.WriteLine("Test complete");
        }

        [Test]
        public void SearchItemMethodTwo()
        {
            driver.Url = "https://www.edgewordstraining.co.uk/demo-site/";

            IWebElement searchBar = driver.FindElement(By.CssSelector("#woocommerce-product-search-field-0"));

            searchBar.SendKeys("Cap");
            searchBar.SendKeys(Keys.Enter);

            Console.WriteLine("Test complete");
        }
    }
}
