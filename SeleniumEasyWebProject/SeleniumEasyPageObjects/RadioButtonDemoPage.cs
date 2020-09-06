using SeleniumFrameworkBase;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumEasyPageObjects
{
    public class RadioButtonDemoPage
    {
        private IWebDriver driver;

        #region constructor
        public RadioButtonDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region WebElements
        private IWebElement Male => driver.FindElement(By.XPath("//input[@value='Male' and  @name='optradio']"));
        private IWebElement Female => driver.FindElement(By.CssSelector("input[name='optradio'][value='Female']"));
        private IWebElement GetCheckedValue => driver.FindElement(By.Id("buttoncheck"));
        private IWebElement GroupRadioButtonMale => driver.FindElement(By.CssSelector("input[name='gender'][value='Male']"));
        private IWebElement GroupRadioButtonFemale => driver.FindElement(By.CssSelector("input[name='gender'][value='Female']"));
        private IWebElement AgeGroup1 => driver.FindElement(By.CssSelector("input[value='0 - 5']"));
        private IWebElement AgeGroup2 => driver.FindElement(By.CssSelector("input[value='5 - 15']"));
        private IWebElement AgeGroup3 => driver.FindElement(By.CssSelector("input[value='15 - 50']"));
        private IWebElement GetValues => driver.FindElement(By.CssSelector("button[onclick='getValues();']"));
        private IWebElement GetCheckedValueMessage => driver.FindElement(By.Id("buttoncheck"));
        private IWebElement GetValuesMessage => driver.FindElement(By.CssSelector(".groupradiobutton"));
        #endregion

        #region public methods

        public string SelectMaleRadioButton()
        {
            Male.PerformCLick();
            GetCheckedValue.PerformCLick();
            return GetCheckedValueMessage.Text;
        }
        public string SelectFemaleRadioButton()
        {
            Female.PerformCLick();
            GetCheckedValue.PerformCLick();
            return GetCheckedValueMessage.Text;
        }
        public string SelectFemaleAndAgeGroup1()
        {
            GroupRadioButtonFemale.PerformCLick();
            AgeGroup1.PerformCLick();
            return GetValuesMessage.Text;
        }
        public string SelectFemaleAndAgeGroup2()
        {
            GroupRadioButtonFemale.PerformCLick();
            AgeGroup2.PerformCLick();
            return GetValuesMessage.Text;
        }
        public string SelectFemaleAndAgeGroup3()
        {
            GroupRadioButtonFemale.PerformCLick();
            AgeGroup3.PerformCLick();
            return GetValuesMessage.Text;
        }
        public string SelectMaleAndAgeGroup1()
        {
            GroupRadioButtonMale.PerformCLick();
            AgeGroup1.PerformCLick();
            return GetValuesMessage.Text;
        }
        public string SelectMaleAndAgeGroup2()
        {
            GroupRadioButtonMale.PerformCLick();
            AgeGroup2.PerformCLick();
            return GetValuesMessage.Text;
        }
        public string SelectMaleAndAgeGroup3()
        {
            GroupRadioButtonMale.PerformCLick();
            AgeGroup3.PerformCLick();
            return GetValuesMessage.Text;
        }

        #endregion

    }
}
