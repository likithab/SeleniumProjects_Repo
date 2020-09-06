using SeleniumFrameworkBase;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEasyPageObjects
{
    public class SeleniumBootStrapListBoxPage
    {
        private IWebDriver driver;

        public SeleniumBootStrapListBoxPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement SearchBox1 => driver.FindElement(By.XPath("//*[@class='well text-right']/div/div/div/input"));
        IWebElement SearchBox2 => driver.FindElement(By.XPath("//*[@class='well']/div/div/div/input"));
        IList<IWebElement> ListBox1 => driver.FindElements(By.XPath("//*[@class='well text-right']/ul"));
        IList<IWebElement> ListBox2 => driver.FindElements(By.XPath("//*[@class='well']/ul"));
        IWebElement SelectAllBox1 => driver.FindElement(By.XPath("//*[@class='well text-right']/div/div[2]/div/a"));
        IWebElement SelectAllBox2 => driver.FindElement(By.XPath("//*[@class='well']/div/div[1]/div/a"));






    }
}
