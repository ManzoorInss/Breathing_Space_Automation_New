using OpenQA.Selenium;
using BSS_Automation_Framework.Utilities;

namespace BSSTestAutomation.Pages
{
    public class BSSClientAddPreviousNamePage
    {
        private IWebDriver _driver;

        private By ErrorSummaryBy => By.Id("error-summary");

        public BSSClientAddPreviousNamePage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements
        public IWebElement ClientAddPreviousNameBtn => _driver.FindElement(By.Id("client-names-add-prev-name"));
        public IWebElement ClientDetailsPageTitle => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));
        public IWebElement ClientDetailsPageFirstName => _driver.FindElement(By.Id("FirstName-input"));
        public IWebElement ClientDetailsMiddleName => _driver.FindElement(By.Id("MiddleName-input"));
        public IWebElement ClientDetailsPageLastName => _driver.FindElement(By.Id("LastName-input"));
        public IWebElement ClientDetailsPageDobDay => _driver.FindElement(By.Id("dob-day-input"));
        public IWebElement ClientDetailsPageDobMonth => _driver.FindElement(By.Id("dob-month-input"));
        public IWebElement ClientDetailsPageDobYear => _driver.FindElement(By.Id("dob-year-input"));
        public IWebElement ClientDetailsPageSaveButton => _driver.FindElement(By.Id("save-button"));
        public IWebElement ClientDetailsPageErrorSummary => _driver.FindElement(By.Id("error-summary"));
        public IWebElement ClientDetailsPageErrorSummaryErrors => _driver.FindElement(By.Id("error-list"));
        public IWebElement ClientDetailsPageFnameValidation => _driver.FindElement(By.Id("FirstName-validation"));
        public IWebElement ClientDetailsPageLnameValidation => _driver.FindElement(By.Id("LastName-validation"));
        public IWebElement ClientDetailsPageDobValidation => _driver.FindElement(By.Id("dob-validation"));
        public IWebElement ClientAddPreviousNameLink => _driver.FindElement(By.Id("client-names-add-prev-name"));
        public IWebElement ClientChangeNameLink => _driver.FindElement(By.Id("client-name-summary-chng-curr-name"));
        public IWebElement ClickclientNameSaveBtn => _driver.FindElement(By.Id("client-names-save-continue"));
        public IWebElement ErrorSummary => _driver.FindElement(By.Id("error-summary"));


        //Methods

        public void AddOrChangeClientPreviousName(string update, string firstName = "", string middleName = "", string lastName = "", string birthDay = "", string birthMonth = "", string birthYear = "", string clientDetailsFieldValue = "")
        {
            // empty or null clientDetailsFieldValue
            //if (string.IsNullOrWhiteSpace(clientDetailsFieldValue))
            //{
            //    Console.WriteLine("ClientDetailsFieldValue is empty or null. Proceeding with default behavior.");
            //    ClickclientNameSaveBtn.Click();
            //    return;
            //}

          
            bool checkValidationErrors = clientDetailsFieldValue.Equals("CheckFieldValidation", StringComparison.OrdinalIgnoreCase);

            switch (update.ToLower())
            {
                case "change name":
                    ClickChangeName();
                    NameFillOrValidateFields(firstName, middleName, lastName, birthDay, birthMonth, birthYear, checkValidationErrors);
                    SubmitForm();
                    break;

                case "add previous name":
                    ClickAddPreviousName();
                    PreviousNameFillOrValidateFields(firstName, middleName, lastName,checkValidationErrors);
                    SubmitForm();
                    break;

                default:
                    Console.WriteLine("No specific update provided. Proceeding with default behavior.");
                    SubmitForm();
                    break;
            }
        }

        public void NameFillOrValidateFields(string firstName, string middleName, string lastName, string birthDay, string birthMonth, string birthYear, bool checkValidationErrors)
        {
            if (checkValidationErrors)
            {
                SubmitForm();
                ValidateEmptyFields();
                FillAllFields(firstName, middleName, lastName, birthDay, birthMonth, birthYear);


                Console.WriteLine("Validation errors confirmed for empty fields.");
            }
            else
            {
                FillAllFields(firstName, middleName, lastName, birthDay, birthMonth, birthYear);
                Console.WriteLine("Fields filled successfully.");
            }
        }
        public void PreviousNameFillOrValidateFields(string firstName, string middleName, string lastName,bool checkValidationErrors)
        {
            if (checkValidationErrors)
            {
                SubmitForm();
                ValidateEmptyFields();
                AddPreviousNameFillAllFields(firstName, middleName, lastName);
                Console.WriteLine("Validation errors confirmed for empty fields.");
            }
            else
            {
                AddPreviousNameFillAllFields(firstName, middleName, lastName);
                Console.WriteLine("Fields filled successfully.");
            }
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
        public void AddPreviousNameFillAllFields(string firstName, string middleName, string lastName)
        {
            FieldHelper.FillField(ClientDetailsPageFirstName, firstName);
            FieldHelper.FillField(ClientDetailsMiddleName, middleName);
            FieldHelper.FillField(ClientDetailsPageLastName, lastName);

        }

        public void ValidateEmptyFields()
        {
            FieldHelper.ValidateFieldError(ClientDetailsPageFirstName, ClientDetailsPageFnameValidation);
            FieldHelper.ValidateFieldError(ClientDetailsPageLastName, ClientDetailsPageLnameValidation);
        }

        public void ClickChangeName()
        {
            ClientChangeNameLink.Click();
            Console.WriteLine("Clicked 'Change Name'.");
        }

        public void ClickAddPreviousName()
        {
            ClientAddPreviousNameBtn.Click();
            Console.WriteLine("Clicked 'Add Previous Name'.");
        }

        public void SubmitForm()
        {
            ClientDetailsPageSaveButton.Click();
            Console.WriteLine("Clicked 'Submit' button.");
        }

        public void AssertNoValidationErrors()
        {
            if (HasErrors())
            {
                throw new Exception("Form has validation errors.");
            }
            Console.WriteLine("Form has no validation errors.");
        }

        public bool HasErrors()
        {
            return ErrorSummary.Displayed;
        }
    }
}



















































