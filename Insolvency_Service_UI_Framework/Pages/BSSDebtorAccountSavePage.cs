using OpenQA.Selenium;
using System;

namespace BSSTestAutomation.Pages
{
    public class BSSDebtorBreathingSpaceAccountSubmitPage
    {
        private readonly IWebDriver _driver;

        public BSSDebtorBreathingSpaceAccountSubmitPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements
        public IWebElement PageTitle => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));
        public IWebElement SubmitYesRadioButton => _driver.FindElement(By.Id("submit-yes"));
        public IWebElement SubmitYesHint => _driver.FindElement(By.Id("radio-yes-item-hint"));
        public IWebElement SubmitNoRadioButton => _driver.FindElement(By.Id("submit-no"));
        public IWebElement SubmitNoHint => _driver.FindElement(By.Id("radio-no-item-hint"));
        public IWebElement SaveAndContinueButton => _driver.FindElement(By.Id("save-button"));

        // Methods
        public void SubmitBreathingSpace(string submitOption)
        {
            if (string.IsNullOrWhiteSpace(submitOption))
            {
                throw new ArgumentException("Submit option cannot be null or empty.", nameof(submitOption));
            }

            switch (submitOption.Trim().ToLower())
            {
                case "yes":
                    SelectYes();
                    break;

                case "no":
                    SelectNo();
                    break;

                default:
                    HandleValidationError();
                    break;
            }

            SaveAndContinueButton.Click();
            Console.WriteLine($"Submitted Breathing Space with option: {submitOption}");
        }

        public void HandleValidationError()
        {
            SaveAndContinueButton.Click();
            if (IsValidationErrorDisplayed())
            {
                Console.WriteLine("Validation error displayed: Please select an option yes or no.");
                throw new Exception("Validation error: Submit option was not selected.");
            }
        }
        public bool IsValidationErrorDisplayed()
        {
            try
            {
                var errorElement = _driver.FindElement(By.Id("submit-option-error-message"));
                return errorElement.Displayed && errorElement.Text.Contains("Please select an option yes or no");
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void SelectYes()
        {
            SubmitYesRadioButton.Click();
            if (!SubmitYesRadioButton.Selected)
            {
                throw new Exception("Failed to select the 'Yes' radio button.");
            }
            Console.WriteLine("Selected 'Yes' radio button.");
        }

        public void SelectNo()
        {
            SubmitNoRadioButton.Click();
            if (!SubmitNoRadioButton.Selected)
            {
                throw new Exception("Failed to select the 'No' radio button.");
            }
            Console.WriteLine("Selected 'No' radio button.");
        }

        public void ClickSaveButton()
        {
            SubmitYesRadioButton.Click();
            Console.WriteLine("Clicked the Save button.");
        }

        public string GetPageTitle()
        {
            return PageTitle.Text.Trim();
        }

        public void ThenThePageTitleShouldBe(string expectedTitle)
        {
            var actualTitle = GetPageTitle();
            if (!actualTitle.Equals(expectedTitle, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page title mismatch. Expected: '{expectedTitle}', but got: '{actualTitle}'");
            }
            Console.WriteLine($"Page title is correct: '{actualTitle}'");
        }
    }
}
