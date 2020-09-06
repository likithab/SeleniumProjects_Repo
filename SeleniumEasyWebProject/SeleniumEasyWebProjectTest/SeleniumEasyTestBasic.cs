using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumEasyPageObjects;
using System.Threading;

namespace SeleniumEasyWebProjectTest
{
    class SeleniumEasyTestBasic : BaseTest
    {
        #region Test Tear Down
        [TearDown]
        public void EndTest()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Demo Home")).Click();
            driver.FindElement(By.Id("basic_example")).Click();
        }
        #endregion

        #region Test Methods
        [Test, Order(1)]
        [Category("Batch 1")]
        public void SeleniumEasyAppTest()
        {
            SimpleFormDemoPage formDemo = selPageTest.SelectSimpleFormDemo();
            var output = formDemo.SingleInputField("Hello i am chitti dot.....!");

            Assert.That(output, Is.EqualTo("Hello i am chitti dot.....!"));

            output = formDemo.TwoInputFields("10", "10");
            Assert.That(output, Is.EqualTo("20"));
        }
        [Test, Order(2)]
        [Category("Batch 1")]
        public void SeleniumEasyChekBoxTest()
        {
            CheckBoxDemoPage checkBoxDemo = selPageTest.SelectCheckBoxDemo();
            var message = checkBoxDemo.SelectSimpleCheckBox();
            Assert.That(message, Is.EqualTo("Success - Check box is checked"));

            var checkBoxValidate = checkBoxDemo.SelectMultipleCheckBox();
            var uncheckBoxValidate = checkBoxDemo.SelectMultipleCheckBox();
            Assert.AreNotEqual(uncheckBoxValidate, checkBoxValidate);
        }
        [Test, Order(3)]
        [Category("Batch 1")]
        public void SeleniumRadioBoxTest()
        {
            RadioButtonDemoPage radioButtonDemo = selPageTest.SelectRadioButtonDemo();
            radioButtonDemo.SelectMaleRadioButton();
            radioButtonDemo.SelectFemaleRadioButton();
            radioButtonDemo.SelectMaleAndAgeGroup1();
            radioButtonDemo.SelectMaleAndAgeGroup2();
            radioButtonDemo.SelectMaleAndAgeGroup3();
            radioButtonDemo.SelectFemaleAndAgeGroup1();
            radioButtonDemo.SelectFemaleAndAgeGroup2();
            radioButtonDemo.SelectFemaleAndAgeGroup3();
        }
        [Test, Order(4)]
        [Category("Batch 1")]
        public void SeleniumDropDownTest()
        {
            SelectDropDownListPage ddlPage = selPageTest.SelectDropDownListDemo();
            ddlPage.SingleList("Monday");
            ddlPage.MultiSelectList("Texas", "Ohio");
        }
        [Test, Order(5)]
        [Category("Batch 1")]
        public void SeleniumJavaScriptAlertTest()
        {
            JavaScriptAlertPage alertPage = selPageTest.SelectJavaScriptAlert();
            alertPage.SelectJavaScriptAlertBox();
            alertPage.SelectJavaScriptConfirmBox();
            driver.SwitchTo().Alert().Accept();
            alertPage.SelectJavaScriptConfirmBox();
            driver.SwitchTo().Alert().Dismiss();
            alertPage.SelectJavaScriptPromptBox();
            driver.SwitchTo().Alert().SendKeys("Hi!! i am psyco");
            driver.SwitchTo().Alert().Accept();
        }
        [Test, Order(6)]
        [Category("Batch 1")]
        public void SeleniumWindowPopupModalTest()
        {
            WindowPopupModalPage windowPopUp = selPageTest.SelectWindowPopupModal();
            var currentWindow = driver.CurrentWindowHandle;
            windowPopUp.ClickOnFollowOnTwitter();
            HandleWindowPopUp(windowPopUp, currentWindow, "Twitter");
            windowPopUp.ClickLikeUsOnFaceBook();
            HandleWindowPopUp(windowPopUp, currentWindow, "Facebook");
            windowPopUp.ClickFollowTwitterAndFacebook();
            HandleWindowPopUp(windowPopUp, currentWindow, "Twitter");
            HandleWindowPopUp(windowPopUp, currentWindow, "Facebook");
            windowPopUp.ClickFollowAll();
            HandleWindowPopUp(windowPopUp, currentWindow, "Facebook");
            HandleWindowPopUp(windowPopUp, currentWindow, "Twitter");
            HandleWindowPopUp(windowPopUp, currentWindow, "Google Chrome");
        }
        [Test, Order(7)]
        [Category("Batch 1")]
        public void SeleniumBootStrapAlertTest()
        {
            BootStrapAlertPage bootstrapalertPage = selPageTest.SelectBootStrapAlert();
            bootstrapalertPage.ClickOnAll();
        }
        [Test, Order(8)]
        [Category("Batch 1")]
        public void SeleniumBootStarpModalTest1()
        {
            BootStarpModalPage bootStrapModalPage = selPageTest.SelectBootStrapModal();
            bootStrapModalPage.LaunchSingleModalExample();
        }
        [Test, Order(9)]
        [Category("Batch1")]
        public void SeleniumBootStarpModalTest2()
        {
            BootStarpModalPage bootStrapModalPage = selPageTest.SelectBootStrapModal();
            bootStrapModalPage.LaunchMulpleModalExample();
        }

        #endregion

        #region Private Helper Methods
        private static void HandleWindowPopUp(WindowPopupModalPage windowPopUp, string currentWindow, string windowTitleToClose)
        {
            var windows = windowPopUp.HandleWindowPopUp();
            foreach (var item in windows)
            {
                driver.SwitchTo().Window(item);
                var titleText = driver.Title;
                if (driver.Title.Contains(windowTitleToClose))
                {
                    driver.Close();
                }
                driver.SwitchTo().Window(currentWindow);
            }
        }
        #endregion
    }
}
