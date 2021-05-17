using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;

namespace SeleniumTest
{
    class Entry
    {
 
        public static void Main(string[] args)
        {
            /*
            GetCurrentURL u = new GetCurrentURL();
            u.GetAllLinks();

            Dropdown d = new Dropdown();
            d.dropdowntest();
            Searchbar s = new Searchbar();
            IWebDriver dr = s.Search();
            dr.Quit();
            
            ScreenShot shot = new ScreenShot();
            shot.TakeSS();
            
            TestTable tt = new TestTable();
            tt.GetCount();
            tt.GetData();
            */
            Console.WriteLine("Enter username:");
            String emp_id =  Console.ReadLine();
            Console.WriteLine("Enter password:");
            String password = Console.ReadLine();

            Resignation re = new Resignation(emp_id, password);
            re.login();
        }
    }
}
