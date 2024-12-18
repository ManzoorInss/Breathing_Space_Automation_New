using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSSTestAutomation.Pages
{
    public class BSSAddNominatedPointOfContactPage
    {
        private readonly IWebDriver _driver;
        private BSSDebtorContactPreferencePage _debtorContactPreferencePage;
        public BSSAddNominatedPointOfContactPage(IWebDriver driver, BSSDebtorContactPreferencePage debtorContactPreferencePage)
        {
            _driver = driver;
            _debtorContactPreferencePage = debtorContactPreferencePage;
        }

        // Elements for Add Nominated Point of Contact
        public IWebElement PageHeader => _driver.FindElement(By.CssSelector("h1.govuk-heading-l"));
        public IWebElement CareCoordinatorRadioButton => _driver.FindElement(By.Id("point-contact-co-ordinator"));
        public IWebElement ApprovedMentalHealthProfessionalRadioButton => _driver.FindElement(By.Id("point-contact-health-pro"));
        public IWebElement MentalHealthNurseRadioButton => _driver.FindElement(By.Id("point-contact-health-nurse"));
        public IWebElement FullNameInput => _driver.FindElement(By.Id("FullName-input"));
        public IWebElement TelephoneNumberInput => _driver.FindElement(By.Id("TelephoneNumber-input"));
        public IWebElement EmailInput => _driver.FindElement(By.Id("EmailAddress-input"));
        public IWebElement ConfirmEmailInput => _driver.FindElement(By.Id("ConfirmEmailAddress-input"));
        public IWebElement ConfirmationMethodEmailRadioButton => _driver.FindElement(By.Id("confirmation-method-email"));
        public IWebElement ConfirmationMethodPostRadioButton => _driver.FindElement(By.Id("confirmation-method-post"));
        public IWebElement SaveContactButton => _driver.FindElement(By.Id("debtor-nominated-contact-save"));
        public IWebElement SelectEmail => _driver.FindElement(By.Id("confirmation-method-email"));
        public IWebElement PointOfContactSave => _driver.FindElement(By.Id("point-contact-summary-save"));


        //Methods

        public void AddPointOfContactRole(string nominatedContactRole, string fullName, string telephone, string email, string confirmEmail,string contactPrefrerenceMethod)
        {
            switch (nominatedContactRole.Trim().ToLower())
            {
                case "care co-ordinator":
                    CareCoordinatorRadioButton.Click();
                    EnterNominatedContactDetails(fullName, telephone, email, confirmEmail, contactPrefrerenceMethod);
                   // _debtorContactPreferencePage.ContactPreference(preference, email, confirmEmail);
                    Console.WriteLine("Selected 'Care co-ordinator'.");
                    break;

                case "approved mental health professional":
                    ApprovedMentalHealthProfessionalRadioButton.Click();
                    EnterNominatedContactDetails(fullName, telephone, email, confirmEmail, contactPrefrerenceMethod);
                   // _debtorContactPreferencePage.ContactPreference(preference, email, confirmEmail);
                    Console.WriteLine("Selected 'Approved Mental Health Professional'.");
                    break;

                case "mental health nurse":
                    MentalHealthNurseRadioButton.Click();
                    EnterNominatedContactDetails(fullName, telephone, email, confirmEmail, contactPrefrerenceMethod);
                  //  _debtorContactPreferencePage.ContactPreference(preference, email, confirmEmail);
                    Console.WriteLine("Selected 'Mental Health Nurse'.");
                    break;

                default:
                    throw new ArgumentException($"Invalid point of contact role: {nominatedContactRole}");
            }
           // SaveAndProceed();
        }

        public void EnterNominatedContactDetails(string fullName, string telephone, string email, string confirmEmail,string contactPrefrerenceMethod)
        {
            FullNameInput.Clear();
            FullNameInput.SendKeys(fullName);
            Console.WriteLine($"Entered full name: {fullName}");

            if (!string.IsNullOrWhiteSpace(telephone))
            {
                TelephoneNumberInput.Clear();
                TelephoneNumberInput.SendKeys(telephone);
                Console.WriteLine($"Entered telephone number: {telephone}");
            }

            EmailInput.Clear();
            EmailInput.SendKeys(email);
            Console.WriteLine($"Entered email address: {email}");

            ConfirmEmailInput.Clear();
            ConfirmEmailInput.SendKeys(confirmEmail);
            Console.WriteLine($"Entered confirmation email address: {confirmEmail}");
            SelectConfirmationMethod(contactPrefrerenceMethod);
        }

        public void SelectConfirmationMethod(string contactPrefrerenceMethod)
        {
            switch (contactPrefrerenceMethod.Trim().ToLower())
            {
                case "email":
                    ConfirmationMethodEmailRadioButton.Click();
                    Console.WriteLine("Selected confirmation method: Email.");
                    break;

                case "post":
                    ConfirmationMethodPostRadioButton.Click();
                    Console.WriteLine("Selected confirmation method: Post.");
                    break;

                default:
                    throw new ArgumentException($"Invalid confirmation method: {contactPrefrerenceMethod}");
            }
        }

        public void SaveAndProceed()
        {
            PointOfContactSave.Click();
            Console.WriteLine("Clicked 'Save and Continue' button for nominated contact.");
        }
        public void ValidatePageTitle(string expectedHeader)
        {
            // Fetch the actual header text
            string actualHeader = PageHeader.Text.Trim();

            // Compare actual and expected header text
            if (!actualHeader.Equals(expectedHeader, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page header mismatch. Expected: '{expectedHeader}', Actual: '{actualHeader}'");
            }

            Console.WriteLine($"Page header validated successfully: '{actualHeader}'");
        }
    }
}
    


