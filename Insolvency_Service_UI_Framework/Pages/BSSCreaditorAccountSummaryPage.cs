using System;
using BSSTestAutomation.Common;
using OpenQA.Selenium;


namespace BSSTestAutomation.Pages
{
    public class BSSCreaditorAccountSummaryPage
    {
        private IWebDriver _driver;
        private BSSAddADebtAndCreditorPage _bSSAddADebtAndCreditorPage;
        private BSSCommonAddressPage _commonAddressPage;
        private BSSDebtorContactPreferencePage _debtorContactPreferencePage;

        // PageElements
        public IWebElement PageTitle => _driver.FindElement(By.Id("debt-details-heading"));
        public IWebElement CreditorName => _driver.FindElement(By.Id("creditor-name"));
        public IWebElement ChangeCreditorNameLink => _driver.FindElement(By.Id("creditor-name-change"));
        public IWebElement CreditorAddressLine1 => _driver.FindElement(By.Id("creditor-address-line1"));
        public IWebElement ChangeCreditorAddressLink => _driver.FindElement(By.Id("creditor-address-change"));
        public IWebElement DebtTypeLabel => _driver.FindElement(By.Id("debt-details-debt-type"));
        public IWebElement DebtAmount => _driver.FindElement(By.Id("debt-amount"));
        public IWebElement DebtReference => _driver.FindElement(By.Id("debt-reference"));
        public IWebElement ChangeDebtLink => _driver.FindElement(By.Id("debt-change"));
        public IWebElement NotificationMethodLabel => _driver.FindElement(By.Id("creditor-details-notification-method-header"));
        public IWebElement NotificationPreference => _driver.FindElement(By.Id("creditor-summary-notification-method-preference"));
        public IWebElement ChangeNotificationPreferenceLink => _driver.FindElement(By.Id("creditor-details-notification-preference-chng"));
        public IWebElement EmailAddressLabel => _driver.FindElement(By.Id("creditor-details-notification-email-header"));
        public IWebElement EmailAddress => _driver.FindElement(By.Id("creditor-summary-notification-method-email"));
        public IWebElement ChangeEmailAddressLink => _driver.FindElement(By.Id("creditor-details-notification-email-chng"));
        public IWebElement SaveAndContinueButton => _driver.FindElement(By.Id("next-step"));
        public IWebElement SaveSummaryButton => _driver.FindElement(By.Id("debtor-summary-save"));

        // Methods
        public BSSCreaditorAccountSummaryPage(IWebDriver driver, BSSAddADebtAndCreditorPage bSSAddADebtAndCreditorPage, BSSDebtorContactPreferencePage debtorContactPreferencePage, BSSCommonAddressPage bSSCommonAddressPage)
        {
            _driver = driver;
            _bSSAddADebtAndCreditorPage = bSSAddADebtAndCreditorPage;
            _debtorContactPreferencePage = debtorContactPreferencePage;
            _commonAddressPage = bSSCommonAddressPage;
        }
        public void UpdateCreditorAccountSummary(
            string update,
            string creditorName,
            string findAddressPostcode,
            string preference,
            string email = "",
            string confirmEmail = "",
            string line1 = "",
            string line2 = "",
            string townCity = "",
            string postcode = "",
            string specificAddress = null,
            string debtType = "")
        {
            bool isActionPerformed = false;

            switch (update.ToLower())
            {
                case "changename":
                    ChangeCreditorName();
                    _bSSAddADebtAndCreditorPage.EnterCreditorName(creditorName);
                    _bSSAddADebtAndCreditorPage.SaveAndContinueButton.Click();
                    isActionPerformed = true;
                    break;

                case "changeaddress":
                    ChangeCreditorAddress();
                    _commonAddressPage.EnterAddress("postcode", line1, line2, townCity, "", postcode, "UK", specificAddress);
                    _bSSAddADebtAndCreditorPage.SaveAndContinueButton.Click();
                    isActionPerformed = true;
                    break;

                case "changedebt":
                    ChangeDebtDetails();
                    _bSSAddADebtAndCreditorPage.SelectDebtType(debtType);
                    _bSSAddADebtAndCreditorPage.SaveAndContinueButton.Click();
                    isActionPerformed = true;
                    break;

                case "changenotificationpreference":
                    ChangeNotificationPreference();
                    _debtorContactPreferencePage.ContactPreference(preference, email, confirmEmail);
                    _bSSAddADebtAndCreditorPage.SaveAndContinueButton.Click();
                    isActionPerformed = true;
                    break;

                case "changeemailaddress":
                    ChangeEmailAddress();
                    _debtorContactPreferencePage.SelectEmailPreference(email, confirmEmail);
                    _bSSAddADebtAndCreditorPage.SaveAndContinueButton.Click();
                    isActionPerformed = true;
                    break;

                default:
                    Console.WriteLine($"No valid action matched for update: '{update}'.");
                    break;
            }

            // Default fallback: Click Save and Continue if no action was performed
            if (!isActionPerformed)
            {
                Console.WriteLine("No action was performed. Clicking the Save and Continue button by default.");
                SaveAndContinue();
            }
        }


        public void ChangeCreditorName()
        {
            ChangeCreditorNameLink.Click();
            Console.WriteLine("Navigated to Change Creditor Name page.");
        }

        public void ChangeCreditorAddress()
        {
            ChangeCreditorAddressLink.Click();
            Console.WriteLine("Navigated to Change Creditor Address page.");
        }

        public void ChangeDebtDetails()
        {
            ChangeDebtLink.Click();
            Console.WriteLine("Navigated to Change Debt Details page.");
        }

        public void ChangeNotificationPreference()
        {
            ChangeNotificationPreferenceLink.Click();
            Console.WriteLine("Navigated to Change Notification Preference page.");
        }

        public void ChangeEmailAddress()
        {
            ChangeEmailAddressLink.Click();
            Console.WriteLine("Navigated to Change Email Address page.");
        }

        public void SaveAndContinue()
        {
            SaveAndContinueButton.Click();
            Console.WriteLine("Clicked Save and Continue button.");
            SaveSummaryButton.Click();

        }

        public void ValidatePageTitle(string expectedTitle)
        {
            string actualTitle = PageTitle.Text.Trim();
            if (!actualTitle.Equals(expectedTitle, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page title mismatch. Expected: {expectedTitle}, Actual: {actualTitle}");
            }
            Console.WriteLine($"Page title validated successfully: {actualTitle}");
        }
    }
}
