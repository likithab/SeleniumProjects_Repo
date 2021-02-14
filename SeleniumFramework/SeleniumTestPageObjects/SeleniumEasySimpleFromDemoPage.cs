using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumEasySimpleFromDemoPage
    {
        IWebDriver driver;

        public SeleniumEasySimpleFromDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement simpleFormDemo => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Simple Form Demo']"));
        IWebElement checkBoxDemo => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Check Box Demo']"));
        IWebElement radioButtonDemo => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Radio Buttons Demo']"));
        IWebElement selectDropDownList => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Select Dropdown List']"));
        IWebElement javaScriptAlerts => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Javascript Alerts']"));
        IWebElement windowPopupModal => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Window Popup Modal']"));
        IWebElement bootStrapAlerts => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Bootstrap Alerts']"));
        IWebElement bootStrapModal => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Bootstrap Modals']"));
        IWebElement intermediate => driver.FindElement(By.Id("inter_example"));
        IWebElement inputFormValidation => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Input Form with Validations']"));

        public SimpleFormDemoPage clickOnSimpleFormDemo()
        {
            simpleFormDemo.Click();
            return new SimpleFormDemoPage(driver);
        }

        public SimpleCheckBoxDemoPage clickOnCheckBoxDemo()
        {
            checkBoxDemo.Click();
            return new SimpleCheckBoxDemoPage(driver);
        }

        public SeleniumRadioButtonDemoPage clickOnRadioButtonDemo()
        {
            radioButtonDemo.Click();
            return new SeleniumRadioButtonDemoPage(driver);
        }

        public SeleniumDropDownListDemoPage clickOnDropDownListDemo()
        {
            selectDropDownList.Click();
            return new SeleniumDropDownListDemoPage(driver);
        }

        public SeleniumJavaScritAlertsDemoPage clickOnJavaScriptAlertDemo()
        {
            javaScriptAlerts.Click();
            return new SeleniumJavaScritAlertsDemoPage(driver);
        }

        public SeleniumWindowModalPopupDemoPage clickOnWindowPopupDemo()
        {
            windowPopupModal.Click();
            return new SeleniumWindowModalPopupDemoPage(driver);
        }

        public SeleniumBootstrapAlertsDemoPage clickOnBootstrapAlertDemo()
        {
            bootStrapAlerts.Click();
            return new SeleniumBootstrapAlertsDemoPage(driver);
        }

        public SeleniumBootstrapModalsDemoPage clickOnBootstrapModalsDemo()
        {
            bootStrapModal.Click();
            return new SeleniumBootstrapModalsDemoPage(driver);
        }

        public SeleniumInputFormWithValidationsDemoPage clickOnInputFormDemo()
        {
            intermediate.Click();
            inputFormValidation.Click();
            return new SeleniumInputFormWithValidationsDemoPage(driver);
        }
    }
}
