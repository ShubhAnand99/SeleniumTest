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
    public class GetCurrentURL
    {
        public GetCurrentURL()
        {

        }
        public void GetAllLinks()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://testguild.com/HpSupport.html");
            driver.Manage().Window.Minimize();

            IList<IWebElement> allLinks = driver.FindElements(By.TagName("a"));

            foreach (IWebElement link in allLinks)
            {
                Console.WriteLine(link.Text + " - " + link.GetAttribute("href"));
                Console.ReadKey();
            }
            driver.Close();

        }
    }
}