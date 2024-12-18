
using OpenQA.Selenium;
using BSS_Automation_Framework.Utilities;
using OpenQA.Selenium.Support.UI;
using System.Reflection.PortableExecutable;

namespace BSSTestAutomation.Pages
{
    public class BSSClientNameDetailsPage
    {
        private IWebDriver _driver;
        private By ErrorSummaryBy => By.Id("error-summary");

        public BSSClientNameDetailsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements
        public IWebElement ClientDetailsPageTitle => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));
        public IWebElement ClientDetailsPageFirstName => _driver.FindElement(By.Id("FirstName-input"));
        public IWebElement ClientDetailsMiddleName => _driver.FindElement(By.Id("MiddleName-input"));
        public IWebElement ClientDetailsPageLastName => _driver.FindElement(By.Id("LastName-input"));
        public IWebElement ClientDetailsPageDobDay => _driver.FindElement(By.Id("dob-day-input"));
        public IWebElement ClientDetailsPageDobMonth => _driver.FindElement(By.Id("dob-month-input"));
        public IWebElement ClientDetailsPageDobYear => _driver.FindElement(By.Id("dob-year-input"));
        public IWebElement ClientDetailsPageSaveButton => _driver.FindElement(By.Id("save-button"));
        public IWebElement ClientDetailsPageErrorSummary => _driver.FindElement(By.Id("error-summary"));

        public IWebElement ClientDetailsPageFnameValidation => _driver.FindElement(By.Id("FirstName-validation"));
        public IWebElement ClientDetailsPageLnameValidation => _driver.FindElement(By.Id("LastName-validation"));
        public IWebElement ClientDetailsPageDobValidation => _driver.FindElement(By.Id("dob-validation"));

        //Methods
        public void ClientDetails(string clientDetailsFieldValue, string firstName, string middleName, string lastName, string birthDay, string birthMonth, string birthYear)
        {
            Console.WriteLine($"Handling Client Details for value: '{clientDetailsFieldValue}'");

            // empty or null ClientDetailsFieldValue
            if (string.IsNullOrWhiteSpace(clientDetailsFieldValue))
            {
                Console.WriteLine("ClientDetailsFieldValue is empty or null. Proceeding with default behavior.");
                FillAndSubmitForm(firstName, middleName, lastName, birthDay, birthMonth, birthYear);
                return;
            }

            bool isValidationErrorCase = clientDetailsFieldValue.Equals("CheckFieldValidation", StringComparison.OrdinalIgnoreCase);

            switch (clientDetailsFieldValue.ToLowerInvariant())
            {
                case "checkfieldvalidation":
                    FillOrValidateFields(firstName, middleName, lastName, birthDay, birthMonth, birthYear, isValidationErrorCase);
                    Console.WriteLine("Validation errors confirmed for empty fields, then form submitted successfully after corrections.");
                    break;

                default:
                    Console.WriteLine($"Unknown ClientDetailsFieldValue: {clientDetailsFieldValue}");
                    throw new ArgumentException($"Unknown ClientDetailsFieldValue: {clientDetailsFieldValue}");
            }
        }


        private void FillOrValidateFields(string firstName, string middleName, string lastName, string birthDay, string birthMonth, string birthYear, bool isValidationErrorCase)
        {
            if (isValidationErrorCase)
            {
                SubmitEmptyFormAndValidate(firstName, middleName, lastName, birthDay, birthMonth, birthYear);
                Console.WriteLine("Validation errors confirmed for empty fields.");
            }
            else
            {
                FillAndSubmitForm(firstName, middleName, lastName, birthDay, birthMonth, birthYear);
                Console.WriteLine("Fields filled successfully.");
            }
        }

        private void FillAndSubmitForm(string firstName, string middleName, string lastName, string birthDay, string birthMonth, string birthYear)
        {
            FillAllFields(firstName, middleName, lastName, birthDay, birthMonth, birthYear);
            SubmitForm();

            if (HasErrors())
            {
                throw new Exception("Form submission failed. Errors are present on the page even though fields were filled.");
            }
        }

        private void SubmitEmptyFormAndValidate(string firstName, string middleName, string lastName, string birthDay, string birthMonth, string birthYear)
        {
            SubmitForm();

            if (!HasErrors())
            {
                throw new Exception("Expected validation errors, but none were displayed after submitting an empty form.");
            }

            ValidateEmptyFields();
            FillAndSubmitForm(firstName, middleName, lastName, birthDay, birthMonth, birthYear);
        }

        public void FillAllFields(string firstName, string middleName, string lastName, string birthDay, string birthMonth, string birthYear)
        {
            FieldHelper.FillField(ClientDetailsPageFirstName, firstName);
            FieldHelper.FillField(ClientDetailsMiddleName, middleName);
            FieldHelper.FillField(ClientDetailsPageLastName, lastName);
            FieldHelper.FillField(ClientDetailsPageDobDay, birthDay);
            FieldHelper.FillField(ClientDetailsPageDobMonth, birthMonth);
            FieldHelper.FillField(ClientDetailsPageDobYear, birthYear);
        }

        public void SubmitForm()
        {
            ClientDetailsPageSaveButton.Click();
        }

        public void ValidateEmptyFields()
        {
            FieldHelper.ValidateFieldError(ClientDetailsPageFirstName, ClientDetailsPageFnameValidation);
            FieldHelper.ValidateFieldError(ClientDetailsPageLastName, ClientDetailsPageLnameValidation);
            FieldHelper.ValidateFieldError(ClientDetailsPageDobDay, ClientDetailsPageDobValidation);
            FieldHelper.ValidateFieldError(ClientDetailsPageDobMonth, ClientDetailsPageDobValidation);
            FieldHelper.ValidateFieldError(ClientDetailsPageDobYear, ClientDetailsPageDobValidation);
        }

        public bool HasErrors()
        {
            var errorSummaries = _driver.FindElements(ErrorSummaryBy);
            return errorSummaries.Count > 0 && errorSummaries[0].Displayed;
        }
        public void ValidateClientDetailsPageTitle(string expectedHeader)
        {
            // Fetch the actual header text
            string actualHeader = ClientDetailsPageTitle.Text.Trim();

            // Compare actual and expected header text
            if (!actualHeader.Equals(expectedHeader, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page header mismatch. Expected: '{expectedHeader}', Actual: '{actualHeader}'");
            }

            Console.WriteLine($"Page header validated successfully: '{actualHeader}'");
        }
    }
}
    






