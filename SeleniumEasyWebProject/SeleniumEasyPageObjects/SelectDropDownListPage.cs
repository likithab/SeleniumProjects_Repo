using SeleniumFrameworkBase;
using OpenQA.Selenium;
using System;

namespace SeleniumEasyPageObjects
{
    public class SelectDropDownListPage
    {
        private IWebDriver driver;

        #region constructor
        public SelectDropDownListPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region webelements
        private IWebElement SelectListDemo => driver.FindElement(By.Id("select-demo"));
        private IWebElement DaySelected => driver.FindElement(By.CssSelector(".selected-value"));
        private IWebElement MultiSelectListDemo => driver.FindElement(By.Id("multi-select"));
        private IWebElement FirstSelectedButton => driver.FindElement(By.Id("printMe"));
        private IWebElement GetAllSelectedButton => driver.FindElement(By.Id("printAll"));
        private IWebElement SelectedOptionMessage => driver.FindElement(By.CssSelector(".getall-selected"));
        #endregion

        #region public methods
        public string SingleList(string value)
        {
            SelectListDemo.SelectFromDropDown(value);
            return DaySelected.Text;
        }

        public string MultiSelectList(params string[] value)
        {
            //MultiSelectListDemo.SelectFormMultiList(value);
            FirstSelectedButton.PerformCLick();
            return SelectedOptionMessage.Text;
        }
        #endregion
    }
}
