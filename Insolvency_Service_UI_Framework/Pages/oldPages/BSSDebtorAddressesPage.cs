using System;
using System.Reflection.PortableExecutable;
using BSSTestAutomation.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BSSTestAutomation.Pages
{
    public class BSSDebtorAddressesPage
    {
        private IWebDriver _driver;
        private BSSCommonAddressPage _bsscommonAddressPage;

        public BSSDebtorAddressesPage(IWebDriver driver, BSSCommonAddressPage bSSCommonAddressPage)
        {
            _driver = driver;
            _bsscommonAddressPage = bSSCommonAddressPage;
        }

        // Page Elements

        public IWebElement HideAddressLink => _driver.FindElement(By.Id("debtor-summary-hide-curr-add"));
        public IWebElement HiddenAddressLabel => _driver.FindElement(By.Id("debtor-address-hide-lbl-0"));
        public IWebElement HiddenAddressMessage => _driver.FindElement(By.Id("debtor-address-hide-msg-0"));
        public IWebElement PageTitle => _driver.FindElement(By.ClassName("govuk-heading-xl"));
        public IWebElement AddressLine1 => _driver.FindElement(By.Id("debtor-summary-curr-address1"));
        public IWebElement AddressLine2 => _driver.FindElement(By.Id("debtor-summary-curr-address2"));
        public IWebElement AddressTown => _driver.FindElement(By.Id("debtor-summary-curr-towncity"));
        public IWebElement AddressCounty => _driver.FindElement(By.Id("debtor-summary-curr-county"));
        public IWebElement AddressPostcode => _driver.FindElement(By.Id("debtor-summary-curr-postcode"));
        public IWebElement ChangeCurrentAddress => _driver.FindElement(By.Id("debtor-summary-chng-curr-add"));
        public IWebElement HideCurrentAddress => _driver.FindElement(By.Id("debtor-summary-hide-curr-add"));
        public IWebElement AddNewAddress => _driver.FindElement(By.ClassName("govuk-button"));
        public IWebElement SaveAndContinue => _driver.FindElement(By.Id("debtor-address-summary-save"));
        public IWebElement AddPreviousAddressButton => _driver.FindElement(By.Id("debtor-addresses-add-prev-address"));
        public IWebElement PreviousAddressHeader => _driver.FindElement(By.Id("debtor-details-prev-add-header-1"));
        public IWebElement PrevAddressChangeLink => _driver.FindElement(By.Id("debtor-summary-chng-prev-add-1"));
        public IWebElement PrevAddress2ChangeLink => _driver.FindElement(By.Id("debtor-summary-chng-prev-add-2"));
        public IWebElement PrevAddressDeleteLink => _driver.FindElement(By.Id("debtor-summary-del-prev-add-1"));
        public IWebElement MovedInText => _driver.FindElement(By.Id("debtor-address-move-in-txt"));
        public IWebElement MovedOutText => _driver.FindElement(By.Id("debtor-address-move-out-txt"));
        public IWebElement LastThreeYearsHeader => _driver.FindElement(By.Id("debtor-addresses-add-client-msg"));
        public IWebElement PrevAddressMessage => _driver.FindElement(By.Id("debtor-addresses-helper-msg"));
        public IWebElement PrevAddressLine1 => _driver.FindElement(By.Id("debtor-summary-prev-address1-1"));
        public IWebElement AddPreviousAddressLink => _driver.FindElement(By.Id("debtor-addresses-add-prev-address"));
        public IWebElement DebtorAddressSummarySaveBtn => _driver.FindElement(By.Id("debtor-address-summary-saves"));
        public IWebElement HideAddressYes => _driver.FindElement(By.Id("submit-yes"));
        public IWebElement HideAddressSave => _driver.FindElement(By.Id("debtor-hide-add-save"));

        //Methods

        public void UpdateAddressDetails(string update, string line1 = "", string line2 = "", string townCity = "", string county = "", string postcode = "", string country = "", string specificAddress = null)
        {
            switch (update.ToLower())
            {
                case "changecurrentaddress":
                    ClickChangeCurrentAddress();
                    _bsscommonAddressPage.EnterPostcodeAndFindAddress(postcode, specificAddress);
                    ClickDebtorAddressSummarSaveAndContinue();
                    break;

                case "hideadress":
                    ClickHideCurrentAddress();
                    HideAddressYes.Click();
                    HideAddressSave.Click();
                    ClickDebtorAddressSummarSaveAndContinue();
                    break;

                case "addpreviousaddress":
                    ClickAddPrevAddressLink();
                    _bsscommonAddressPage.EnterPostcodeAndFindAddress(postcode, specificAddress);
                    ClickDebtorAddressSummarSaveAndContinue();
                    break;

                case "entermanualaddress":
                    ClickPrevAddressDeleteLink();
                    _bsscommonAddressPage.EnterAddressManually(line1, line2, townCity, county, postcode, country);
                    ClickDebtorAddressSummarSaveAndContinue();
                    break;

                default:
                    Console.WriteLine($"Invalid update: {update}. Clicking Save and Continue.");
                    ClickDebtorAddressSummarSaveAndContinue();
                    break;
            }
        }
        public void ClickSaveAndContinue()
        {
            SaveAndContinue.Click();

        }
        public void ValidatePageHeader(string expectedHeader)
        {
            string actualHeader = PageTitle.Text.Trim();

            if (!actualHeader.Equals(expectedHeader, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page header mismatch. Expected: '{expectedHeader}', Actual: '{actualHeader}'");
            }

            Console.WriteLine($"Page header validated successfully: '{actualHeader}'");
        }
    
        public void ClickDebtorAddressSummarSaveAndContinue()
        {
            SaveAndContinue.Click();

        }
        public void ClickAddNewAddress()
        {
            AddNewAddress.Click();
        }
      
        public void ClickHideCurrentAddress()
        {
            HideCurrentAddress.Click();
        }

        public void ClickChangeCurrentAddress()
        {
            ChangeCurrentAddress.Click();
        }

        public void ClickPrevAddressDeleteLink()
        {
            PrevAddressDeleteLink.Click();
        }
        public void ClickAddPrevAddressLink()
        {
            AddPreviousAddressLink.Click();
        }
    }
}