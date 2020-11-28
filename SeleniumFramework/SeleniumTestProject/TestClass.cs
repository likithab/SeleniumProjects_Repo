using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFrameworkBase;
using SeleniumTestPageObjects;
using System.Diagnostics;
using System.Threading;

namespace SeleniumTestProject
{
    [TestFixture]
    public class BaseTest : SeleniumBrowserInit
    {
        SeleniumEasyMainPage mainPage;
        SimpleFormDemoPage simpleFormPage;

        public BaseTest():base("chrome")
        {
            driver=InitBrowser();
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
        }

        [OneTimeSetUp]
        public void InitialiseTest()
        {
            mainPage = new SeleniumEasyMainPage(driver);
            mainPage.clickOnStartPracticing();
            simpleFormPage = new SeleniumEasySimpleFromDemo(driver).clickOnSimpleFormDemo();
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

        [Test]
        public void SimpleFormPageSimpleInputTest()
        {
            simpleFormPage.singleInputFieldActions("Hello world dot...!");
            Thread.Sleep(10000);
        }

        [Test]
        public void SimpleFormPageMultipleInputTest()
        {
            simpleFormPage.multipleInputFieldAction("1","2");
            Thread.Sleep(10000);
        }       
    }
}
