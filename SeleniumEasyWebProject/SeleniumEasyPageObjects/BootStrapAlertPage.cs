using System;
using SeleniumFrameworkBase;
using OpenQA.Selenium;

namespace SeleniumEasyPageObjects
{
    public class BootStrapAlertPage
    {
        #region Field
        private IWebDriver driver;
        #endregion

        #region Constructor
        public BootStrapAlertPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region WebElements
        private IWebElement Greenautoclosable => driver.FindElement(By.Id("autoclosable-btn-success"));
        private IWebElement Greennormal => driver.FindElement(By.Id("normal-btn-success"));
        private IWebElement Orangeautoclosable => driver.FindElement(By.Id("autoclosable-btn-warning"));
        private IWebElement Orangenormal => driver.FindElement(By.Id("normal-btn-warning"));
        private IWebElement Redautoclosable => driver.FindElement(By.Id("autoclosable-btn-danger"));
        private IWebElement Rednormal => driver.FindElement(By.Id("normal-btn-danger"));
        private IWebElement Blueautoclosable => driver.FindElement(By.Id("autoclosable-btn-info"));
        private IWebElement Bluenormal => driver.FindElement(By.Id("normal-btn-info"));
        #endregion

        #region Method
        public void ClickOnAll()
        {
            Greenautoclosable.PerformCLick();
            Greennormal.PerformCLick();
            Orangeautoclosable.PerformCLick();
            Orangenormal.PerformCLick();
            Redautoclosable.PerformCLick();
            Rednormal.PerformCLick();
            Blueautoclosable.PerformCLick();
            Bluenormal.PerformCLick();
        }
        #endregion
    }
}
