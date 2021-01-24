using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumAjaxFormSubmitDemoPage
    {
        IWebDriver driver;

        public SeleniumAjaxFormSubmitDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