//using System;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSClientDetailsPage
//    {
//        private readonly IWebDriver _driver;

//        public BSSClientDetailsPage(IWebDriver driver)
//        {
//            _driver = driver;
//        }

//        // Page Elements

//        // Page Title
//        public IWebElement ClientDetailsPageTitle => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));

//        // First Name
//        public IWebElement ClientDetailsPageFirstName => _driver.FindElement(By.Id("FirstName-input"));

//        // Middle Name
//        public IWebElement ClientDetailsMiddleName => _driver.FindElement(By.Id("MiddleName-input"));

//        // Last Name
//        public IWebElement ClientDetailsPageLastName => _driver.FindElement(By.Id("LastName-input"));

//        // Date of Birth Day
//        public IWebElement ClientDetailsPageDobDay => _driver.FindElement(By.Id("dob-day-input"));

//        // Date of Birth Month
//        public IWebElement ClientDetailsPageDobMonth => _driver.FindElement(By.Id("dob-month-input"));

//        // Date of Birth Year
//        public IWebElement ClientDetailsPageDobYear => _driver.FindElement(By.Id("dob-year-input"));

//        // Save Button
//        public IWebElement ClientDetailsPageSaveButton => _driver.FindElement(By.Id("save-button"));

//        // Error Summary
//        public IWebElement ClientDetailsPageErrorSummary => _driver.FindElement(By.Id("error-summary"));

//        // Error Summary Errors
//        public IWebElement ClientDetailsPageErrorSummaryErrors => _driver.FindElement(By.Id("error-list"));

//        // Validation Errors
//        public IWebElement ClientDetailsPageFnameValidation => _driver.FindElement(By.Id("FirstName-validation"));
//        public IWebElement ClientDetailsPageLnameValidation => _driver.FindElement(By.Id("LastName-validation"));
//        public IWebElement ClientDetailsPageDobValidation => _driver.FindElement(By.Id("dob-validation"));

//        /// <summary>
//        /// Fills out the client details form and saves it.
//        /// </summary>
//        /// <param name="firstName">First Name</param>
//        /// <param name="middleName">Middle Name (Optional)</param>
//        /// <param name="lastName">Last Name</param>
//        /// <param name="dobDay">Date of Birth Day</param>
//        /// <param name="dobMonth">Date of Birth Month</param>
//        /// <param name="dobYear">Date of Birth Year</param>
//        public void FillOutClientDetails(string firstName, string middleName, string lastName, int dobDay, int dobMonth, int dobYear)
//        {
//            // Validate and fill First Name
//            if (string.IsNullOrWhiteSpace(firstName))
//                throw new ArgumentException("First Name is required.");
//            ClientDetailsPageFirstName.Clear();
//            ClientDetailsPageFirstName.SendKeys(firstName);

//            // Fill Middle Name (Optional)
//            if (!string.IsNullOrWhiteSpace(middleName))
//            {
//                ClientDetailsMiddleName.Clear();
//                ClientDetailsMiddleName.SendKeys(middleName);
//            }

//            // Validate and fill Last Name
//            if (string.IsNullOrWhiteSpace(lastName))
//                throw new ArgumentException("Last Name is required.");
//            ClientDetailsPageLastName.Clear();
//            ClientDetailsPageLastName.SendKeys(lastName);

//            // Validate and fill Date of Birth
//            if (dobDay <= 0 || dobDay > 31)
//                throw new ArgumentOutOfRangeException(nameof(dobDay), "Invalid day for Date of Birth.");
//            if (dobMonth <= 0 || dobMonth > 12)
//                throw new ArgumentOutOfRangeException(nameof(dobMonth), "Invalid month for Date of Birth.");
//            if (dobYear <= 1900 || dobYear > DateTime.Now.Year)
//                throw new ArgumentOutOfRangeException(nameof(dobYear), "Invalid year for Date of Birth.");

//            ClientDetailsPageDobDay.Clear();
//            ClientDetailsPageDobDay.SendKeys(dobDay.ToString());
//            ClientDetailsPageDobMonth.Clear();
//            ClientDetailsPageDobMonth.SendKeys(dobMonth.ToString());
//            ClientDetailsPageDobYear.Clear();
//            ClientDetailsPageDobYear.SendKeys(dobYear.ToString());

//            // Click Save Button
//            ClientDetailsPageSaveButton.Click();
//        }

//        /// <summary>
//        /// Validates the error messages on the page.
//        /// </summary>
//        public void ValidateErrorMessages()
//        {
//            if (!string.IsNullOrEmpty(ClientDetailsPageFnameValidation.Text))
//                throw new Exception($"Validation Error: {ClientDetailsPageFnameValidation.Text}");
//            if (!string.IsNullOrEmpty(ClientDetailsPageLnameValidation.Text))
//                throw new Exception($"Validation Error: {ClientDetailsPageLnameValidation.Text}");
//            if (!string.IsNullOrEmpty(ClientDetailsPageDobValidation.Text))
//                throw new Exception($"Validation Error: {ClientDetailsPageDobValidation.Text}");
//        }
//    }
//}