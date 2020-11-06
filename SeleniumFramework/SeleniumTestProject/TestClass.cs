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
            driver.Navigate().GoToUrl("www.google.com");
            driver.Close();
            driver.Quit();
        }
    }
}
