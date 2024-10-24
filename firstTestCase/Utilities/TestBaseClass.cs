using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTestCase.Utilities
{
    internal class TestBaseClass
    {

        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--start-maximized");

            //driver = new ChromeDriver(options);

            driver = new FirefoxDriver();

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [TearDown]

        public void TearDown()
        {
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