//using OpenQA.Selenium;
//using BSS_Automation_Framework.Utilities;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSClientDetailsPage
//    {
//        private IWebDriver _driver;
//        private By ErrorSummaryBy => By.Id("error-summary");


//        public BSSClientDetailsPage(IWebDriver driver)
//        {
//            _driver = driver;
//        }

//        // Page Elements
//        public IWebElement ClientDetailsPageTitle => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));
//        public IWebElement ClientDetailsPageFirstName => _driver.FindElement(By.Id("FirstName-input"));
//        public IWebElement ClientDetailsMiddleName => _driver.FindElement(By.Id("MiddleName-input"));
//        public IWebElement ClientDetailsPageLastName => _driver.FindElement(By.Id("LastName-input"));
//        public IWebElement ClientDetailsPageDobDay => _driver.FindElement(By.Id("dob-day-input"));
//        public IWebElement ClientDetailsPageDobMonth => _driver.FindElement(By.Id("dob-month-input"));
//        public IWebElement ClientDetailsPageDobYear => _driver.FindElement(By.Id("dob-year-input"));
//        public IWebElement ClientDetailsPageSaveButton => _driver.FindElement(By.Id("save-button"));
//        public IWebElement ClientDetailsPageErrorSummary => _driver.FindElement(By.Id("error-summary"));
//        public IWebElement ClientDetailsPageErrorSummaryErrors => _driver.FindElement(By.Id("error-list"));
//        public IWebElement ClientDetailsPageFnameValidation => _driver.FindElement(By.Id("FirstName-validation"));
//        public IWebElement ClientDetailsPageLnameValidation => _driver.FindElement(By.Id("LastName-validation"));
//        public IWebElement ClientDetailsPageDobValidation => _driver.FindElement(By.Id("dob-validation"));

//        public void FillAllFields(string firstName, string middleName, string lastName, string birthDay, string birthMonth, string birthYear)
//        {
//            FieldHelper.FillField(ClientDetailsPageFirstName, firstName);
//            FieldHelper.FillField(ClientDetailsMiddleName, middleName);
//            FieldHelper.FillField(ClientDetailsPageLastName, lastName);
//            FieldHelper.FillField(ClientDetailsPageDobDay, birthDay);
//            FieldHelper.FillField(ClientDetailsPageDobMonth, birthMonth);
//            FieldHelper.FillField(ClientDetailsPageDobYear, birthYear);
//        }

//        public void SubmitForm()
//        {
//            ClientDetailsPageSaveButton.Click();
//        }


//        public void ValidateEmptyFields()
//        {
//            FieldHelper.ValidateFieldError(ClientDetailsPageFirstName, ClientDetailsPageFnameValidation);
//            FieldHelper.ValidateFieldError(ClientDetailsPageLastName, ClientDetailsPageLnameValidation);
//            FieldHelper.ValidateFieldError(ClientDetailsPageDobDay, ClientDetailsPageDobValidation);
//            FieldHelper.ValidateFieldError(ClientDetailsPageDobMonth, ClientDetailsPageDobValidation);
//            FieldHelper.ValidateFieldError(ClientDetailsPageDobYear, ClientDetailsPageDobValidation);
//        }

//        public bool HasErrors()
//        {

//            // Use FindElements to avoid NoSuchElementException
//            var errorSummaries = _driver.FindElements(ErrorSummaryBy);
//            if (errorSummaries.Count > 0)
//            {
//                return errorSummaries[0].Displayed;
//            }
//            return false; // No error summary element found, so no errors
//        }
//    }
//}













































////using System;
////using OpenQA.Selenium;
////using OpenQA.Selenium.Support.UI;

