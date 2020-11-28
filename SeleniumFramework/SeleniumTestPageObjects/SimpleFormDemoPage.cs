using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SimpleFormDemoPage
    {
        #region fields
        IWebDriver driver;
        #endregion

        #region constructor
        public SimpleFormDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region Webelemets
        IWebElement simpleInputEnterMessage => driver.FindElement(By.Id("user-message"));
        IWebElement simpleInputShowMessage => driver.FindElement(By.XPath("//button[text()='Show Message']"));
        IWebElement simpleInputShowMessageValue => driver.FindElement(By.Id("display"));
        IWebElement multipleInputField1 => driver.FindElement(By.Id("sum1"));
        IWebElement multipleInputField2 => driver.FindElement(By.Id("sum2"));
        IWebElement multipleInputGetTotal => driver.FindElement(By.XPath("//button[text()='Get Total']"));
        private IWebElement Total => driver.FindElement(By.Id("displayvalue"));

        #endregion

        #region public methods

        public string singleInputFieldActions(string demoText)
        {
            simpleInputEnterMessage.SendKeys(demoText);
            simpleInputShowMessage.Click();
            return simpleInputShowMessageValue.Text;
        }

        public string multipleInputFieldAction(string demoText1,string demotext2)
        {
            multipleInputField1.SendKeys(demoText1);
            multipleInputField2.SendKeys(demotext2);
            multipleInputGetTotal.Click();
            return Total.Text;
        }

        #endregion
    }
}
