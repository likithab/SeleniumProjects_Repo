using SeleniumFrameworkBase;
using OpenQA.Selenium;

namespace SeleniumEasyPageObjects
{
    public class JavaScriptAlertPage
    {
        #region Field
        private IWebDriver driver;
        #endregion

        #region Constructor
        public JavaScriptAlertPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region Webelement
        private IWebElement JavaScriptAlertBox => driver.FindElement(By.CssSelector(".btn.btn-default"));
        private IWebElement JavaScriptConfirmBox => driver.FindElement(By.CssSelector(".btn.btn-default.btn-lg"));
        private IWebElement JavaScriptPromtBox => driver.FindElement(By.CssSelector("button.btn.btn-default.btn-lg[onclick='myPromptFunction()']"));
        private IWebElement PromptMessage => driver.FindElement(By.Id("prompt-demo"));
        private IWebElement ConfirmMessage => driver.FindElement(By.Id("confirm-demo"));
        #endregion

        #region Methods
        public string SelectJavaScriptAlertBox()
        {
            JavaScriptAlertBox.PerformCLick();
            var alertText = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            return alertText;
        }

        public void SelectJavaScriptConfirmBox()
        {
            JavaScriptConfirmBox.PerformCLick();
        }

        public void SelectJavaScriptPromptBox()
        {
            JavaScriptPromtBox.PerformCLick();
        }
        #endregion
    }
}
