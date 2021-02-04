using NUnit.Framework;
using SeleniumTestPageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject
{
    [TestFixture]
    public class SeleniumEasyBootStrapModalTest : BaseTest
    {
        SeleniumBootstrapModalsDemoPage bootStrapModalDemoPage;

        [SetUp]
        public void BootStrapAlertsTestSetup()
        {
            bootStrapModalDemoPage = new SeleniumEasySimpleFromDemoPage(driver).clickOnBootstrapModalsDemo();
        }

        [Test]
        public void SingleModalDiaogTest()
        {
            bootStrapModalDemoPage.singleModal.Click();
            bootStrapModalDemoPage.modalDialogClose.Click();
        }

        [Test]
        public void multipleModalDialogTest()
        {
            bootStrapModalDemoPage.multipleModal.Click();
            bootStrapModalDemoPage.multipleModalSecond.Click();
            bootStrapModalDemoPage.modalDialogClose.Click();
        }
    }
}
