using SeleniumFrameworkBase;
using OpenQA.Selenium;
using System;

namespace SeleniumEasyPageObjects
{
    public class SimpleFormDemoPage
    {
        private IWebDriver driver;

        public SimpleFormDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region webelements
        private IWebElement SimpleInput => driver.FindElement(By.Id("user-message"));
        private IWebElement ShowMessage => driver.FindElement(By.ClassName("btn-default"));
        private IWebElement YourMessage => driver.FindElement(By.Id("display"));
        private IWebElement EnterA => driver.FindElement(By.Id("sum1"));
        private IWebElement EnterB => driver.FindElement(By.Id("sum2"));
        private IWebElement GetTotal => driver.FindElement(By.XPath("//button[@class='btn btn-default' and  text()='Get Total']"));
        private IWebElement Total => driver.FindElement(By.Id("displayvalue"));
        #endregion

        public string TwoInputFields(string input1, string input2)
        {
            EnterA.SetTextValue(input1);
            EnterB.SetTextValue(input2);
            GetTotal.PerformCLick();
            return Total.Text;
        }

        public string SingleInputField(string input)
        {
            SimpleInput.SetTextValue(input);
            ShowMessage.PerformCLick();
            return YourMessage.Text;
        }
    }
}
