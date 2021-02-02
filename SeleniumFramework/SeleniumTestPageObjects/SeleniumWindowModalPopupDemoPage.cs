using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumWindowModalPopupDemoPage
    {
        IWebDriver driver;

        public SeleniumWindowModalPopupDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Web Elements

        public IWebElement singleWindowTwitter => driver.FindElement(By.XPath("//a[text()='  Follow On Twitter ']"));
        public IWebElement singleWindowFacebook => driver.FindElement(By.XPath("//a[text()='  Like us On Facebook ']"));
        public IWebElement multipleWindowTwitterAndFacebook => driver.FindElement(By.XPath("//a[text()='Follow Twitter & Facebook']"));
        public IWebElement multipleWindowFollowAll => driver.FindElement(By.Id("followall"));

        #endregion
    }
}
