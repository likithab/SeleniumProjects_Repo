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
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
    }
}
