using SeleniumFrameworkBase;
using OpenQA.Selenium;
using System;

namespace SeleniumEasyPageObjects
{
    public class JQuerySelectdropdownPage
    {
        private IWebDriver driver;

        #region constructor
        public JQuerySelectdropdownPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region webelements
        private IWebElement selectCountry => driver.FindElement(By.CssSelector(".select2-selection.select2-selection--single"));
        private IWebElement selectState => driver.FindElement(By.CssSelector(".select2-search__field[placeholder='Select state(s)']"));
        private IWebElement selectOutlyigTeritorries => driver.FindElement(By.XPath("//div/label[text()='Select US Outlying Territories :']//following::span[3]"));
        private IWebElement selectFile => driver.FindElement(By.Id("files"));
        #endregion

        #region public methods
        public void SelectCountry()
        {
            selectCountry.PerformCLick();
            IWebElement enterCountry = driver.FindElement(By.XPath("//span[@class='select2-search select2-search--dropdown']/input[@class='select2-search__field']"));
            enterCountry.SetTextValue("Australia");
        }
        public void SelectState()
        {
            selectState.SetTextValue("Alabama");
        }
        public void SelectUSOutlyingTerritories()
        {
            selectOutlyigTeritorries.PerformCLick();
            IWebElement USTerritories = driver.FindElement(By.XPath("//span/input[@class='select2-search__field']"));
            USTerritories.SetTextValue("Puerto Rico");
            IWebElement HiglightedText = driver.FindElement(By.XPath("//ul/li[contains(@class,'select2-results__option--highlighted')]"));
            HiglightedText.PerformCLick();
        }
        public void SelectFile()
        {
            selectFile.SelectFromDropDown("PHP");
        }
        #endregion
    }
}
