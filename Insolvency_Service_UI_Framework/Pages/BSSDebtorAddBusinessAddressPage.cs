using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BSSTestAutomation.Common;
using System.Diagnostics.Metrics;

namespace BSS_Automation_Framework.Pages
{
    public class BSSDebtorAddBusinessAddressPage
    {
        private IWebDriver _driver;
        private BSSCommonAddressPage _bsscommonAddressPage;
        public BSSDebtorAddBusinessAddressPage(IWebDriver driver, BSSCommonAddressPage bsscommonAddressPage)
        {
            _driver = driver;
            _bsscommonAddressPage = bsscommonAddressPage;
        }

        // Page Elements

        public IWebElement PageTitle => _driver.FindElement(By.ClassName("govuk-heading-xl"));
        public IWebElement BackButtonLink => _driver.FindElement(By.Id("back-link"));
        public IWebElement BusinessLabel => _driver.FindElement(By.ClassName("govuk-heading-s"));
        public IWebElement BusinessNameLabel => _driver.FindElement(By.CssSelector("p.govuk-body"));
        public IWebElement ChangeBusinessNameLink => _driver.FindElement(By.CssSelector("p.govuk-body a"));
        public IWebElement PostCodeLabel => _driver.FindElement(By.Id("Postcode-label"));
        public IWebElement PostcodeTxt => _driver.FindElement(By.Id("Postcode-input"));
        public IWebElement PostCodeLabel1 => _driver.FindElement(By.Id("address-search-sub-heading"));
        public IWebElement PostCodeValue => _driver.FindElement(By.Id("address-search-selected-postcode"));
        public IWebElement PostCodeChangeLink => _driver.FindElement(By.CssSelector("#address-search-selected-postcode a"));
        public IWebElement ChangePostCodeLink => _driver.FindElement(By.Id("address-search-change-postcode"));
        public IWebElement FindAddressBtn => _driver.FindElement(By.Id("search-button"));
        public IWebElement ManualAddressLink => _driver.FindElement(By.Id("address-manual"));
        public IWebElement SelectAddress => _driver.FindElement(By.Id("SelectedAddress"));
        public IWebElement ErrorPostcode => _driver.FindElement(By.Id("Postcode-validation"));
        public IWebElement ErrorList => _driver.FindElement(By.Id("error-list"));
        public IWebElement SaveAndContinueBtn => _driver.FindElement(By.Id("save-button"));

        // Methods

        public void FindAddressWithPostcode(string line1, string line2, string townCity, string county, string postcode, string country, string specificAddress = null)
        {
            _bsscommonAddressPage.EnterAddress(line1, line2, townCity, county, postcode, country, specificAddress);
        }

        /// Clicks the Save and Continue button.
    
        public void ClickSaveAndContinue()
        {
            SaveAndContinueBtn.Click();

        }
    }
}






//public void EnterPostcode(string postcode)
//{
//    PostcodeTxt.Clear();
//    PostcodeTxt.SendKeys(postcode);
//    FindAddressBtn.Click();  // Assuming clicking this button will find the address based on the postcode.
//    // Optionally, add a wait for address results to load.
//    var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
//    wait.Until(drv => drv.FindElements(By.CssSelector(".address-results")).Count > 0);  // Replace with actual selector for address results.
//}