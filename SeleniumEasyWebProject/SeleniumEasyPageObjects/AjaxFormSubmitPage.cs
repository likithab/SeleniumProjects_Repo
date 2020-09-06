using SeleniumFrameworkBase;
using OpenQA.Selenium;

namespace SeleniumEasyPageObjects
{
    public class AjaxFormSubmitPage
    {
        #region Field
        private IWebDriver driver;

        #endregion

        #region Constructor
        public AjaxFormSubmitPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region WebElements
        private IWebElement name => driver.FindElement(By.Id("title"));
        private IWebElement comment => driver.FindElement(By.Id("description"));
        private IWebElement submitButton => driver.FindElement(By.Id("btn-submit"));
        #endregion

        #region Methods
        public void Name(string ajaxName)
        {
            name.SetTextValue(ajaxName);
        }
        public void Comment(string ajaxComment)
        {
            comment.SetTextValue(ajaxComment);
        }
        public void Submit()
        {
            submitButton.PerformCLick();
        }
        #endregion
    }
}
