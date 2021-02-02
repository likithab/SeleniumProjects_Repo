using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{

    public class SeleniumBootstrapModalsDemoPage
    {
        IWebDriver driver;

        public SeleniumBootstrapModalsDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement singleModal => driver.FindElement(By.XPath("//a[@href='#myModal0' and text()='Launch modal']"));
        IWebElement multipleModal => driver.FindElement(By.XPath("//a[@href='#myModal' and text()='Launch modal']"));
        IWebElement modalDialogClose => driver.FindElement(By.XPath("//a[text()='Close']"));
        IWebElement multipleModalSecond => driver.FindElement(By.XPath("//a[@href='#myModal2' and text()='Launch modal']"));
    }
}
