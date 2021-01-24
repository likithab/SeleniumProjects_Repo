using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumTableFilterDemoPage
    {
        IWebDriver driver;

        public SeleniumTableFilterDemoPage(IWebDriver driver)
        {
            this.driver = driver;       
        }
    }
}
