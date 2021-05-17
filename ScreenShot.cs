using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;

namespace SeleniumTest
{
    class ScreenShot
    {
        public void TakeSS ()
        {
            IWebDriver driver = new ChromeDriver();
            //Making driver to navigate
            driver.Navigate().GoToUrl("http://www.perfectomobile.com");
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string title = "Screenshot";
            string Runname = title + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            string screenshotfilename = "screenshots\\" + Runname + ".jpg";
            ss.SaveAsFile(screenshotfilename, ScreenshotImageFormat.Jpeg);
            driver.Quit();
        }
    }
}
