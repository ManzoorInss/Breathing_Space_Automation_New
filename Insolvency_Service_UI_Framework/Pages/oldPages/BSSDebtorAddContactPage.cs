using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BSSTestAutomation.Pages
{
    public class BSSDebtorAddContactPage
    {
        private readonly IWebDriver _driver;

        public BSSDebtorAddContactPage(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        // Page Elements (using Selenium's By locators)

        // Title for adding nominated point of contact
        public IWebElement AddNominatedPointOfContactTitle => _driver.FindElement(By.ClassName("govuk-heading-l"));

        // Page body text
        public IWebElement PageBody => _driver.FindElement(By.CssSelector("p.govuk-body"));

        // Validation message for point of contact
        public IWebElement PointOfContactValidation => _driver.FindElement(By.CssSelector("fieldset > span"));

        // Full name validation message
        public IWebElement FullNameValidation => _driver.FindElement(By.Id("FullName-validation"));

        // Validation message for confirmation method
        public IWebElement ConfirmMethodValidation => _driver.FindElement(By.CssSelector("#content > form > div:nth-child(20) > fieldset > span"));

        // Error summary title
        public IWebElement ErrorSummary => _driver.FindElement(By.ClassName("govuk-error-summary__title"));

        // Error list element
        public IWebElement ErrorList => _driver.FindElement(By.CssSelector("#error-list ul"));

        // Save and continue button
        public IWebElement SaveAndContinue => _driver.FindElement(By.Id("debtor-nominated-contact-save"));

        // Header for contact method selection
        public IWebElement ContactByHeader => _driver.FindElement(By.CssSelector("#content > form > div:nth-child(20) > fieldset > legend > label"));

        // Telephone validation message
        public IWebElement TelephoneValidation => _driver.FindElement(By.Id("TelephoneNumber-validation"));

        // Telephone input field
        public IWebElement TelephoneField => _driver.FindElement(By.Id("TelephoneNumber-input"));

        // Full name input field
        public IWebElement FullNameField => _driver.FindElement(By.Id("FullName-input"));

        // Email confirmation radio button
        public IWebElement EmailRadioButton => _driver.FindElement(By.Id("confirmation-method-email"));

        // Post confirmation radio button
        public IWebElement PostRadioButton => _driver.FindElement(By.Id("confirmation-method-post"));

        // Email validation message
        public IWebElement EmailValidation => _driver.FindElement(By.Id("EmailAddress-validation"));

        // Confirm email validation message
        public IWebElement ConfirmEmailValidation => _driver.FindElement(By.Id("ConfirmEmailAddress-validation"));

        // Email input field
        public IWebElement EmailField => _driver.FindElement(By.Id("EmailAddress-input"));

        // Confirm email input field
        public IWebElement ConfirmEmailField => _driver.FindElement(By.Id("ConfirmEmailAddress-input"));

        // Health professional radio button
        public IWebElement HealthProfessionalRadioButton => _driver.FindElement(By.Id("point-contact-health-pro"));


        /// <summary>
        /// Clicks the Save and Continue button.
        /// </summary>
        public void ClickSaveAndContinue()
        {
            SaveAndContinue.Click();
            // Optionally, add a wait for the next page to load if necessary.
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.Url.Contains("next-page-url-part"));  // Replace with actual URL part of the next page.
        }

        /// <summary>
        /// Enters the full name into the input field.
        /// </summary>
        /// <param name="fullName">The full name to enter.</param>
        public void EnterFullName(string fullName)
        {
            FullNameField.Clear();
            FullNameField.SendKeys(fullName);
        }

        /// <summary>
        /// Enters the telephone number into the input field.
        /// </summary>
        /// <param name="telephone">The telephone number to enter.</param>
        public void EnterTelephone(string telephone)
        {
            TelephoneField.Clear();
            TelephoneField.SendKeys(telephone);
        }

        /// <summary>
        /// Enters the email address into the input field.
        /// </summary>
        /// <param name="email">The email address to enter.</param>
        public void EnterEmail(string email)
        {
            EmailField.Clear();
            EmailField.SendKeys(email);
        }

        /// <summary>
        /// Enters the confirm email address into the input field.
        /// </summary>
        /// <param name="confirmEmail">The confirm email address to enter.</param>
        public void EnterConfirmEmail(string confirmEmail)
        {
            ConfirmEmailField.Clear();
            ConfirmEmailField.SendKeys(confirmEmail);
        }

        /// <summary>
        /// Selects the email confirmation method.
        /// </summary>
        public void SelectEmailConfirmation()
        {
            if (!EmailRadioButton.Selected)
            {
                EmailRadioButton.Click();
            }
        }

        /// <summary>
        /// Selects the post confirmation method.
        /// </summary>
        public void SelectPostConfirmation()
        {
            if (!PostRadioButton.Selected)
            {
                PostRadioButton.Click();
            }
        }

        /// <summary>
        /// Selects health professional as a point of contact.
        /// </summary>
        public void SelectHealthProfessional()
        {
            if (!HealthProfessionalRadioButton.Selected)
            {
                HealthProfessionalRadioButton.Click();
            }
        }
    }
}