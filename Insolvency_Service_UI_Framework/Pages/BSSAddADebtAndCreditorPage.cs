using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using BSSTestAutomation.Common;
using SeleniumExtras.WaitHelpers;
using System.Data;

namespace BSSTestAutomation.Pages
{
    public class BSSAddADebtAndCreditorPage
    {
        private IWebDriver _driver;
        private readonly BSSCommonAddressPage _commonAddressPage;
        private readonly BSSDebtorContactPreferencePage _debtorContactPreferencePage;

        public BSSAddADebtAndCreditorPage(IWebDriver driver, BSSCommonAddressPage bSSCommonAddressPag, BSSDebtorContactPreferencePage bSSDebtorContactPreferencePage)
        {
            _driver = driver;
            _commonAddressPage = bSSCommonAddressPag;
            _debtorContactPreferencePage = bSSDebtorContactPreferencePage;

        }

        //Page Elements

        public IWebElement PageTitle1 => _driver.FindElement(By.CssSelector("h2#inactive-account-debts-tab-heading"));
        public IWebElement AddDebtLink => _driver.FindElement(By.Id("debtor-summary-add-debt"));
        public IWebElement SaveAndCloseButton => _driver.FindElement(By.Id("debtor-summary-save"));
        public IWebElement ClientDetailsTab => _driver.FindElement(By.Id("tab_personal-details"));
        public IWebElement DebtsTab => _driver.FindElement(By.Id("tab_problem-debt"));
        public IWebElement PageTitle2 => _driver.FindElement(By.TagName("title"));
        public IWebElement PageHeading2 => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));
        public IWebElement AcceptCookiesButton => _driver.FindElement(By.Id("cookie-banner-accept"));
        public IWebElement RejectCookiesButton => _driver.FindElement(By.Id("cookie-banner-reject"));
        public IWebElement SaveAndContinueButton => _driver.FindElement(By.Id("save-button"));
        public IWebElement HomeLink => _driver.FindElement(By.Id("home-navigation-home-link"));
        public IWebElement SearchLink => _driver.FindElement(By.Id("home-navigation-search-link"));
        public IWebElement CreditorNameInput => _driver.FindElement(By.Id("CreditorName-input"));
        public IWebElement ErrorSummary => _driver.FindElement(By.Id("error-summary"));
        public IWebElement PrivacyLink => _driver.FindElement(By.Id("govuk-link-privacy"));
        public IWebElement CookiesLink => _driver.FindElement(By.Id("govuk-link-cookies"));
        public IWebElement PageTitle => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));
        public IWebElement BackLink => _driver.FindElement(By.Id("back-link"));
        public IWebElement AddaDebtsLink => _driver.FindElement(By.Id("debtor-summary-add-debt"));
        public IWebElement ChangeLink => _driver.FindElement(By.ClassName("govuk-link"));
        public IWebElement CreditorHeader => _driver.FindElement(By.CssSelector(".govuk-form-group h2"));
        public IWebElement CreditorName => _driver.FindElement(By.CssSelector("p.govuk-body"));
        public IWebElement ChangeCreditorLink => _driver.FindElement(By.Id("creditor-add-cmp-debt-change-call-to-action"));
        public IWebElement DebtTypeOne => _driver.FindElement(By.Id("creditor-add-cmp-debt-debt-type-name-(0)"));
        public IWebElement DebtTypeTwo => _driver.FindElement(By.Id("debt_type_2"));
        public IWebElement DebtTypeThree => _driver.FindElement(By.Id("debt_type_3"));
        public IWebElement DebtTypeFour => _driver.FindElement(By.Id("debt_type_4"));
        public IWebElement DebtTypeName => _driver.FindElement(By.Id("creditor-add-cmp-debt-debt-type-name"));
        public IWebElement DebtTypeLabel => _driver.FindElement(By.Id("creditor-add-cmp-debt-debt-type-label"));
        public IWebElement DebtType => _driver.FindElement(By.Id("SelectedDebtTypeName-input"));
        public IWebElement DebtAmount => _driver.FindElement(By.Id("DebtAmount-input"));
        public IWebElement DebtAmountValidationMessage => _driver.FindElement(By.Id("DebtAmount-validation"));
        public IWebElement Reference => _driver.FindElement(By.Id("Reference-input"));
        public IWebElement ReferenceHint => _driver.FindElement(By.Id("Reference-hint"));
        public IWebElement NationalInsuranceNo => _driver.FindElement(By.Id("NINO-input"));
        public IWebElement SaveButton => _driver.FindElement(By.Id("save-button"));
        public IWebElement ReferenceValidationMessage => _driver.FindElement(By.Id("Reference-validation"));
        public IWebElement CreditorTypeDropdown => _driver.FindElement(By.Id("creditor-type-dropdown"));
        public IWebElement CMPCreditorOption => _driver.FindElement(By.CssSelector("option[value='cmp']"));
        public IWebElement AdhocCreditorOption => _driver.FindElement(By.CssSelector("option[value='adhoc']"));
        public IWebElement PostcodeInput => _driver.FindElement(By.Id("postcode-input"));
        public IWebElement FindAddressButton => _driver.FindElement(By.Id("find-address-button"));
        public IWebElement NotificationMethodEmail => _driver.FindElement(By.Id("notification-email"));
        public IWebElement NotificationMethodPost => _driver.FindElement(By.Id("notification-post"));
        public IWebElement AddDebtTypeTitle => _driver.FindElement(By.Id("creditor-add-cmp-debt-headingt"));

        //Methods

        public void ValidatePageTitle(string expectedTitle)
        {
            string actualTitle = PageTitle.Text.Trim();
            if (!actualTitle.Equals(expectedTitle, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page title mismatch. Expected: {expectedTitle}, Actual: {actualTitle}");
            }
            Console.WriteLine($"Page title validated successfully: {actualTitle}");
        }

        public void ClickAddDebt()
        {
            AddDebtLink.Click();
            Console.WriteLine("Clicked 'Add Debt' link.");
        }

        // Method to  creditor type selection
        public void EnterCreditorTypeDetails(string creditorType, string creditorName, string postcode = "", string preference = "", string email = "", string confirmEmail = "", string debtType = "", string debtAmount = "", string reference = "")
        {
            Console.WriteLine($"creditor type: {creditorType}");

            switch (creditorType.ToLower())
            {
                case "cmp":
                    SelectCMPCreditor(creditorName, debtType, debtAmount, reference);

                    break;

                case "adhoc":
                    EnterAdhocCreditorDetails(creditorName, postcode, preference, email, confirmEmail, debtAmount, reference);
                    break;

                default:
                    throw new ArgumentException($"Invalid creditor type: {creditorType}");
            }
            ClickSaveAndContinue();

        }

        // Method to select a CMP creditor from autocomplete
        private void SelectCMPCreditor(string creditorName, string debtType, string debtAmount, string reference)
        { 
            IWebElement inputField = _driver.FindElement(By.Id("CreditorName-input"));
            inputField.Clear();
            inputField.SendKeys(creditorName);

            // Wait for autocomplete results to appear
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("autocomplete-results")));

            // Locate the autocomplete results container
            IWebElement resultsContainer = _driver.FindElement(By.Id("autocomplete-results"));

            var options = resultsContainer.FindElements(By.TagName("li"));

            if (options.Count == 0)
            {
                throw new Exception($"No autocomplete options found for input: {creditorName}");
            }

            foreach (var option in options)
            {
                if (option.Text.Equals(creditorName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Matching option found: {option.Text}");
                    option.Click(); 
                    ClickSaveAndContinue();
                    SelectDebtType(debtType);
                    EnterDebtAmount(debtAmount);
                    EnterReference(reference);
                    return; 
                }
            }
        }

        // Method to handle Adhoc creditor
        private void EnterAdhocCreditorDetails(string creditorName, string postcode, string preference, string email, string confirmEmail, string debtAmount, string reference)
        {
            CreditorNameInput.Clear();
            CreditorNameInput.SendKeys(creditorName);
            Console.WriteLine($"Entered creditor name: {creditorName}");

            ClickSaveAndContinue();
            Console.WriteLine("Saved Adhoc Creditor name and navigating to address page.");

            _commonAddressPage.EnterAddressByPostcode(postcode); 
            ClickSaveAndContinue();
            Console.WriteLine("Saved Adhoc Creditor details and navigated to Notification page.");

            CreditorNotificationPreference(preference, email, confirmEmail);
            ClickSaveAndContinue();
            EnterDebtAmount(debtAmount);
            EnterReference(reference);

        }

        // Method for notification preferences
        private void CreditorNotificationPreference(string preference, string email, string confirmEmail)
        {
            _debtorContactPreferencePage.ContactPreference(preference, email, confirmEmail);
            Console.WriteLine("Handled notification preference.");
            ClickSaveAndContinue();
        }

        // Select Notification Method
        private void SelectNotificationMethod(string notificationMethod)
        {
            switch (notificationMethod.ToLower())
            {
                case "email":
                    NotificationMethodEmail.Click();
                    break;

                case "post":
                    NotificationMethodPost.Click();
                    break;

                default:
                    throw new ArgumentException($"Invalid notification method: {notificationMethod}");
            }
        }

        public void AddCreditor(string creditorName)
        {
            // Click the "Add Debt" button
            // ClickAddDebt();
            CreditorNameInput.Clear();
            CreditorNameInput.SendKeys(creditorName + Keys.Tab);
            ClickSaveAndContinue();
            Console.WriteLine($"Creditor '{creditorName}' added successfully.");
        }


        public void SelectDebtType(string debtType)
        {
            switch (debtType.ToLower())
            {
                case "credit card":
                    DebtTypeThree.Click();
                    Console.WriteLine("Selected 'Credit Card' debt type.");
                    break;
                case "asset finance":
                    DebtTypeTwo.Click();
                    Console.WriteLine("Selected 'Asset Finance' debt type.");
                    break;
                case "debt":
                    DebtTypeOne.Click();
                    Console.WriteLine("Selected 'Debt' debt type.");
                    break;
                default:
                    throw new ArgumentException($"Invalid debt type: {debtType}");
            }
        }
        public void ValidateDebtTypePageTitle(string expectedTitle)
        {
            string actualTitle = AddDebtTypeTitle.Text.Trim();
            if (!actualTitle.Equals(expectedTitle, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page title mismatch. Expected: {expectedTitle}, Actual: {actualTitle}");
            }
            Console.WriteLine($"Page title validated successfully: {actualTitle}");
        }

        public void ChangeCreditor()
        {
            ChangeCreditorLink.Click();
            Console.WriteLine("Clicked 'Change Creditor' link.");
        }


        public void EnterDebtAmount(string debtAmount)
        {
            DebtAmount.Clear();
            DebtAmount.SendKeys(debtAmount);
            Console.WriteLine($"Entered debt amount: {debtAmount}");
        }

        public void EnterDebtType(string debtType)
        {
            DebtType.Clear();
            DebtType.SendKeys(debtType);
            Console.WriteLine($"Entered debt amount: {debtType}");
        }

        public void EnterReference(string reference)
        {
            Reference.Clear();
            Reference.SendKeys(reference);
            Console.WriteLine($"Entered reference: {reference}");
        }

        public void ClickSaveAndContinue()
        {
            SaveAndContinueButton.Click();
            Console.WriteLine("Clicked 'Save and Continue' button.");
        }

        public void ValidateErrors()
        {
            if (DebtAmountValidationMessage.Displayed)
            {
                Console.WriteLine($"Debt Amount Error: {DebtAmountValidationMessage.Text}");
            }

            if (ReferenceValidationMessage.Displayed)
            {
                Console.WriteLine($"Reference Error: {ReferenceValidationMessage.Text}");
            }
        }
        public void ClickSaveAndClose()
        {
            SaveAndCloseButton.Click();
            Console.WriteLine("Clicked 'Save and Close' button.");
        }

        public void NavigateToClientDetailsTab()
        {
            ClientDetailsTab.Click();
            Console.WriteLine("Navigated to 'Client Details' tab.");
        }

        public void AcceptCookies()
        {
            AcceptCookiesButton.Click();
            Console.WriteLine("Accepted cookies.");
        }

        public void RejectCookies()
        {
            RejectCookiesButton.Click();
            Console.WriteLine("Rejected cookies.");
        }



        public void EnterCreditorName(string creditorName)
        {
            CreditorNameInput.Clear();
            CreditorNameInput.SendKeys(creditorName);
            Console.WriteLine($"Entered creditor name: {creditorName}");
        }


        public void NavigateToHome()
        {
            HomeLink.Click();
            Console.WriteLine("Navigated to Home page.");
        }

        public void NavigateToSearch()
        {
            SearchLink.Click();
            Console.WriteLine("Navigated to Search page.");
        }

        public void ValidateErrorSummaryDisplayed()
        {
            if (!ErrorSummary.Displayed)
            {
                throw new Exception("Error summary is not displayed.");
            }

            Console.WriteLine("Error summary is displayed.");
        }

    }
}