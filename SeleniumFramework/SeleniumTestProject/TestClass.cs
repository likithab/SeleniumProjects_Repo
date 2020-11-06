using NUnit.Framework;
using SeleniumFrameworkBase;

namespace SeleniumTestProject
{
    [TestFixture]
    public class BaseTest : SeleniumBrowserInit
    {
        public BaseTest():base("chrome")
        {
            driver=InitBrowser();
        }

        [Test]
        public void TestMethod()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            Assert.AreEqual(driver.Title, "Google");
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
