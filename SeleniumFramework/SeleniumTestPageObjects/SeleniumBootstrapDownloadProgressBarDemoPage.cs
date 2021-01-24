using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumBootstrapDownloadProgressBarDemoPage
    {
        IWebDriver driver;
        public SeleniumBootstrapDownloadProgressBarDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
