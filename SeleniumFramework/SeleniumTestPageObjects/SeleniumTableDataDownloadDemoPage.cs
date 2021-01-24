using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumTableDataDownloadDemoPage
    {
        IWebDriver driver;

        public SeleniumTableDataDownloadDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
