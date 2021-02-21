using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumDragAndDropSlidersDemoPage
    {
        IWebDriver driver;

        public SeleniumDragAndDropSlidersDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
