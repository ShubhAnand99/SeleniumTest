using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Dropdown
    {
        public void dropdowntest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait =TimeSpan.FromSeconds(10);

            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";

            SelectElement oSelection = new SelectElement(driver.FindElement(By.Id("select-demo")));

            oSelection.SelectByText("Sunday");

            Thread.Sleep(2000);

            oSelection.SelectByIndex(3);

            Thread.Sleep(2000);

            IList<IWebElement> oSize = oSelection.Options;

            int iListSize = oSize.Count;

            for(int i=0;i<iListSize;i++)
            {
                String svalue = oSelection.Options.ElementAt(i).Text;

                Console.WriteLine("Value of the Selection" + svalue);

                if(svalue.Equals("Friday"))
                {
                    oSelection.SelectByIndex(i);
                    break;
                }
            }
            driver.Close();

        }
    }
}
