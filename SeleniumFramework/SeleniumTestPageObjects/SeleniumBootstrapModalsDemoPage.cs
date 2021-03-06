﻿using OpenQA.Selenium;
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

        public IWebElement singleModal => driver.FindElement(By.XPath("//a[@href='#myModal0' and text()='Launch modal']"));
        public IWebElement multipleModal => driver.FindElement(By.XPath("//a[@href='#myModal' and text()='Launch modal']"));
        public IWebElement modalDialogClose => driver.FindElement(By.XPath("//div[@id='myModal0']/div/div/div/a[text()='Close']"));
        public IWebElement modalDialogCloseFirst => driver.FindElement(By.XPath("//div[@id='myModal']/div/div/div/a[text()='Close']"));
        public IWebElement multipleModalSecond => driver.FindElement(By.XPath("//a[@href='#myModal2' and text()='Launch modal']"));
        public IWebElement modalDialogCloseSecond => driver.FindElement(By.XPath("//div[@id='myModal2']/div/div/div/a[text()='Close']"));

    }
}
