using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumWindowModalPopupDemoPage
    {
        IWebDriver driver;
        public SeleniumWindowModalPopupDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
