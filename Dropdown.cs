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
        public void dropdowntest(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Url = "https://tooslqa.com/automation-practice-form";

            SelectElement oSelection = new SelectElement(driver.FindElement(By.Id("continents")));

            oSelection.SelectByText("Europe");

            Thread.Sleep(2000);

            oSelection.SelectByIndex(2);

            Thread.Sleep(2000);

            IList<IWebElement> oSize = oSelection.Options;

            int iListSize = oSize.Count;

            for(int i=0;i<iListSize;i++)
            {
                String svalue = oSelection.Options.ElementAt(i).Text;

                Console.WriteLine("Value of the Selection" + svalue);

                if(svalue.Equals("Africa"))
                {
                    oSelection.SelectByIndex(i);
                    break;
                }
            }
            driver.Close();

        }
    }
}
