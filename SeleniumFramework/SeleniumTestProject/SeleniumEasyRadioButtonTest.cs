using NUnit.Framework;
using SeleniumTestPageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            radioButtonDemoPage = new SeleniumEasySimpleFromDemoPage(driver).clickOnRadioButtonDemo();
        }

        [Test]
        public void RadioButtonDemoForFemaleTest()
        {
            var successMessage=radioButtonDemoPage.getCheckedValueForFemale();
            Thread.Sleep(5000);
            Assert.IsTrue(successMessage.Equals("Radio button 'Female' is checked"));               
        }

        [Test]
        public void RadioButtonDemoForMaleTest()
        {
            var successMessage = radioButtonDemoPage.getCheckedValueForMale();
            Thread.Sleep(5000);
            Assert.IsTrue(successMessage.Equals("Radio button 'Male' is checked"));
        }

        [Test]
        public void GroupRadioButtonsDemoForFemaleTest()
        {
            var successMessage=radioButtonDemoPage.getCheckedValueForFemaleGroup();
            successMessage = successMessage.Replace("\r\n", " ");
            Assert.IsTrue(successMessage.Equals("Sex : Female Age group: 0 - 5"));
        }

        [Test]
        public void GroupRadioButtonsDemoForMaleTest()
        {
            var successMessage = radioButtonDemoPage.getCheckedValueForMaleGroup();
            successMessage = successMessage.Replace("\r\n", " ");
            Assert.IsTrue(successMessage.Equals("Sex : Male Age group: 0 - 5"));
        }
    }
}
