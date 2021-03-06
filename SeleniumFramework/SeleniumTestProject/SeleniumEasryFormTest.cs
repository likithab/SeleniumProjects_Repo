﻿using NUnit.Framework;
using SeleniumTestPageObjects;

namespace SeleniumTestProject
{
    [TestFixture]
    public class SeleniumEasryFormTest : BaseTest
    {
        [SetUp]
        public void SimpleFormDemoTestSetup()
        {
            simpleFormPage = new SeleniumEasySimpleFromDemoPage(driver).clickOnSimpleFormDemo();
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
    }
}
