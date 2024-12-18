using System;
using NUnit.Framework;
using OpenQA.Selenium;
using BSS_Automation_Framework.Utilities;
using BSSTestAutomation.Pages;
using System.Reflection.PortableExecutable;

namespace BSSTestAutomation.Pages
{
    public class BSSDebtorContactPreferencePage
    {
        private IWebDriver _driver;

        public BSSDebtorContactPreferencePage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements
        public IWebElement PageTitle => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));
        public IWebElement PageHeader => _driver.FindElement(By.ClassName("govuk-heading-xl"));
        public IWebElement BackLink => _driver.FindElement(By.Id("back-link"));
        public IWebElement SubmitEmail => _driver.FindElement(By.Id("submit-email"));
        public IWebElement Email => _driver.FindElement(By.Id("EmailAddress-input"));
        public IWebElement ConfirmEmail => _driver.FindElement(By.Id("ConfirmEmailAddress-input"));
        public IWebElement EmailValidation => _driver.FindElement(By.Id("EmailAddress-validation"));
        public IWebElement ConfirmEmailValidation => _driver.FindElement(By.Id("ConfirmEmailAddress-validation"));
        public IWebElement EmailLabel => _driver.FindElement(By.Id("EmailAddress-label"));
        public IWebElement ConfirmEmailLabel => _driver.FindElement(By.Id("ConfirmEmailAddress-label"));
        public IWebElement SubmitPost => _driver.FindElement(By.Id("submit-post"));
        public IWebElement SubmitNone => _driver.FindElement(By.Id("submit-none"));
        public IWebElement SubmitNoneText => _driver.FindElement(By.CssSelector("input#submit-none+label"));
        public IWebElement SaveAndContinueBtn => _driver.FindElement(By.Id("save-button"));
        public IWebElement ErrorList => _driver.FindElement(By.Id("error-list"));
        public IWebElement SelectEmail => _driver.FindElement(By.Id("confirmation-method-email"));



        // debtor contact preference, validates missing preferences, and processes Email, Post, or None options.
        public void ValidatePageTitleAndHeader(string expectedTitle)
        {
            string actualTitle = PageTitle.Text.Trim();
           /// string actualHeader = PageHeader.Text.Trim();

            if (!actualTitle.Equals(expectedTitle, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page title mismatch. Expected: '{expectedTitle}', Actual: '{actualTitle}'");
            }

            Console.WriteLine($"Page title and header validated: Title = '{actualTitle}'");
        }

     
        /// Handles contact preferences based on the data table input.
       
        public void ContactPreference(string preference, string email = "", string confirmEmail = "")
        {
            if (string.IsNullOrWhiteSpace(preference) || preference.Equals("No", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("No preference selected. Validating error message.");
                SaveAndContinue();
                ValidateErrorMessage("Please select an option");
                SelectNonePreference();
                SaveAndContinue();
                return;
            }

            switch (preference.ToLower())
            {
                case "email":
                    SelectEmailPreference(email, confirmEmail);
                    break;

                case "post":
                    SelectPostPreference();
                    break;

                case "none":
                    SelectNonePreference();
                    break;

                default:
                    throw new ArgumentException($"Invalid contact preference: {preference}");
            }

        }

        public void SelectEmailPreference(string email, string confirmEmail)
        {
            try
            {
                // Check and handle Submit Email button
                //if (SubmitEmail.Enabled)
                //{
                //    SubmitEmail.Click();
                //    Console.WriteLine("Submit Email button clicked.");
                //}
                //else
                //{
                //    SelectEmail.Click();
                //    Console.WriteLine("Submit Email button is not enabled. Selected Email option instead.");
                //}

                Console.WriteLine("Selected 'Email' preference.");

                // Enter email if provided
                if (!string.IsNullOrWhiteSpace(email))
                {
                    SubmitEmail.Click();
                    Email.Clear();
                    Email.SendKeys(email);
                    Console.WriteLine($"Entered Email: {email}");
                }

                // Enter confirm email if provided
                if (!string.IsNullOrWhiteSpace(confirmEmail))
                {
                    ConfirmEmail.Clear();
                    ConfirmEmail.SendKeys(confirmEmail);
                    Console.WriteLine($"Entered Confirm Email: {confirmEmail}");
                }
            }
            catch (Exception ex)
            {
                // Log and rethrow for external error handling
                Console.WriteLine($"Error in SelectEmailPreference: {ex.Message}");
                throw;
            }
        }


        public void SelectPostPreference()
        {
            SubmitPost.Click();
            Console.WriteLine("Selected 'Post' preference.");
        }

        public void SelectNonePreference()
        {
            SubmitNone.Click();
            Console.WriteLine("Selected 'None' preference.");
        }

        public void SaveAndContinue()
        {
            SaveAndContinueBtn.Click();
            Console.WriteLine("Clicked 'Save and Continue' button.");
        }

        public void ValidateErrorMessage(string expectedErrorMsg)
        {
            if (!ErrorList.Displayed)
            {
                throw new Exception("Expected validation message not displayed.");
            }

            string actualErrorMsg = ErrorList.Text.Trim();
            if (!actualErrorMsg.Equals(expectedErrorMsg, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Validation message mismatch. Expected: '{expectedErrorMsg}', Actual: '{actualErrorMsg}'");
            }

            Console.WriteLine($"Validation message validated: '{actualErrorMsg}'");
        }
    }
}






