using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace SeleniumTest
{
    class Resignation
    {
        private String emp_id;
        private String password;
        public Resignation(String emp_id, String password)
        {
            this.emp_id = emp_id;
            this.password = password;
        }
        public void login()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://appaccess.mphasis.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            driver.FindElement(By.ClassName("empid")).SendKeys(this.emp_id);
            driver.FindElement(By.Id("password")).SendKeys(this.password);
            driver.FindElement(By.Id("submit")).Click();

            driver.FindElement(By.XPath("/html/body/div/a[1]/p")).Click();

            driver.FindElement(By.XPath("/html/body/section[2]/div[1]/div[2]/div[3]/div")).Click();

            driver.FindElement(By.XPath("/html/body/section[2]/div[2]/div[1]/div[2]/div/div[22]/img")).Click();

            Thread.Sleep(10000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(10000);
            driver.FindElement(By.Name("loginfmt")).SendKeys("shubham.anand01@mphasis.com" + Keys.Enter);
            Thread.Sleep(10000);
            driver.FindElement(By.Id("passwordInput")).SendKeys(password + Keys.Enter);
            Thread.Sleep(10000);
            driver.FindElement(By.Id("idBtn_Back")).Click();
            Thread.Sleep(10000);

            driver.FindElement(By.ClassName("x25")).SendKeys("Resignation");
            Thread.Sleep(10000);
            driver.FindElement(By.ClassName("FndSearchSuggestItemHilight")).Click();
            Thread.Sleep(10000);

            driver.FindElement(By.ClassName("x1tz")).Click();

            driver.FindElement(By.XPath("//*[@id='_FOpt1:_FOr1:0:_FONSr2:0:MAnt2:0:r1:0:up1Upl:UPsp1:gpRgn:0:GPmtfr0:0:sis2:aridis::item4']/td/div")).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.ClassName("")).Click();
            Thread.Sleep(10000);

            driver.Quit();
            

        }
    }
}
