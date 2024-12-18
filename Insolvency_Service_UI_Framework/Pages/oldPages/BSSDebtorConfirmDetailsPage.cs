using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BSSTestAutomation.Pages
{
    public class BSSDebtorConfirmDetailsPage
    {
        private readonly IWebDriver _driver;

        public BSSDebtorConfirmDetailsPage(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        // Page Elements (using Selenium's By locators)

        // Page Title
        public IWebElement PageTitle => _driver.FindElement(By.ClassName("govuk-heading-xl"));

        // Page Detail Summary
        public IWebElement PageDetailSummary => _driver.FindElement(By.ClassName("govuk-heading-l"));

        // Personal Details Heading
        public IWebElement PageDetailPersonalDetails => _driver.FindElement(By.Id("debtor-personal-detail-heading"));

        // Address Details Heading
        public IWebElement PageDetailAddressDetails => _driver.FindElement(By.CssSelector("#content > form > h2:nth-child(5)"));

        // Debtor Name
        public IWebElement DebtorName => _driver.FindElement(By.Id("debtor-confirm-name"));

        // Debtor Name Change Link
        public IWebElement DebtorNameChangeLink => _driver.FindElement(By.Id("debtor-confirm-change-name"));

        // Debtor Date of Birth
        public IWebElement DebtorDateofBirth => _driver.FindElement(By.Id("debtor-confirm-dob"));

        // Debtor Date of Birth Change Link
        public IWebElement DebtorDateofBirthChangeLink => _driver.FindElement(By.Id("debtor-confirm-change-dob"));

        // Add Previous Name Link
        public IWebElement AddPreviousNameLink => _driver.FindElement(By.Id("debtor-details-add-prev-name"));

        // Address Line 1
        public IWebElement AddressLine1 => _driver.FindElement(By.Id("debtor-summary-curr-address1"));

        // Address Line 2
        public IWebElement AddressLine2 => _driver.FindElement(By.Id("debtor-summary-curr-address2"));

        // Town/City
        public IWebElement AddressTown => _driver.FindElement(By.Id("debtor-summary-curr-towncity"));

        // County
        public IWebElement AddressCounty => _driver.FindElement(By.Id("debtor-summary-curr-county"));

        // Postcode
        public IWebElement AddressPostcode => _driver.FindElement(By.Id("debtor-summary-curr-postcode"));

        // Change Current Address Link
        public IWebElement AddressChangeLink => _driver.FindElement(By.Id("debtor-summary-chng-curr-add"));

        // Hide Current Address Link
        public IWebElement AddressHideLink => _driver.FindElement(By.Id("debtor-summary-hide-curr-add"));

        // Add Previous Address Link
        public IWebElement AddPreviousAddressLink => _driver.FindElement(By.Id("debtor-summary-add-prev-add"));

        // Save and Continue Button
        public IWebElement SaveAndContinueBtn => _driver.FindElement(By.Id("debtor-confirm-details-btn"));

        // Notification Method Preference
        public IWebElement NotificationMethod => _driver.FindElement(By.Id("debtor-summary-notification-method-preference"));

        // Email Address Field
        public IWebElement EmailAddress => _driver.FindElement(By.Id("debtor-summary-notification-method-email"));

        // Hidden Address Label
        public IWebElement AddressHiddenLabel => _driver.FindElement(By.Id("debtor-address-hide-lbl-0"));

        // Hidden Business Address Label
        public IWebElement HiddenAddressBusiness => _driver.FindElement(By.Id("debtor-address-hide-lbl-2"));

        // Hidden Current Address Message
        public IWebElement HiddenAddressCurrentAddressMsg => _driver.FindElement(By.Id("debtor-address-hide-msg-0"));

        // Hidden Business Address Message
        public IWebElement HiddenAddressBusinessAddressMsg => _driver.FindElement(By.Id("debtor-address-hide-msg-1"));

        // Update Hidden Address Link (duplicate ID, can be removed)
        public IWebElement UpdateAddressHiddenLink => _driver.FindElement(By.Id("debtor-summary-hide-curr-add"));

        // Hide Address Link (duplicate ID, can be removed)
        public IWebElement HideAddressLink => _driver.FindElement(By.Id("debtor-summary-hide-curr-add"));

        // Change Previous Name Link 
        public IWebElement ChangePreviousNameLink => _driver.FindElement(By.Id("debtor-personal-detail-prev-name-chng-1"));

        // Change Previous Address Link 
        public IWebElement ChangePreviousAddressLink => _driver.FindElement(By.Id("debtor-summary-chng-prev-add-1"));

        // Change Notification Preference Link 
        public IWebElement ChangeNotificationPreferenceLink => _driver.FindElement(By.Id("debtor-details-notification-preference-chng"));

        // Change Business Address Link 
        public IWebElement ChangeBusinessAddressLink => _driver.FindElement(By.Id("debtor-summary-chng-business-address-1"));

        // Delete Business Address Link 
        public IWebElement DeleteBusinessAddresslink1 => _driver.FindElement(By.Id("debtor-summary-del-business-address-1"));



        /// <summary>
        /// Clicks the Save and Continue button.
        /// </summary>
        public void ClickSaveAndContinue()
        {
            SaveAndContinueBtn.Click();
 
        }

        /// <summary>
        /// Clicks the Add Previous Name link.
        /// </summary>
        public void ClickAddPreviousName()
        {
            AddPreviousNameLink.Click();
        }

        /// <summary>
        /// Clicks the Change Previous Name link.
        /// </summary>
        public void ClickChangePreviousName()
        {
            ChangePreviousNameLink.Click();
        }

        /// <summary>
        /// Clicks the Change Previous Address link.
        /// </summary>
        public void ClickChangePreviousAddress()
        {
            ChangePreviousAddressLink.Click();
        }

        /// <summary>
        /// Clicks the Hide Current Address link.
        /// </summary>
        public void ClickHideCurrentAddress()
        {
            AddressHideLink.Click();
        }

        /// <summary>
        /// Clicks the Change Current Address link.
        /// </summary>
        public void ClickChangeCurrentAddress()
        {
            AddressChangeLink.Click();
        }
    }
}