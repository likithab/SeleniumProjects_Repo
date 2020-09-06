using SeleniumFrameworkBase;
using OpenQA.Selenium;

namespace SeleniumEasyPageObjects
{
    public class CheckBoxDemoPage
    {
        #region Field
        private IWebDriver driver;
        #endregion

        #region Constructor
        public CheckBoxDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region WebElements
        private IWebElement SingleCheckBoxDemo => driver.FindElement(By.Id("isAgeSelected"));
        private IWebElement MultipleCheckBoxDemo => driver.FindElement(By.Id("check1"));
        private IWebElement Message => driver.FindElement(By.Id("txtAge"));
        #endregion

        #region Methods
        public string SelectSimpleCheckBox()
        {
            SingleCheckBoxDemo.PerformCLick();
            return Message.Text;
        }

        public string SelectMultipleCheckBox()
        {
            MultipleCheckBoxDemo.PerformCLick();
            return MultipleCheckBoxDemo.GetAttribute("value");
        }
        #endregion
    }
}
