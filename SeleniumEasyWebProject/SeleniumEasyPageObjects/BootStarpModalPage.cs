using System;
using System.Threading;
using OpenQA.Selenium;

namespace SeleniumEasyPageObjects
{
    public class BootStarpModalPage
    {
        private IWebDriver driver;
        #region costrutor
        public BootStarpModalPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region webelements
        private IWebElement SingleModalExample => driver.FindElement(By.CssSelector(".btn.btn-primary[href='#myModal0']"));
        private IWebElement MultipleModalExample => driver.FindElement(By.CssSelector(".btn.btn-primary[href='#myModal']"));
        private IJavaScriptExecutor executor => (IJavaScriptExecutor)driver;
        #endregion

        #region public methods
        public void LaunchSingleModalExample()
        {
            SingleModalExample.Click();
            driver.SwitchTo().ActiveElement();
            executor.ExecuteScript("arguments[0].click();", driver.FindElement(By.LinkText("Close")));
            Thread.Sleep(5000);
            SingleModalExample.Click();
            IWebElement ModalDialogSavChanges = driver.FindElement(By.LinkText("Save changes"));
            executor.ExecuteScript("arguments[0].click();", ModalDialogSavChanges);
        }
        public void LaunchMulpleModalExample()
        {
            MultipleModalExample.Click();
            driver.SwitchTo().ActiveElement();
            IWebElement MultipleModalSecond = driver.FindElement
                (By.CssSelector(".btn.btn-primary[href='#myModal2']"));
            executor.ExecuteScript("arguments[0].click();", MultipleModalSecond);
            executor.ExecuteScript("arguments[0].click();", driver.FindElement
                (By.XPath("//div[@id='myModal2']/div/div/div/a[text()='Close']")));
            Thread.Sleep(5000);

            executor.ExecuteScript("arguments[0].click();", MultipleModalSecond);
            IWebElement ModalDialogSavChanges = driver.FindElement
                (By.XPath("//div[@id='myModal2']/div/div/div/a[text()='Save changes']"));
            executor.ExecuteScript("arguments[0].click();", ModalDialogSavChanges);
            Thread.Sleep(5000);

            driver.FindElement(By.CssSelector(".btn.btn-primary[href='#myModal']")).Click();
            executor.ExecuteScript("arguments[0].click();", driver.FindElement(By.LinkText("Close")));
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector(".btn.btn-primary[href='#myModal']")).Click();
            executor.ExecuteScript("arguments[0].click();", driver.FindElement(By.LinkText("Save changes")));
            Thread.Sleep(5000);
        }
        #endregion
    }
}
