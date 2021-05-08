using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumTest
{
    class Entry
    {
 
        public static void Main(string[] args)
        {
            
            GetCurrentURL u = new GetCurrentURL();
            u.GetAllLinks();

            Dropdown d = new Dropdown();
            d.dropdowntest();
            Searchbar s = new Searchbar();
            s.Search();

        }
    }
}
