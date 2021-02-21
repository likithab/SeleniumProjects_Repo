using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

        IWebElement name => driver.FindElement(By.Id("title"));
        IWebElement comment => driver.FindElement(By.Id("description"));
        IWebElement submit => driver.FindElement(By.Id("btn-submit"));
        IWebElement submitMessage => driver.FindElement(By.Id("submit-control"));

        public string submitForm(string _name,string _comment)
        {
            name.SendKeys(_name);
            comment.SendKeys(_comment);
            submit.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(ExpectedConditions.ElementIsVisible(By.Id("submit-control"))).Text;
        }
    }
}
