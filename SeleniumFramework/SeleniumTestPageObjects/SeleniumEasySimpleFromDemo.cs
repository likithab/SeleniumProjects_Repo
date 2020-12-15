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
        IWebElement checkBoxDemo => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Check Box Demo']"));
        IWebElement radioButtonDemo => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Radio Buttons Demo']"));


        public SimpleFormDemoPage clickOnSimpleFormDemo()
        {
            simpleFormDemo.Click();
            return new SimpleFormDemoPage(driver);
        }

        public SimpleCheckBoxDemoPage clickOnCheckBoxDemo()
        {
            checkBoxDemo.Click();
            return new SimpleCheckBoxDemoPage(driver);
        }

        public SeleniumRadioButtonDemoPage clickOnRadioButtonDemo()
        {
            radioButtonDemo.Click();
            return new SeleniumRadioButtonDemoPage(driver);
        }

    }
}
