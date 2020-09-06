using SeleniumFrameworkBase;
using OpenQA.Selenium;
using System;

namespace SeleniumEasyPageObjects
{
    public class InputFormWithValidationPage
    {
        #region Field
        IWebDriver driver;
        #endregion

        #region Constructor
        public InputFormWithValidationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #endregion

        #region WebElement
        private IWebElement firstName => driver.FindElement(By.Name("first_name"));
        private IWebElement lastName => driver.FindElement(By.Name("last_name"));
        private IWebElement eMail => driver.FindElement(By.Name("email"));
        private IWebElement phone => driver.FindElement(By.Name("phone"));
        private IWebElement address => driver.FindElement(By.Name("address"));
        private IWebElement city => driver.FindElement(By.Name("city"));
        private IWebElement state => driver.FindElement(By.Name("state"));
        private IWebElement zipCode => driver.FindElement(By.Name("zip"));
        private IWebElement websiteOrDomain => driver.FindElement(By.Name("website"));
        private IWebElement hosting_yes => driver.FindElement(By.CssSelector("[name='hosting'][value='yes']"));
        private IWebElement hosting_no => driver.FindElement(By.CssSelector("[name='hosting'][value='no']"));
        private IWebElement projectDescription => driver.FindElement(By.Name("comment"));
        private IWebElement sendButton => driver.FindElement(By.CssSelector(".btn.btn-default"));
        #endregion

        #region Methods
        public void FirstName(string _firstName)
        {
            firstName.SetTextValue(_firstName);
        }
        public void LastName(string _lastName)
        {
            lastName.SetTextValue(_lastName);
        }
        public void EMail(string _email)
        {
            eMail.SetTextValue(_email);
        }
        public void Phone(string _phoneNumber)
        {
            phone.SetTextValue(_phoneNumber);
        }
        public void Address(string _address)
        {
            address.SetTextValue(_address);
        }
        public void City(string _city)
        {
            city.SetTextValue(_city);
        }
        public void State(string _state)
        {
            state.SelectFromDropDown("Florida");
        }
        public void ZipCode(string _zipCode)
        {
            zipCode.SetTextValue(_zipCode);
        }
        public void WebSiteOrDomain(string _websiteDomain)
        {
            websiteOrDomain.SetTextValue(_websiteDomain);
        }
        public void HasHosting(bool _hasHosting = true)
        {
            if (_hasHosting == true)
            {
                hosting_yes.PerformCLick();
            }
            else
            {
                hosting_no.PerformCLick();
            }
        }
        public void ProjectDescription(string _projectDescription)
        {
            projectDescription.SetTextValue(_projectDescription);
        }
        public void Send()
        {
            sendButton.PerformCLick();
        }

        #endregion
    }
}
