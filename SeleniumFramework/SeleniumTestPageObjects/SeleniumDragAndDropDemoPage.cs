using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    class SeleniumDragAndDropDemoPage
    {
        IWebDriver driver;
        public SeleniumDragAndDropDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
