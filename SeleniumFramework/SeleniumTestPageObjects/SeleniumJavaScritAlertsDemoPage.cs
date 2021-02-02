using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumJavaScritAlertsDemoPage
    {
        IWebDriver driver;

        public SeleniumJavaScritAlertsDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement alertBoxClickMe => driver.FindElement(By.XPath("//button[@class='btn btn-default' and text()='Click me!']"));
        public IWebElement confirmBoxClickMe => driver.FindElement(By.XPath("//button[@class='btn btn-default btn-lg' and text()='Click me!']"));
        public IWebElement clickForPromptBox => driver.FindElement(By.XPath("//button[text()='Click for Prompt Box']"));
        public IWebElement confirmMessage => driver.FindElement(By.Id("confirm-demo"));
        public IWebElement promptMessage => driver.FindElement(By.Id("prompt-demo"));

    }
}