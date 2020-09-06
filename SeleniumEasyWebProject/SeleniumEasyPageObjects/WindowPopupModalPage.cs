using System;
using System.Collections.Generic;
using SeleniumFrameworkBase;
using OpenQA.Selenium;

namespace SeleniumEasyPageObjects
{
    public class WindowPopupModalPage
    {
        private IWebDriver driver;

        #region constructor
        public WindowPopupModalPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region webelements
        private IWebElement FollowOnTwitter => driver.FindElement(By.LinkText("Follow On Twitter"));
        private IWebElement LikeOnFaceBook => driver.FindElement(By.LinkText("Like us On Facebook"));
        private IWebElement FollowTwitterAndFacebook => driver.FindElement(By.LinkText("Follow Twitter & Facebook"));
        private IWebElement FollowAll => driver.FindElement(By.Id("followall"));
        #endregion

        #region public methods
        public void ClickFollowAll()
        {
            FollowAll.PerformCLick();
        }

        public void ClickFollowTwitterAndFacebook()
        {
            FollowTwitterAndFacebook.PerformCLick();
        }

        public void ClickLikeUsOnFaceBook()
        {
            LikeOnFaceBook.PerformCLick();
        }

        public void ClickOnFollowOnTwitter()
        {
            FollowOnTwitter.PerformCLick();
        }
        public IReadOnlyCollection<string> HandleWindowPopUp()
        {
            var windows = driver.WindowHandles;
            return windows;
        }
#endregion 
    }
}
