using BSSTestAutomation.Pages;
using TechTalk.SpecFlow;

namespace BSSTestAutomation.StepDefinitions
{
    [Binding]
    public class BSSClientNameDetailsSteps
    {
        private BSSClientNameDetailsPage _clientNameDetailsPage;
        private BSSClientNamesSummaryPage _clientNamesSummaryPage;


        public BSSClientNameDetailsSteps(BSSClientNameDetailsPage clientNameDetailsPage, BSSClientNamesSummaryPage clientNamesSummaryPage)
        {
            _clientNameDetailsPage = clientNameDetailsPage;
            _clientNamesSummaryPage = clientNamesSummaryPage;

        }

        [When(@"I enter the client details for name summary")]
        public void WhenIEnterTheClientDetailsForNameSummary(Table table)
        {
 
            var row = table.Rows[0];
            string clientDetailsFieldValue = row["ClientDetailsFields"];
            string firstName = row["FirstName"];
            string middleName = row["MiddleName"];
            string lastName = row["LastName"];
            string birthDay = row["BirthDay"];
            string birthMonth = row["BirthMonth"];
            string birthYear = row["BirthYear"];

            _clientNameDetailsPage.ValidateClientDetailsPageTitle("Add client name and date of birth");
            _clientNameDetailsPage.ClientDetails(clientDetailsFieldValue, firstName, middleName, lastName, birthDay, birthMonth, birthYear);
        }
    }
}









//using TechTalk.SpecFlow;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using BSSTestAutomation.Pages;
//using System;

//[Binding]
//public class BSSClientDetailsPageSteps
//{
//    private readonly IWebDriver _driver;
//    private readonly BSSClientDetailsPage _clientDetailsPage;

//    public BSSClientDetailsPageSteps(IWebDriver driver)
//    {
//        _driver = driver;
//        _clientDetailsPage = new BSSClientDetailsPage(_driver);
//    }

//    [When(@"I enter the client details")]
//    public void WhenIEnterTheClientDetails(Table table)
//    {
//        Assert.That(_clientDetailsPage.ClientDetailsPageTitle.Displayed, Is.True, "Client Details Page is not displayed.");

//        var row = table.Rows[0];
//        string clientDetailsFieldValue = row["ClientDetailsFields"];
//        string firstName = row["FirstName"];
//        string middleName = row["MiddleName"];
//        string lastName = row["LastName"];
//        string birthDay = row["BirthDay"];
//        string birthMonth = row["BirthMonth"];
//        string birthYear = row["BirthYear"];

//        if (clientDetailsFieldValue.Equals("Fill", StringComparison.OrdinalIgnoreCase))
//        {
//            _clientDetailsPage.FillAllFields(firstName, middleName, lastName, birthDay, birthMonth, birthYear);
//            _clientDetailsPage.SubmitForm();

//            if (_clientDetailsPage.HasErrors())
//            {
//                throw new Exception("Form submission failed. Errors are present on the page even though fields were filled.");
//            }
//            Console.WriteLine("Form submitted successfully with filled details.");
//        }
//        else if (clientDetailsFieldValue.Equals("empty", StringComparison.OrdinalIgnoreCase))
//        {
//            _clientDetailsPage.SubmitForm();

//            if (!_clientDetailsPage.HasErrors())
//            {
//                throw new Exception("Expected validation errors, but none were displayed after submitting empty form.");
//            }

//            _clientDetailsPage.ValidateEmptyFields();
//            Console.WriteLine("Validation errors confirmed for empty fields.");

//            _clientDetailsPage.FillAllFields(firstName, middleName, lastName, birthDay, birthMonth, birthYear);
//            _clientDetailsPage.SubmitForm();

//            if (_clientDetailsPage.HasErrors())
//            {
//                throw new Exception("Form submission failed again. Expected no errors after filling the fields.");
//            }

//            Console.WriteLine("Form submitted successfully after correcting empty fields.");
//        }
//        else
//        {
//            throw new ArgumentException($"Unknown ClientDetailsFieldValue: {clientDetailsFieldValue}");
//        }
//    }
//}
