using NUnit.Framework;
using SeleniumTestPageObjects;

namespace SeleniumTestProject
{
    [TestFixture]
    public class SeleniumEasyJavaScriptAlertTest : BaseTest
    {
        SeleniumJavaScritAlertsDemoPage javaScriptAlertDemoPage;

        [SetUp]
        public void DropDownListDemoTestSetup()
        {
            javaScriptAlertDemoPage = new SeleniumEasySimpleFromDemoPage(driver).clickOnJavaScriptAlertDemo();
        }

        [Test]
        public void JavaAlertBoxTest()
        {
            javaScriptAlertDemoPage.alertBoxClickMe.Click();
            driver.SwitchTo().Alert().Dismiss();
        }

        [Test]
        public void JavaConfirmBoxAcceptTest()
        {
            javaScriptAlertDemoPage.confirmBoxClickMe.Click();
            driver.SwitchTo().Alert().Accept();
            Assert.That(javaScriptAlertDemoPage.confirmMessage.Text.Equals("You pressed OK!"));
        }

        [Test]
        public void JavaConfirmBoxCancelTest()
        {
            javaScriptAlertDemoPage.confirmBoxClickMe.Click();
            driver.SwitchTo().Alert().Dismiss();
            Assert.That(javaScriptAlertDemoPage.confirmMessage.Text.Equals("You pressed Cancel!"));
        }

        [Test]
        public void JavaPromptAlertBoxTest()
        {
            javaScriptAlertDemoPage.clickForPromptBox.Click();
            driver.SwitchTo().Alert().SendKeys("This is prompt message");
            driver.SwitchTo().Alert().Accept();
            Assert.That(javaScriptAlertDemoPage.promptMessage.Text.Contains("This is prompt message"));
        }
    }
}
