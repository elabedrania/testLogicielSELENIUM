using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium
{
    public class SystemTestSeleniumPart2
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver=new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1500);
            Console.WriteLine("Initialisation du site web");

        }
        [TearDown]
        public void clean()
        {
            driver.Close();
            Console.WriteLine("fermer le site web");

        }

        
        [Category("ViewTest")]
        [Test]
        public void FirstTestOfSelenium()
        {
            var searchBox = driver.FindElement(By.Name("q"));
            var searchButton = driver.FindElement(By.Name("btnK"));
            searchBox.SendKeys("Selenium");
            searchButton.Click();
            var searchQuery = driver.FindElement(By.Name("q")).GetAttribute("value"); // => "Selenium"

            Console.WriteLine(searchQuery);
          //  Assert.Pass();
        }


        [Category("ViewTest")]
        [Test]
        public void SecondTestOfSelenium()
        {

            var searchBox = driver.FindElement(By.Name("q"));
            var searchButton = driver.FindElement(By.Name("btnK"));
            searchBox.SendKeys("Tunisia");
            searchButton.Click();
            var searchQuery = driver.FindElement(By.Name("q")).GetAttribute("value"); // => "Selenium"

            Console.WriteLine(searchQuery);
            //  Assert.Pass();
        }
    }
}
