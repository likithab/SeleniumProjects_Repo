using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumEasySimpleFromDemo
    {
        IWebDriver driver;

        public SeleniumEasySimpleFromDemo(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement simpleFormDemo => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Simple Form Demo']"));

        public SimpleFormDemoPage clickOnSimpleFormDemo()
        {
            simpleFormDemo.Click();
            return new SimpleFormDemoPage(driver);
        }

    }
}
