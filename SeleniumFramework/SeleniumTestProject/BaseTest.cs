using NUnit.Framework;
using SeleniumFrameworkBase;
using SeleniumTestPageObjects;
using System.Diagnostics;

namespace SeleniumTestProject
{
    [TestFixture]
    public class BaseTest : SeleniumBrowserInit
    {
        internal SeleniumEasyMainPage mainPage;
        internal SimpleFormDemoPage simpleFormPage;


        public BaseTest() : base("chrome")
        {
            driver = InitBrowser();
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            mainPage = new SeleniumEasyMainPage(driver);
        }

        [OneTimeSetUp]
        public void InitialiseTest()
        {            
            mainPage.clickOnStartPracticing();
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Close();
            driver.Quit();
            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
        }
    }
}