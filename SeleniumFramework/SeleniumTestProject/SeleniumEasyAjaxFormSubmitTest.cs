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
    public class SeleniumEasyAjaxFormSubmitTest : BaseTest
    {
        SeleniumAjaxFormSubmitDemoPage ajaxFormSubmitDemoPage;

        [SetUp]
        public void AjaxFormTestSetup()
        {
            var ajaxFormSubmitDemoPage=new SeleniumEasySimpleFromDemoPage(driver).clickOnAjaxFormDemo();
        }

        [Test]
        public void TestMethod()
        {
            var confirmMessage=ajaxFormSubmitDemoPage.submitForm("ajax", "submit form");
            Assert.IsTrue(confirmMessage.Equals("Form submited Successfully!"));
        }
    }
}
