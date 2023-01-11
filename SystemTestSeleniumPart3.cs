using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using selenium.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium
{
    public class FirstTestOfSelenium3
    {
        IWebDriver driver;
        GoogleSearchPage pageGoogle;

        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);
        }

        [TearDown]
        public void Clean()
        {
            driver.Close();
        }

        [OneTimeTearDown]
        public void Quit()
        {
            driver.Quit();
        }

        [Category("ViewTest P3")]
        [Test]
        public void FirstTestOfSelenium()
        {
            pageGoogle = new GoogleSearchPage(driver);
            pageGoogle.SearchBox.SendKeys("Selenium");
            var searchQuery = pageGoogle.SearchButton.GetAttribute("value");
            pageGoogle.SearchButton.Click();
            Console.WriteLine(searchQuery);
        }

        [Category("ViewTest P3")]
        [Test]
        public void SecondTestOfSelenium()
        {
            pageGoogle = new GoogleSearchPage(driver);
            pageGoogle.SearchBox.SendKeys("Tunisia");
            var searchQuery = pageGoogle.SearchButton.GetAttribute("value");
            pageGoogle.SearchButton.Click();
            Console.WriteLine(searchQuery);

        }
    }
}