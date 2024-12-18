using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BSSTestAutomation.Pages
{
    public class BSSDebtorBreathingSpaceTypePage
    {
        private readonly IWebDriver _driver;

        public BSSDebtorBreathingSpaceTypePage(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        // Page Elements (using Selenium's By locators)

        // Page Title
        public IWebElement PageTitle => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));

        // Submit Mental Health Radio Button
        public IWebElement SubmitMentalHealthRadioButton => _driver.FindElement(By.Id("submit-mental-health"));

        // Submit Mental Health Label
        public IWebElement SubmitMentalHealthLabel => _driver.FindElement(By.CssSelector("#submit-mental-health + label"));

        // Submit Yes Hint
        public IWebElement SubmitYesHint => _driver.FindElement(By.Id("submit-yes-hint"));

        // Submit Standard Radio Button
        public IWebElement SubmitStandardRadioButton => _driver.FindElement(By.Id("submit-standard"));

        // Submit No Hint
        public IWebElement SubmitNoHint => _driver.FindElement(By.Id("submit-no-hint"));

        // Save Button
        public IWebElement SaveButton => _driver.FindElement(By.Id("save-button"));

        // Back Link
        public IWebElement BackLink => _driver.FindElement(By.Id("back-link"));

        // Error Summary
        public IWebElement ErrorSummary => _driver.FindElement(By.Id("error-summary"));

        // Field Error Message
        public IWebElement FieldError => _driver.FindElement(By.ClassName("govuk-error-message"));

        /// <summary>
        /// Clicks the Save button.
        /// </summary>
        public void ClickSave()
        {
            SaveButton.Click();
            // Optionally, add a wait for the next page to load if necessary.
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.Url.Contains("next-page-url-part"));  // Replace with actual URL part of the next page.
        }

        /// <summary>
        /// Selects the Mental Health radio button.
        /// </summary>
        public void SelectMentalHealth()
        {
            if (!SubmitMentalHealthRadioButton.Selected)
            {
                SubmitMentalHealthRadioButton.Click();
            }
        }

        /// <summary>
        /// Selects the Standard radio button.
        /// </summary>
        public void SelectStandard()
        {
            if (!SubmitStandardRadioButton.Selected)
            {
                SubmitStandardRadioButton.Click();
            }
        }

    }
}