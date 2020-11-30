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
            string simpleText=simpleFormPage.singleInputFieldActions("Hello world dot...!");
            Assert.That(simpleText.Equals("Hello world dot...!"));            
        }

        [Test]
        public void SimpleFormPageMultipleInputTest()
        {
            string multipleText=simpleFormPage.multipleInputFieldAction("1","2");
            Assert.That(multipleText.Equals("3"));
        } 
        
        [TearDown]
        public void SimpleFormDemoTestTearDown()
        {
            driver.Navigate().Back();
            mainPage.startPracticing.Click();
        }
    }
}
