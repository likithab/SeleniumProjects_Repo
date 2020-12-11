using OpenQA.Selenium;

namespace SeleniumTestPageObjects
{
    public class SimpleCheckBoxDemoPage
    {
        IWebDriver driver;
        public SimpleCheckBoxDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement singleCheckBoxDemo => driver.FindElement(By.Id("isAgeSelected"));
        IWebElement checkAll => driver.FindElement(By.Id("check1"));
        IWebElement sucessMessage => driver.FindElement(By.Id("txtAge"));

        public string clickSingleCheckboxDemo()
        {
            singleCheckBoxDemo.Click();
            return sucessMessage.Text;
        }

        public string clickAllCheckBoxes()
        {
            checkAll.Click();
            return checkAll.GetAttribute("value");
        }
    }
}