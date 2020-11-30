using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFrameworkBase;
using SeleniumTestPageObjects;
using System.Diagnostics;
using System.Threading;

namespace SeleniumTestProject
{
    [TestFixture]
    public class SeleniumEasryFormTest : BaseTest
    {
        SimpleFormDemoPage simpleFormPage;

        [SetUp]
        public void SimpleFormDemoTestSetup()
        {
            simpleFormPage = new SeleniumEasySimpleFromDemo(driver).clickOnSimpleFormDemo();
        }

        [Test]
        public void SimpleFormPageSimpleInputTest()
        {
            simpleFormPage.singleInputFieldActions("Hello world dot...!");
            Thread.Sleep(5000);
        }

        [Test]
        public void SimpleFormPageMultipleInputTest()
        {
            simpleFormPage.multipleInputFieldAction("1","2");
            Thread.Sleep(5000);
        } 
        
        [TearDown]
        public void SimpleFormDemoTestTearDown()
        {
            driver.Navigate().Back();
            Thread.Sleep(5000);
        }
    }
}
