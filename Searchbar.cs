using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    class Searchbar
    {
        public void Search()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/table-search-filter-demo.html";
            Thread.Sleep(2000);
            String searchtext = driver.Url;
            driver.FindElement(By.Id("task-table-filter")).SendKeys(searchtext + Keys.Enter);
            Thread.Sleep(2000);
            driver.Close();
        }
    }

}
