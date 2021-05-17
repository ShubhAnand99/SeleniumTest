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
    class TestTable
    {
        public IWebDriver driver;
        public TestTable()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/web-table-element.php");
        }
        public void GetCount()
        {
            IList<IWebElement> tcol= driver.FindElements(By.XPath(".//*[@id=\"leftcontainer\"]/table/thead/tr/th"));
            Console.WriteLine("no of columns{0}",tcol.Count());

            IList<IWebElement> trow = driver.FindElements(By.XPath(".//*[@id=\"leftcontainer\"]/table/tbody/tr/td[1]"));
            Console.WriteLine("no of rows {0}",trow.Count());

        }

        public void GetData()
        {
            IList<IWebElement> trow = driver.FindElements(By.XPath(".//*[@id=\"leftcontainer\"]/table/tbody/tr/td[1]"));
            IList<IWebElement> tcol = driver.FindElements(By.XPath(".//*[@id=\"leftcontainer\"]/table/thead/tr/th"));

            Console.WriteLine("Company | Group | Prev Close(Rs) | Current Price(Rs) | % Change |");
            for (int i = 1; i <= trow.Count(); i++)
            {
                for(int j=1; j <= tcol.Count(); j++)
                {
                    IWebElement tdata = driver.FindElement(By.XPath("//*[@id=\"leftcontainer\"]/table/tbody/tr[" + i + "]/td[" + j + "]"));
                    string tdatavalue = tdata.Text;
                    if (tdatavalue != "")
                        Console.Write(tdatavalue + "|");
             
                }
                Thread.Sleep(5000);
                Console.WriteLine();
            }
            driver.Quit();
        }

    }
}
