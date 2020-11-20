using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace SeleniumFrameworkBase
{
    public class SeleniumBrowserInit
    {
        public SeleniumBrowserInit(string browserType)
        {
            BrowserType = browserType;
        }
        public string BrowserType { get; set; }

        public static IWebDriver driver;

        public IWebDriver InitBrowser()
        {
            if (BrowserType.Equals(Browser.chrome.ToString()))
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--ignore-ssl-errors=yes");
                options.AddArgument("--ignore-certificate-errors");
                driver = new ChromeDriver(options: options);
                //driver = new ChromeDriver();
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }

    public enum Browser
    {
        chrome,
        ie,
        firefox,
    }
}
