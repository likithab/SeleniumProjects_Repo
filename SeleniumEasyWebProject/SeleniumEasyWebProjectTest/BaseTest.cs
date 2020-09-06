using NUnit.Framework;
using SeleniumEasyPageObjects;
using SeleniumFrameworkBase;
using System.Diagnostics;

namespace SeleniumEasyWebProjectTest
{
    [TestFixture]
    internal class BaseTest : SeleniumBrowserInit
    {
        #region Constructor

        public BaseTest() : base(BrowserInfo.Browser)
        {
            driver = InitBrowser();
            driver.Url = Url.SeleniumEasy;
            selPageTest = new SeleniumEasyPage(driver);
        }

        #endregion

        #region Fields

        public SeleniumEasyPage selPageTest;

        #endregion

        #region Test setup and tear down
        [OneTimeSetUp]
        public void InitialiseTest()
        {
            selPageTest.ClickOnStartPractising();
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
        #endregion
    }
}
