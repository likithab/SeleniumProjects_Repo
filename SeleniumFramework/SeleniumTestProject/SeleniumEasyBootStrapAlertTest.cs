using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTestPageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject
{
    [TestFixture]
    public class SeleniumEasyBootStrapAlertTest : BaseTest
    {
        SeleniumBootstrapAlertsDemoPage bootStrapDemoPage;

        [SetUp]
        public void BootStrapAlertsTestSetup()
        {
            bootStrapDemoPage = new SeleniumEasySimpleFromDemoPage(driver).clickOnBootstrapAlertDemo();
        }

        [Test]
        public void AutoClosableMessageTest()
        {
            var message=bootStrapDemoPage.ClickOnAutoCloseable();
            Assert.IsTrue(message.Contains("an autocloseable success message. I will hide in 5 seconds."));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Assert.IsTrue(wait.Until(ExpectedConditions.InvisibilityOfElementLocated
                (By.ClassName("alert-autocloseable-success"))));
        }

        [Test]
        public void NormalSuccessMessageTest()
        {
            var message=bootStrapDemoPage.ClickOnNormalMessage();
            Assert.IsTrue(message.Contains("a normal success message. To close use the appropriate button."));
        }        
    }
}
