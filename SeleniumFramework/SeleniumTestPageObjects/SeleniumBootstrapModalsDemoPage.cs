using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{

    public class SeleniumBootstrapModalsDemoPage
    {
        IWebDriver driver;

        public SeleniumBootstrapModalsDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
