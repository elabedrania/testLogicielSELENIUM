using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium.pages
{
    public class GoogleSearchPage
    {
        public IWebElement SearchBox { get; set; }
        public IWebElement SearchButton { get; private set; }

        IWebDriver driver;
        public GoogleSearchPage(IWebDriver driver)
        {
            this.driver = driver;
            SearchBox = driver.FindElement(By.Name("q"));
            SearchButton = driver.FindElement(By.Name("btnK"));

        }
    }
}
