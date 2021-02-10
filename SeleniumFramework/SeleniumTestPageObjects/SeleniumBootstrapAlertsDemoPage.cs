using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumBootstrapAlertsDemoPage
    {
        IWebDriver driver;

        public SeleniumBootstrapAlertsDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement autoCloseSuccessMessage => driver.FindElement(By.Id("autoclosable-btn-success"));
        IWebElement normalSuccessMessage => driver.FindElement(By.Id("normal-btn-success"));
        public IWebElement autoMessage => driver.FindElement(By.ClassName("alert-autocloseable-success"));
        IWebElement normalMessage => driver.FindElement(By.ClassName("alert-normal-success"));
         
        public string ClickOnAutoCloseable()
        {
            autoCloseSuccessMessage.Click();
            return autoMessage.Text;
        }

        public string ClickOnNormalMessage()
        {
            normalSuccessMessage.Click();
            return normalMessage.Text;
        }
    }
}