////namespace BSSTestAutomation.Pages
////{
////    public class BSSClientDetailsPage
////    {
////        private readonly IWebDriver _driver;

////        public BSSClientDetailsPage(IWebDriver driver)
////        {
////            _driver = driver;
////        }

////        // Page Elements

////        // Page Title
////        public IWebElement ClientDetailsPageTitle => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));

////        // First Name
////        public IWebElement ClientDetailsPageFirstName => _driver.FindElement(By.Id("FirstName-input"));

////        // Middle Name
////        public IWebElement ClientDetailsMiddleName => _driver.FindElement(By.Id("MiddleName-input"));

////        // Last Name
////        public IWebElement ClientDetailsPageLastName => _driver.FindElement(By.Id("LastName-input"));

////        // Date of Birth Day
////        public IWebElement ClientDetailsPageDobDay => _driver.FindElement(By.Id("dob-day-input"));

////        // Date of Birth Month
////        public IWebElement ClientDetailsPageDobMonth => _driver.FindElement(By.Id("dob-month-input"));

////        // Date of Birth Year
////        public IWebElement ClientDetailsPageDobYear => _driver.FindElement(By.Id("dob-year-input"));

////        // Save Button
////        public IWebElement ClientDetailsPageSaveButton => _driver.FindElement(By.Id("save-button"));

////        // Error Summary
////        public IWebElement ClientDetailsPageErrorSummary => _driver.FindElement(By.Id("error-summary"));

////        // Error Summary Errors
////        public IWebElement ClientDetailsPageErrorSummaryErrors => _driver.FindElement(By.Id("error-list"));

////        // Validation Errors
////        public IWebElement ClientDetailsPageFnameValidation => _driver.FindElement(By.Id("FirstName-validation"));
////        public IWebElement ClientDetailsPageLnameValidation => _driver.FindElement(By.Id("LastName-validation"));
////        public IWebElement ClientDetailsPageDobValidation => _driver.FindElement(By.Id("dob-validation"));

////        /// <summary>
////        /// Fills out the client details form and saves it.
////        /// </summary>
////        /// <param name="firstName">First Name</param>
////        /// <param name="middleName">Middle Name (Optional)</param>
////        /// <param name="lastName">Last Name</param>
////        /// <param name="dobDay">Date of Birth Day</param>
////        /// <param name="dobMonth">Date of Birth Month</param>
////        /// <param name="dobYear">Date of Birth Year</param>
////        public void FillOutClientDetails(string firstName, string middleName, string lastName, int dobDay, int dobMonth, int dobYear)
////        {
////            // Validate and fill First Name
////            if (string.IsNullOrWhiteSpace(firstName))
////                throw new ArgumentException("First Name is required.");
////            ClientDetailsPageFirstName.Clear();
////            ClientDetailsPageFirstName.SendKeys(firstName);

////            // Fill Middle Name (Optional)
////            if (!string.IsNullOrWhiteSpace(middleName))
////            {
////                ClientDetailsMiddleName.Clear();
////                ClientDetailsMiddleName.SendKeys(middleName);
////            }

////            // Validate and fill Last Name
////            if (string.IsNullOrWhiteSpace(lastName))
////                throw new ArgumentException("Last Name is required.");
////            ClientDetailsPageLastName.Clear();
////            ClientDetailsPageLastName.SendKeys(lastName);

////            // Validate and fill Date of Birth
////            if (dobDay <= 0 || dobDay > 31)
////                throw new ArgumentOutOfRangeException(nameof(dobDay), "Invalid day for Date of Birth.");
////            if (dobMonth <= 0 || dobMonth > 12)
////                throw new ArgumentOutOfRangeException(nameof(dobMonth), "Invalid month for Date of Birth.");
////            if (dobYear <= 1900 || dobYear > DateTime.Now.Year)
////                throw new ArgumentOutOfRangeException(nameof(dobYear), "Invalid year for Date of Birth.");

////            ClientDetailsPageDobDay.Clear();
////            ClientDetailsPageDobDay.SendKeys(dobDay.ToString());
////            ClientDetailsPageDobMonth.Clear();
////            ClientDetailsPageDobMonth.SendKeys(dobMonth.ToString());
////            ClientDetailsPageDobYear.Clear();
////            ClientDetailsPageDobYear.SendKeys(dobYear.ToString());

////            // Click Save Button
////            ClientDetailsPageSaveButton.Click();
////        }

////        /// <summary>
////        /// Validates the error messages on the page.
////        /// </summary>
////        public void ValidateErrorMessages()
////        {
////            if (!string.IsNullOrEmpty(ClientDetailsPageFnameValidation.Text))
////                throw new Exception($"Validation Error: {ClientDetailsPageFnameValidation.Text}");
////            if (!string.IsNullOrEmpty(ClientDetailsPageLnameValidation.Text))
////                throw new Exception($"Validation Error: {ClientDetailsPageLnameValidation.Text}");
////            if (!string.IsNullOrEmpty(ClientDetailsPageDobValidation.Text))
////                throw new Exception($"Validation Error: {ClientDetailsPageDobValidation.Text}");
////        }
////    }
////}