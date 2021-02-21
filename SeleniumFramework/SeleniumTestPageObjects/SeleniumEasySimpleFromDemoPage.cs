using OpenQA.Selenium;

namespace SeleniumTestPageObjects
{
    public class SeleniumEasySimpleFromDemoPage
    {
        IWebDriver driver;

        public SeleniumEasySimpleFromDemoPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region webelements
        #region Basic
        IWebElement simpleFormDemo => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Simple Form Demo']"));
        IWebElement checkBoxDemo => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Check Box Demo']"));
        IWebElement radioButtonDemo => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Radio Buttons Demo']"));
        IWebElement selectDropDownList => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Select Dropdown List']"));
        IWebElement javaScriptAlerts => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Javascript Alerts']"));
        IWebElement windowPopupModal => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Window Popup Modal']"));
        IWebElement bootStrapAlerts => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Bootstrap Alerts']"));
        IWebElement bootStrapModal => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Bootstrap Modals']"));
        #endregion

        #region intermediate
        IWebElement intermediate => driver.FindElement(By.Id("inter_example"));
        IWebElement inputFormValidation => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Input Form with Validations']"));
        IWebElement ajaxsForm => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Ajax Form Submit']"));
        IWebElement jquerySelectDropdown => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='JQuery Select dropdown']"));
        IWebElement bootStrapListBox => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Bootstrap List Box']"));
        IWebElement jqueryListBox => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='JQuery List Box']"));
        IWebElement dataListFilter => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Data List Filter']"));
        IWebElement progressBarModal => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Progress Bar Modal']"));
        IWebElement fileDownload => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='File Download']"));
        #endregion

        #region advanced
        IWebElement advanced => driver.FindElement(By.Id("advanced_example"));
        IWebElement tablePagination => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Table Pagination']"));
        IWebElement tableDataSearch => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Table Data Search']"));
        IWebElement tableFilter => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Table Filter ']"));
        IWebElement tableSortAndSearch => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Table Sort & Search']"));
        IWebElement tableDataDownload => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Table Data Download']"));
        IWebElement JqueryDownloadProgressBar => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='JQuery Download Progress bars']"));
        IWebElement bootStrapDownloadProgressBar => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Bootstrap Download Progress bar']"));
        IWebElement dragAndDropSliders => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Drag & Drop Sliders']"));
        IWebElement dragAndDrop => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Drag and Drop']"));
        IWebElement dynamicDataLoading => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Dynamic Data Loading']"));
        IWebElement chartsDemo => driver.FindElement(By.XPath("//a[@class='list-group-item' and  text()='Charts Demo']"));
        #endregion

        #endregion

        #region Basic methods
        public SimpleFormDemoPage clickOnSimpleFormDemo()
        {
            simpleFormDemo.Click();
            return new SimpleFormDemoPage(driver);
        }

        public SimpleCheckBoxDemoPage clickOnCheckBoxDemo()
        {
            checkBoxDemo.Click();
            return new SimpleCheckBoxDemoPage(driver);
        }

        public SeleniumRadioButtonDemoPage clickOnRadioButtonDemo()
        {
            radioButtonDemo.Click();
            return new SeleniumRadioButtonDemoPage(driver);
        }

        public SeleniumDropDownListDemoPage clickOnDropDownListDemo()
        {
            selectDropDownList.Click();
            return new SeleniumDropDownListDemoPage(driver);
        }

        public SeleniumJavaScritAlertsDemoPage clickOnJavaScriptAlertDemo()
        {
            javaScriptAlerts.Click();
            return new SeleniumJavaScritAlertsDemoPage(driver);
        }

        public SeleniumWindowModalPopupDemoPage clickOnWindowPopupDemo()
        {
            windowPopupModal.Click();
            return new SeleniumWindowModalPopupDemoPage(driver);
        }

        public SeleniumBootstrapAlertsDemoPage clickOnBootstrapAlertDemo()
        {
            bootStrapAlerts.Click();
            return new SeleniumBootstrapAlertsDemoPage(driver);
        }

        public SeleniumBootstrapModalsDemoPage clickOnBootstrapModalsDemo()
        {
            bootStrapModal.Click();
            return new SeleniumBootstrapModalsDemoPage(driver);
        }

        #endregion

        #region Intermediate methods
        public SeleniumInputFormWithValidationsDemoPage clickOnInputFormDemo()
        {
            intermediate.Click();
            inputFormValidation.Click();
            return new SeleniumInputFormWithValidationsDemoPage(driver);
        }

        public SeleniumAjaxFormSubmitDemoPage clickOnAjaxFormDemo()
        {
            intermediate.Click();
            ajaxsForm.Click();
            return new SeleniumAjaxFormSubmitDemoPage(driver);
        }

        public SeleniumJQuerySelectDropDownDemoPage clickOnJquerySelectDropDownDemo()
        {
            intermediate.Click();
            jquerySelectDropdown.Click();
            return new SeleniumJQuerySelectDropDownDemoPage(driver);
        }

        public SeleniumBootstrapListBoxDemoPage clickOnBootStrapListBoxDemo()
        {
            intermediate.Click();
            bootStrapListBox.Click();
            return new SeleniumBootstrapListBoxDemoPage(driver);

        }

        public SeleniumJQueryListBoxDemoPage clickOnJqueryListBoxDemo()
        {
            intermediate.Click();
            jqueryListBox.Click();
            return new SeleniumJQueryListBoxDemoPage(driver);
        }

        public SeleniumDataListFilterDemoPage clickOnDataListFilterDemo()
        {
            intermediate.Click();
            dataListFilter.Click();
            return new SeleniumDataListFilterDemoPage(driver);

        }

        public SeleniumProgressBarModalDemoPage clickOnProgressBarModalDemo()
        {
            intermediate.Click();
            progressBarModal.Click();
            return new SeleniumProgressBarModalDemoPage(driver);
        }

        public SeleniumFileDownloadDemoPage clickOnFileDownloadDemo()
        {
            intermediate.Click();
            fileDownload.Click();
            return new SeleniumFileDownloadDemoPage(driver);
        }
        #endregion

        #region Advanced methods

        public SeleniumTablePaginationDemoPage clickOnTablePaginationDemo()
        {
            advanced.Click();
            tablePagination.Click();
            return new SeleniumTablePaginationDemoPage(driver);
        }

        public SeleniumTableDataSearchDemoPage clickOnTableDataSearchDemo()
        {
            advanced.Click();
            tableDataSearch.Click();
            return new SeleniumTableDataSearchDemoPage(driver);

        }

        public SeleniumTableFilterDemoPage clickOnTableFilterDemo()
        {
            advanced.Click();
            tableFilter.Click();
            return new SeleniumTableFilterDemoPage(driver);

        }

        public SeleniumTableSortAndSearchDemoPage clickOnTableSortAndSearchDemo()
        {
            advanced.Click();
            tableSortAndSearch.Click();
            return new SeleniumTableSortAndSearchDemoPage(driver);
        }

        public SeleniumTableDataDownloadDemoPage clickOnTableDataDownloadDemo()
        {
            advanced.Click();
            tableDataDownload.Click();
            return new SeleniumTableDataDownloadDemoPage(driver);
        }

        public SeleniumJqueryDownloadProgressBarDemoPage clickOnJqueryDownloadProgressBarDemo()
        {
            advanced.Click();
            JqueryDownloadProgressBar.Click();
            return new SeleniumJqueryDownloadProgressBarDemoPage(driver);
        }

        public SeleniumBootstrapDownloadProgressBarDemoPage clickOnBootStrapDownloadProgressBarDemo()
        {
            advanced.Click();
            bootStrapDownloadProgressBar.Click();
            return new SeleniumBootstrapDownloadProgressBarDemoPage(driver);
        }

        public SeleniumDragAndDropSlidersDemoPage clickOnDragAndDropSlidersDemo()
        {
            advanced.Click();
            dragAndDropSliders.Click();
            return new SeleniumDragAndDropSlidersDemoPage(driver);
        }

        public SeleniumDragAndDropDemoPage clickOnDragAndDropDemo()
        {
            advanced.Click();
            dragAndDrop.Click();
            return new SeleniumDragAndDropDemoPage(driver);
        }

        public SeleniumDynamicDataLoadingDemoPage clickOnDynamicDataLoadingDemo()
        {
            advanced.Click();
            dynamicDataLoading.Click();
            return new SeleniumDynamicDataLoadingDemoPage(driver);
        }

        public SeleniumChartsDemoPage clickOnChartsDemo()
        {
            advanced.Click();
            chartsDemo.Click();
            return new SeleniumChartsDemoPage(driver);
        }
        #endregion
    }
}
