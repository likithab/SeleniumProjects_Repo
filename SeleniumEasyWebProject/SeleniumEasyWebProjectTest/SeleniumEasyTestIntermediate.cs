using NUnit.Framework;
using SeleniumEasyPageObjects;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumEasyWebProjectTest
{
    class SeleniumEasyTestIntermediate : BaseTest
    {
        #region Test Variables
        SeleniumEasyIntermediatePage intermediate = new SeleniumEasyIntermediatePage(driver);
        #endregion

        #region Test Setup Tear Down    
        [SetUp]
        public void SelectIntermediate()
        {
            driver.FindElement(By.Id("inter_example")).Click();
        }
        [TearDown]
        public void GoToMainPage()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Demo Home")).Click();
            driver.FindElement(By.Id("inter_example")).Click();
        }
        #endregion

        #region Test

        [Test]
        [Order(1)]
        public void SeleniumInutFormValidationTest()
        {
            intermediate.SelectInputFormwithValidations();
            InputFormWithValidationPage valdationPage = new InputFormWithValidationPage(driver);
            valdationPage.FirstName("likitha");
            valdationPage.LastName("b");
            valdationPage.EMail("jew@amail.com");
            valdationPage.Phone("4512368978");
            valdationPage.Address("iwdewfcbdsfhiuaw");
            valdationPage.City("Bangalore");
            valdationPage.State("Karnataka");
            valdationPage.ZipCode("56246");
            valdationPage.WebSiteOrDomain("no idea");
            valdationPage.HasHosting();
            valdationPage.ProjectDescription("feowjflkfoai");
            valdationPage.Send();
        }
        [Test]
        [Order(2)]
        public void SeleniumAjaxFormSubmit()
        {
            intermediate.SelectAjaxFormSubmit();
            AjaxFormSubmitPage ajaxForm = new AjaxFormSubmitPage(driver);
            ajaxForm.Name("ajaxFormTest");
            ajaxForm.Comment("dlweud kejdoq oidjwiojdp");
            ajaxForm.Submit();
        }
        [Test]
        [Order(3)]
        public void SeleniumJquerySelectDropDownList()
        {
            intermediate.SelectJQuerySelectdropdown();
            JQuerySelectdropdownPage jqueryDDL = new JQuerySelectdropdownPage(driver);
            jqueryDDL.SelectCountry();
            jqueryDDL.SelectState();
            jqueryDDL.SelectUSOutlyingTerritories();
            jqueryDDL.SelectFile();
        }
        [Test]
        [Order(4)]
        public void SeleniumBootStrapListBox()
        {
            intermediate.SelectBootstrapListBox();
            SeleniumBootStrapListBoxPage listBox = new SeleniumBootStrapListBoxPage(driver);

        }
        #endregion

        #region Private Helper Methods

        #endregion
    }
}
