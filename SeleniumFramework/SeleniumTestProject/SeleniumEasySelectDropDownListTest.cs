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
    public class SeleniumEasySelectDropDownListTest : BaseTest
    {
        SeleniumDropDownListDemoPage dropDownListDemoPage;

        [SetUp]
        public void DropDownListDemoTestSetup()
        {
            dropDownListDemoPage = new SeleniumEasySimpleFromDemoPage(driver).clickOnDropDownListDemo();
        }

        [Test]
        public void SelectFromDropListTest()
        {
            var selectedValue= dropDownListDemoPage.selectFromDropDown("Sunday");
            Assert.That(selectedValue.Contains("Sunday"));
        }

        [Test]
        public void SelectFromMultiListTest()
        {
            var selectedValue = dropDownListDemoPage.selectFromMultiList("New York", "Ohio");
            Assert.That(selectedValue.Equals("New York, Ohio"));
        }

        [TearDown]
        public void SimpleFormDemoTestTearDown()
        {
            driver.Navigate().Back();
            mainPage.startPracticing.Click();
        }
    }
}
