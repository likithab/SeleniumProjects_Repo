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
    public class SeleniumEasyRadioButtonTest : BaseTest
    {
        SeleniumRadioButtonDemoPage radioButtonDemoPage;

        [SetUp]
        public void CheckBoxDemoTestSetup()
        {
            radioButtonDemoPage = new SeleniumEasySimpleFromDemo(driver).clickOnRadioButtonDemo();
        }

        [Test]
        public void RadioButtonDemoTest()
        {
            var successMessage=radioButtonDemoPage.getCheckedValueForFemale();
            Assert.IsTrue(successMessage.Equals("Radio button 'Female' is checked"));

            successMessage=radioButtonDemoPage.getCheckedValueForMale();
            Assert.IsTrue(successMessage.Equals("Radio button 'Male' is checked"));            
        }

        [Test]
        public void GroupRadioButtonsDemoTest()
        {
            var successMessage=radioButtonDemoPage.getCheckedValueForFemaleGroup();
            Assert.IsTrue(successMessage.Equals("Sex : Female"+"Age group: 0 - 5"));

            successMessage=radioButtonDemoPage.getCheckedValueForMaleGroup();
            Assert.IsTrue(successMessage.Equals("Sex : Male" + "Age group: 0 - 5"));
        }

        [TearDown]
        public void SimpleFormDemoTestTearDown()
        {
            driver.Navigate().Back();
            mainPage.startPracticing.Click();
        }
    }
}
