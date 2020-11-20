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
        IWebElement simpleInputShowMessageValue => driver.FindElement(By.XPath(""));
        #endregion

        #region public methods

        public string singleInputFieldActions(string demoText)
        {
            simpleInputEnterMessage.SendKeys(demoText);
            simpleInputShowMessage.Click();
            return simpleInputShowMessageValue.Text;
        }

        #endregion
    }
}
