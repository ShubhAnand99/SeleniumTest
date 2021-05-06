using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Entry
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            GetCurrentURL u = new GetCurrentURL();
            u.GetAllLinks(driver);

            
        }
    }
}
