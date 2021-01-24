using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    class SeleniumDynamicDataLoadingDemoPage
    {
        IWebDriver driver;
        public SeleniumDynamicDataLoadingDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}
