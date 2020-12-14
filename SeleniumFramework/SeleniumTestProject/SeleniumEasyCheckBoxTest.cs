﻿using NUnit.Framework;
using SeleniumTestPageObjects;

namespace SeleniumTestProject
{
    [TestFixture]
    public class SeleniumEasyCheckBoxTest : BaseTest
    {
        SimpleCheckBoxDemoPage checkBoxDemoPage;
        [SetUp]
        public void CheckBoxDemoTestSetup()
        {
            checkBoxDemoPage = new SeleniumEasySimpleFromDemo(driver).clickOnCheckBoxDemo();
        }

        [Test]
        public void singleCheckBoxTest()
        {
            string message = checkBoxDemoPage.clickSingleCheckboxDemo();
            Assert.That(message.Equals("Success - Check box is checked"));                
        }

        [Test]
        public void multipleCheckBoxTest()
        {
            string buttonName=checkBoxDemoPage.clickAllCheckBoxes();
            Assert.That(buttonName.Equals("Uncheck All"));
        }

        [TearDown]
        public void SimpleFormDemoTestTearDown()
        {
            driver.Navigate().Back();
            mainPage.startPracticing.Click();
        }
    }
}
