using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFrameworkBase
{
    public static class SeleniumGenericGetMethods
    {
        public static string GetTextBoxValue(this IWebElement selector)
        {
            return selector.Text;
        }

        public static bool GetCheckBoxVaue(this IWebElement selector)
        {
            return selector.Enabled;
        }

        public static string GetDropDownValue(this IWebElement selector)
        {
            SelectElement sele = new SelectElement(selector);
            return sele.AllSelectedOptions.FirstOrDefault().Text;
        }

        public static IList<IWebElement> GetListOfElements(IWebDriver driver, By selector)
        {
            return driver.FindElements(selector);
        }

        public static IWebElement GetFrames(IWebDriver driver, By selector)
        {
            return driver.FindElement(selector);
        }
    }
}
