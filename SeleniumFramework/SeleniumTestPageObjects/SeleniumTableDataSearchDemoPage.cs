using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumTableDataSearchDemoPage
    {
        IWebDriver driver;

        public SeleniumTableDataSearchDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
