﻿using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using SeleniumTestPageObjects.Library;

namespace SeleniumTestPageObjects
{
    public class SeleniumEasyMainPage
    {
        #region Field
        IWebDriver driver;
        #endregion

        #region Construtor
        public SeleniumEasyMainPage()
        {

        }

        public SeleniumEasyMainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region WebElements

        public IWebElement startPracticing => driver.FindElement(By.Id("btn_basic_example"));
        string listOfPageNames => driver.FindElement(By.CssSelector(".list-group")).Text;
        public IWebElement proceedNext => driver.FindElement(By.Id("btn_inter_example"));

        #endregion

        #region public methods

        public void clickOnStartPracticing()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement popUpElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("at-cv-lightbox-close")));
            popUpElement.Click();
            startPracticing.Click();
            GetPageNames.GetSeleniumEasyPageNames(listOfPageNames);            
        }



        #endregion

    }
}
