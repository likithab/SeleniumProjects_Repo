using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestPageObjects
{
    public class SeleniumDropDownListDemoPage
    {
        IWebDriver driver;
        public SeleniumDropDownListDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement selectListDemo => driver.FindElement(By.Id("select-demo"));
        IWebElement multiSelectListDemo => driver.FindElement(By.Id("multi-select"));
        IWebElement firstSelectedButton => driver.FindElement(By.Id("printMe"));
        IWebElement getAllSelected => driver.FindElement(By.Id("printAll"));
        IWebElement selectedValue => driver.FindElement(By.CssSelector(".selected-value"));
        IWebElement multiSelectedValue => driver.FindElement(By.ClassName("getall-selected"));

        public static SelectElement SelectFromList(IWebElement element)
        {
            SelectElement select = new SelectElement(element);
            return select;
        }

        public string selectFromDropDown(string dropDownListValue)
        {
            var singleList=SelectFromList(selectListDemo);
            singleList.SelectByText(dropDownListValue);
            return selectedValue.Text;
        }

        public string selectFromMultiList(params string[]  multiListValue)
        {
            var multiSelector=SelectFromList(multiSelectListDemo);
            if (multiSelector.IsMultiple)
            {
                //Actions action=new Actions(driver);
                //action.MoveToElement(multiSelectListDemo);
                foreach (var value in multiListValue)
                {
                    multiSelector.SelectByText(value);
                }
            }
            var items= multiSelector.AllSelectedOptions;
            getAllSelected.Click();
            return multiSelectedValue.Text;
        }
    }
}
