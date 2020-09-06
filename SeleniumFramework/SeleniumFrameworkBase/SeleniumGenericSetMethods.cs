using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFrameworkBase
{
    public static class SeleniumGenericSetMethods
    {
        public static void SetTextValue(this IWebElement selector, string textValue)
        {

            selector.SendKeys(textValue);
        }

        public static void PerformCLick(this IWebElement selector)
        {
            selector.Click();
        }

        public static void SelectFromDropDown(this IWebElement selector, string textValue)
        {
            SelectElement select = new SelectElement(selector);
            select.SelectByText(textValue);
        }

        public static void SelectFrame(this IWebElement selector)
        {
            //driver.SwitchTo().Frame(selector);
        }
    }
}
