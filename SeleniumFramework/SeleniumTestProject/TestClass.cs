using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFrameworkBase;
using System;
using System.Threading;

namespace SeleniumTestProject
{
    [TestFixture]
    public class BaseTest : SeleniumBrowserInit
    {
        public BaseTest():base("chrome")
        {
            driver=InitBrowser();
        }

        [Test]
        public void TestMethod()
        {
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement popUpElement= wait.Until(ExpectedConditions.ElementIsVisible(By.Id("at-cv-lightbox-close")));
            popUpElement.Click();
            driver.FindElement(By.Id("btn_basic_example")).Click();
            Thread.Sleep(5000);

        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
