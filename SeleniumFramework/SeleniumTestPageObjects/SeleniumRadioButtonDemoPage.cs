using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumRadioButtonDemoPage
    {
        IWebDriver driver;
        public SeleniumRadioButtonDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement femaleRadioDemoButton => driver.FindElement(By.XPath("//label/input[@value='Female' and @name='optradio']"));
        IWebElement maleRadioDemoButton => driver.FindElement(By.XPath("//label/input[@value='Male' and @name='optradio']"));
        IWebElement getCheckedValue => driver.FindElement(By.Id("buttoncheck"));
        IWebElement femaleGroupRadioButton => driver.FindElement(By.XPath("//label/input[@value='Female' and @name='gender']"));
        IWebElement maleGroupRadioButton => driver.FindElement(By.XPath("//label/input[@value='Male' and @name='gender']"));
        IWebElement checkedValueMessage => driver.FindElement(By.XPath("//p[@class='radiobutton']"));
        IWebElement ageGroup0to5 => driver.FindElement(By.XPath("//label/input[@name='ageGroup' and @value='0 - 5']"));
        IWebElement ageGroup5to15 => driver.FindElement(By.XPath("//label/input[@name='ageGroup' and @value='5 - 15']"));
        IWebElement ageGroup15to50 => driver.FindElement(By.XPath("//label/input[@name='ageGroup' and @value='15 - 50']"));
        IWebElement getValues => driver.FindElement(By.XPath("//button[@class='btn btn-default' and  text()='Get values']"));
        IWebElement getValuesMessage => driver.FindElement(By.XPath("//p[@class='groupradiobutton']"));

        public string getCheckedValueForFemale()
        {
            femaleRadioDemoButton.Click();
            getCheckedValue.Click();
            return checkedValueMessage.Text;
        }

        public string getCheckedValueForMale()
        {
            maleRadioDemoButton.Click();
            getCheckedValue.Click();
            return checkedValueMessage.Text;
        }

        public string getCheckedValueForFemaleGroup()
        {
            femaleGroupRadioButton.Click();
            ageGroup0to5.Click();
            getValues.Click();
            return getValuesMessage.Text;
        }

        public string getCheckedValueForMaleGroup()
        {
            maleGroupRadioButton.Click();
            ageGroup0to5.Click();
            getValues.Click();
            return getValuesMessage.Text;
        }


    }
}
