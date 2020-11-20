using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFrameworkBase;
using SeleniumTestPageObjects;
using System.Threading;

namespace SeleniumTestProject
{
    [TestFixture]
    public class BaseTest : SeleniumBrowserInit
    {
        SeleniumEasyMainPage mainPage;

        public BaseTest():base("chrome")
        {
            driver=InitBrowser();
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            mainPage = new SeleniumEasyMainPage(driver);
            mainPage.clickOnStartPracticing();
        }

        [Test]
        public void SimpleFormPageSimpleInputTest()
        {
            var simpleFormPage=new SeleniumEasySimpleFromDemo(driver).clickOnSimpleFormDemo();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
