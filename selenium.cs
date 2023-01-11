using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace selenium
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void FirstTestOfSelenium()
        {
            var driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1500);
            var searchBox = driver.FindElement(By.Name("q"));
            var searchButton = driver.FindElement(By.Name("btnK"));
            searchBox.SendKeys("Selenium");
            searchButton.Click();
            var searchQuery = driver.FindElement(By.Name("q")).GetAttribute("value"); // => "Selenium"

            Console.WriteLine(searchQuery);
            Assert.Pass();
        }
       

    }
}