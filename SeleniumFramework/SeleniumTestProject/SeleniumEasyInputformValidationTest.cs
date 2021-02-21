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
    public class SeleniumEasyInputformValidationTest : BaseTest
    {
        SeleniumInputFormWithValidationsDemoPage inputFormValidationDemoPage;

        [SetUp]
        public void InputFormValidationTestSetup()
        {
            inputFormValidationDemoPage=new SeleniumEasySimpleFromDemoPage(driver).clickOnInputFormDemo();
        }
        
        [Test]
        public void InputFormTest()
        {
            inputFormValidationDemoPage.FillInputForm("likitha", "b", "abcwoi", "575435", "jdhakjd", "shg", 
                "Arizona", "3575", "hjgccuks", true, "jdhsfius");
        } 
    }
}
