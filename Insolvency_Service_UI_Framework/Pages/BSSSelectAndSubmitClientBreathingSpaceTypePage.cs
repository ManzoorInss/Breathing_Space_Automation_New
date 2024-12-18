using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace BSSTestAutomation.Pages
{
    public class BSSSelectAndSubmitClientBreathingSpaceTypePage
    {
        private readonly IWebDriver _driver;
        private BSSDebtorEligibilityConfirmationPage _bSSDebtorEligibilityConfirmationPage;
        private BSSAddNominatedPointOfContactPage _bSSAddNominatedPointOfContactPage;
        private BSSDebtorContactPreferencePage _debtorContactPreferencePage;

        public BSSSelectAndSubmitClientBreathingSpaceTypePage(IWebDriver driver,BSSDebtorEligibilityConfirmationPage bSSDebtorEligibilityConfirmationPage, BSSAddNominatedPointOfContactPage bSSAddNominatedPointOfContactPage, BSSDebtorContactPreferencePage debtorContactPreferencePage)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
            _bSSDebtorEligibilityConfirmationPage = bSSDebtorEligibilityConfirmationPage;
            _bSSAddNominatedPointOfContactPage = bSSAddNominatedPointOfContactPage;
            _debtorContactPreferencePage = debtorContactPreferencePage;
        }

        // Page Elements
        public IWebElement PageHeader => _driver.FindElement(By.CssSelector(".govuk-fieldset__heading"));
        public IWebElement ErrorSummary => _driver.FindElement(By.Id("error-summary"));
        public IWebElement ErrorList => _driver.FindElement(By.Id("error-list"));
        public IWebElement StandardOption => _driver.FindElement(By.Id("submit-standard"));
        public IWebElement StandardOptionHint => _driver.FindElement(By.Id("submit-yes-hint"));
        public IWebElement MentalHealthOption => _driver.FindElement(By.Id("submit-mental-health"));
        public IWebElement MentalHealthOptionHint => _driver.FindElement(By.Id("submit-no-hint"));
        public IWebElement SaveAndContinueButton => _driver.FindElement(By.Id("save-button"));

        // Methods
        public void ValidatePageHeader(string expectedHeader)
        {
            string actualHeader = PageHeader.Text.Trim();
            if (!actualHeader.Equals(expectedHeader, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page header mismatch. Expected: '{expectedHeader}', but got: '{actualHeader}'.");
            }
            Console.WriteLine($"Page header validated successfully: {actualHeader}");
        }

        public void SelectBreathingSpaceType(string breathingSpaceType, string nominatedContactRole, string fullName, string telephone, string email, string confirmEmail, string preference)
        {
            switch (breathingSpaceType.Trim().ToLower())
            {
                case "standard":
                    StandardOption.Click();
                    ClickSaveAndContinue();
                    Console.WriteLine("Selected 'Standard Breathing Space' option.");
                    break;

                case "mental health":
                    MentalHealthOption.Click();
                    ClickSaveAndContinue();
                    _bSSDebtorEligibilityConfirmationPage.ConfirmEligibilityAndProceed();
                    _bSSAddNominatedPointOfContactPage.AddPointOfContactRole(nominatedContactRole, fullName, telephone, email, confirmEmail, preference);

                    Console.WriteLine("Selected 'Mental Health Breathing Space' option.");
                    break;

                default:
                    throw new ArgumentException($"Invalid option: {SelectBreathingSpaceType}. Expected 'Standard' or 'Mental Health'.");
            }
        }

        public void ValidateErrorMessage(string expectedErrorMessage)
        {
            if (!ErrorSummary.Displayed)
            {
                throw new Exception("Error summary is not displayed.");
            }

            string actualErrorMessage = ErrorList.Text.Trim();
            if (!actualErrorMessage.Contains(expectedErrorMessage, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Error message mismatch. Expected to contain: '{expectedErrorMessage}', but got: '{actualErrorMessage}'.");
            }
            Console.WriteLine($"Error message validated successfully: {actualErrorMessage}");
        }

        public void ClickSaveAndContinue()
        {
            SaveAndContinueButton.Click();
            Console.WriteLine("Clicked 'Save and Continue' button.");
        }
    }
}
