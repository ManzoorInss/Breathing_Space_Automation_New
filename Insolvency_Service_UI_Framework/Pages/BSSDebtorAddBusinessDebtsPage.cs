using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BSS_Automation_Framework.Pages
{
    public class BSSDebtorAddBusinessDebtsPage
    {
        private IWebDriver _driver;

        public BSSDebtorAddBusinessDebtsPage(IWebDriver driver)
        {
            _driver = driver ;
        }

        // Page Elements
        public IWebElement PageTitle => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));
        public IWebElement SaveAndContinueButton => _driver.FindElement(By.Id("debtor-business-save"));
        public IWebElement SubmitNo => _driver.FindElement(By.Id("submit-no"));
        public IWebElement SubmitYes => _driver.FindElement(By.Id("submit-yes"));
        public IWebElement BackButtonLink => _driver.FindElement(By.Id("back-link"));
        public IWebElement ErrorSummary => _driver.FindElement(By.Id("error-summary"));
        public IWebElement ErrorList => _driver.FindElement(By.Id("error-list"));
        public IWebElement ErrorMessage => _driver.FindElement(By.CssSelector("fieldset.govuk-fieldset span"));

        public void BusinessDetails(string option)
        {
            if (string.IsNullOrWhiteSpace(option))
            {
                throw new ArgumentException("Option cannot be null or empty.", nameof(option));
            }

            switch (option.ToLower())
            {
                case "yes":
                    SelectYes();
                    Console.WriteLine("Selected 'Yes' option.");
                    break;

                case "no":
                    SelectNo();
                    Console.WriteLine("Selected 'No' option.");
                    break;

                default:
                    throw new ArgumentException($"Invalid option: {option}. Expected 'Yes' or 'No'.");
            }

            ClickSaveAndContinue();
        }

        public void ValidatePageTitle(string expectedTitle)
        {
            string actualTitle = PageTitle.Text.Trim();
            expectedTitle = expectedTitle.Trim();

            if (!actualTitle.Equals(expectedTitle, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page title mismatch. Expected: {expectedTitle}, Actual: {actualTitle}");
            }

            Console.WriteLine($"Page title validated successfully: {actualTitle}");
        }

        public void ValidateErrorMessage()
        {
            if (!ErrorSummary.Displayed || !ErrorList.Displayed)
            {
                throw new Exception("Expected validation error message not displayed.");
            }
            Console.WriteLine("Validation error message displayed as expected.");
        }

        private void ClickSaveAndContinue()
        {
            SaveAndContinueButton.Click();
            Console.WriteLine("Clicked 'Save and Continue' button.");

        }

        private void SelectNo()
        {
            if (!SubmitNo.Selected)
            {
                SubmitNo.Click();
            }
        }

        private void SelectYes()
        {
            if (!SubmitYes.Selected)
            {
                SubmitYes.Click();
            }
        }
    }
}


