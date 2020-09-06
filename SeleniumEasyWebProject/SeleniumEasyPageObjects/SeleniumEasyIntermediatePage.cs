using SeleniumFrameworkBase;
using OpenQA.Selenium;

namespace SeleniumEasyPageObjects
{
    public class SeleniumEasyIntermediatePage
    {
        private IWebDriver driver;

        public SeleniumEasyIntermediatePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement InputFormwithValidations => driver.FindElement(By.LinkText("Input Form with Validations"));
        IWebElement AjaxFormSubmit => driver.FindElement(By.LinkText("Ajax Form Submit"));
        IWebElement JQuerySelectdropdown => driver.FindElement(By.LinkText("JQuery Select dropdown"));
        IWebElement BootstrapListBox => driver.FindElement(By.LinkText("Bootstrap List Box"));
        IWebElement JQueryListBox => driver.FindElement(By.LinkText("JQuery List Box"));
        IWebElement DataListFilter => driver.FindElement(By.LinkText("Data List Filter"));
        IWebElement ProgressBarModal => driver.FindElement(By.LinkText("Progress Bar Modal"));
        IWebElement FileDownload => driver.FindElement(By.LinkText("File Download"));

        public void SelectInputFormwithValidations()
        {
            InputFormwithValidations.PerformCLick();
        }
        public void SelectAjaxFormSubmit()
        {
            AjaxFormSubmit.PerformCLick();
        }
        public void SelectJQuerySelectdropdown()
        {
            JQuerySelectdropdown.PerformCLick();
        }
        public void SelectBootstrapListBox()
        {
            BootstrapListBox.PerformCLick();
        }
        public void SelectDataListFilter()
        {
            DataListFilter.PerformCLick();
        }
        public void SelectProgressBarModal()
        {
            ProgressBarModal.PerformCLick();
        }
        public void SelectFileDownload()
        {
            FileDownload.PerformCLick();
        }
    }
}
