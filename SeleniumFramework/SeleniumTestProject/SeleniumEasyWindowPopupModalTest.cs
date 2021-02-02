using NUnit.Framework;
using SeleniumTestPageObjects;

namespace SeleniumTestProject
{
    [TestFixture]
    public class SeleniumEasyWindowPopupModalTest : BaseTest
    {
        SeleniumWindowModalPopupDemoPage windowModalPopupDemoPage;

        [SetUp]
        public void WindowPopupTestSetup()
        {
            windowModalPopupDemoPage = new SeleniumEasySimpleFromDemoPage(driver).clickOnWindowPopupDemo();
        }

        [Test]
        public void SingleWindowTwitterTest()
        {
            windowModalPopupDemoPage.singleWindowTwitter.Click();
            var currentWindow = driver.CurrentWindowHandle;
            var windowHandles=driver.WindowHandles;
            int windowCount=windowHandles.Count;
            foreach (var window in windowHandles)
            {
                if (window != currentWindow)
                {
                    driver.SwitchTo().Window(window).Close();
                }
            }
            driver.SwitchTo().Window(currentWindow);
        }

        [Test]
        public void SingleWindowFacebookTest()
        {
            windowModalPopupDemoPage.singleWindowFacebook.Click();
            var currentWindow = driver.CurrentWindowHandle;
            var windowHandles = driver.WindowHandles;
            int windowCount = windowHandles.Count;
            foreach (var window in windowHandles)
            {
                if (window != currentWindow)
                {
                    driver.SwitchTo().Window(window).Close();
                }
            }
            driver.SwitchTo().Window(currentWindow);
        }

        [Test]
        public void MultipleWindowTwitterAndFacebookTest()
        {
            windowModalPopupDemoPage.multipleWindowTwitterAndFacebook.Click();
            var currentWindow = driver.CurrentWindowHandle;
            var windowHandles = driver.WindowHandles;
            int windowCount = windowHandles.Count;
            foreach (var window in windowHandles)
            {
                if (window != currentWindow)
                {
                    driver.SwitchTo().Window(window).Close();
                }
            }
            driver.SwitchTo().Window(currentWindow);
        }

        [Test]
        public void MultipleWindowFollowAllTest()
        {
            windowModalPopupDemoPage.multipleWindowFollowAll.Click();
            var currentWindow = driver.CurrentWindowHandle;
            var windowHandles = driver.WindowHandles;
            int windowCount = windowHandles.Count;
            foreach (var window in windowHandles)
            {
                if (window != currentWindow)
                {
                    driver.SwitchTo().Window(window).Close();
                }
            }
            driver.SwitchTo().Window(currentWindow);
        }
    }
}
