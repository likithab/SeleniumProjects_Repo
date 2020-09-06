using SeleniumFrameworkBase;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumEasyPageObjects
{
    public class SeleniumEasyPage
    {
        #region Field
        private IWebDriver driver;
        #endregion

        #region Constructor
        public SeleniumEasyPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region Web Elements

        private IWebElement HomePagePopupClose => driver.FindElement(By.Id("at-cv-lightbox-close"));
        private IWebElement StartPractising => driver.FindElement(By.Id("btn_basic_example"));
        private IWebElement SimpleFormDemo => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Simple Form Demo']"));
        private IWebElement CheckBoxDemo => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Check Box Demo']"));
        private IWebElement RadioButtonDemo => driver.FindElement(By.LinkText("Radio Buttons Demo"));
        private IWebElement SelectDropDownList => driver.FindElement(By.LinkText("Select Dropdown List"));
        private IWebElement JavaAlerts => driver.FindElement(By.LinkText("Javascript Alerts"));
        private IWebElement WindowPopupModel => driver.FindElement(By.LinkText("Window Popup Modal"));
        private IWebElement BootStrapAlerts => driver.FindElement(By.LinkText("Bootstrap Alerts"));
        private IWebElement BootStrapModels => driver.FindElement(By.LinkText("Bootstrap Modals"));
        private IWebElement WelcomeMessahe => driver.FindElement(By.Id("at-cv-lightbox-close"));
        #endregion

        #region Methods
        public RadioButtonDemoPage SelectRadioButtonDemo()
        {
            RadioButtonDemo.PerformCLick();
            return new RadioButtonDemoPage(this.driver);
        }
        public SimpleFormDemoPage SelectSimpleFormDemo()
        {
            SimpleFormDemo.PerformCLick();
            return new SimpleFormDemoPage(this.driver);
        }
        public void ClickOnStartPractising()
        {
            WebDriverWait webdriverwait = new WebDriverWait(driver, new TimeSpan(30));
            try
            {
                webdriverwait.Until(ExpectedConditions.ElementIsVisible(By.Id("at-cv-lightbox-close")));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                HomePagePopupClose.PerformCLick();
            }
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true)", StartPractising);
            StartPractising.Click();
        }
        public SelectDropDownListPage SelectDropDownListDemo()
        {
            SelectDropDownList.PerformCLick();
            return new SelectDropDownListPage(this.driver);
        }
        public CheckBoxDemoPage SelectCheckBoxDemo()
        {
            CheckBoxDemo.PerformCLick();
            return new CheckBoxDemoPage(this.driver);
        }
        public JavaScriptAlertPage SelectJavaScriptAlert()
        {
            JavaAlerts.PerformCLick();
            return new JavaScriptAlertPage(this.driver);
        }
        public WindowPopupModalPage SelectWindowPopupModal()
        {
            WindowPopupModel.PerformCLick();
            return new WindowPopupModalPage(this.driver);
        }
        public BootStrapAlertPage SelectBootStrapAlert()
        {
            BootStrapAlerts.PerformCLick();
            return new BootStrapAlertPage(this.driver);
        }
        public BootStarpModalPage SelectBootStrapModal()
        {
            BootStrapModels.PerformCLick();
            return new BootStarpModalPage(this.driver);
        }

        #endregion
    }
}
