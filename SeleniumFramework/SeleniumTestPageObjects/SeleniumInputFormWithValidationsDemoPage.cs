using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPageObjects
{
    public class SeleniumInputFormWithValidationsDemoPage
    {
        IWebDriver driver;

        public SeleniumInputFormWithValidationsDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement firstName => driver.FindElement(By.Name("first_name"));
        IWebElement lastName => driver.FindElement(By.Name("last_name"));
        IWebElement email => driver.FindElement(By.Name("email"));
        IWebElement phone => driver.FindElement(By.Name("phone"));
        IWebElement address => driver.FindElement(By.Name("address"));
        IWebElement city => driver.FindElement(By.Name("city"));
        IWebElement state => driver.FindElement(By.Name("state"));
        IWebElement zipCode => driver.FindElement(By.Name("zip"));
        IWebElement website => driver.FindElement(By.Name("website"));
        IList<IWebElement> haveHosting => driver.FindElements(By.Name("hosting"));
        IWebElement projectDescription => driver.FindElement(By.Name("comment"));
        IWebElement sendButton => driver.FindElement(By.XPath("//button[text()='Send ']"));

        public void FillInputForm(string first_Name,string last_Name,string e_mail,string _phone,string _address,string _city,
            string _state,string zip_Code,string web_site,bool have_Hosting,string project_Description)
        {
            firstName.SendKeys(first_Name);
            lastName.SendKeys(last_Name);
            email.SendKeys(e_mail);
            phone.SendKeys(_phone);
            address.SendKeys(_address);
            city.SendKeys(_city);
            SelectElement select = new SelectElement(state);
            select.SelectByText(_state);
            zipCode.SendKeys(zip_Code);
            website.SendKeys(web_site);
            if (have_Hosting = true)
            {
                haveHosting[0].Click();
            }
            else
            {
                haveHosting[1].Click();
            }
            projectDescription.SendKeys(project_Description);
            sendButton.Click();
        }

    }
}
