using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumTablePaginationDemoPage
    {
        IWebDriver driver;

        public SeleniumTablePaginationDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
