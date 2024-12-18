using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using BSSTestAutomation.Pages;
using System;
using RazorEngine.Compilation.ImpromptuInterface;

[Binding]
public class BSSClientAddPreviousNameSteps
{
    private readonly IWebDriver _driver;
    private readonly BSSClientAddPreviousNamePage _clientAddPreviousNamePage;
    public BSSClientAddPreviousNameSteps(IWebDriver driver, BSSClientAddPreviousNamePage bSSClientAddPreviousNamePage)
    {
        _driver = driver;
        _clientAddPreviousNamePage = bSSClientAddPreviousNamePage;
    }

    [When(@"I enter the client details for previous name")]
    public void WhenIEnterTheClientDetailsForPreviousName(Table table)
    {
  
        foreach (var row in table.Rows)
        {
            string clientDetailsFieldValue = row["ClientDetailsFields"];
            string previousName = row["PreviousName"];
            string firstName = row["FirstName"];
            string middleName = row["MiddleName"];
            string lastName = row["LastName"];
            string birthDay = row["BirthDay"];
            string birthMonth = row["BirthMonth"];
            string birthYear = row["BirthYear"];

            _clientAddPreviousNamePage.AddOrChangeClientPreviousName(previousName,
                firstName,
                middleName,
                lastName,
                birthDay,
                birthMonth,
                birthYear,
                clientDetailsFieldValue
            );
        }
    }
}


//        //Assert.That(_clientAddPreviousNamePage.ClientDetailsPageTitle.Displayed, Is.True, "Client Details Page is not displayed.");

//        var row = table.Rows[0];
//        string clientDetailsFieldValue = row["ClientDetailsFields"];
//        string firstName = row["FirstName"];
//        string middleName = row["MiddleName"];
//        string lastName = row["LastName"];


//        if (clientDetailsFieldValue.Equals("Fill", StringComparison.OrdinalIgnoreCase))
//        {



//            _clientAddPreviousNamePage.ClientAddPreviousNameBtn.Click();
//            _clientAddPreviousNamePage.FillAllFields(firstName, middleName, lastName);
//            _clientAddPreviousNamePage.SubmitForm();

//            if (_clientAddPreviousNamePage.HasErrors())
//            {
//                throw new Exception("Form submission failed. Errors are present on the page even though fields were filled.");
//            }
//            Console.WriteLine("Form submitted successfully with filled details.");
//        }
//        else if (clientDetailsFieldValue.Equals("empty", StringComparison.OrdinalIgnoreCase))
//        {

//            _clientAddPreviousNamePage.AddPreviousNameLink();
//             _clientAddPreviousNamePage.SubmitForm();


//            if (!_clientAddPreviousNamePage.HasErrors())
//            {
//                throw new Exception("Expected validation errors, but none were displayed after submitting empty form.");
//            }
//            _clientAddPreviousNamePage.ValidateEmptyFields();
//            Console.WriteLine("Validation errors confirmed for empty fields.");
//            _clientAddPreviousNamePage.FillAllFields(firstName, middleName, lastName);
//            _clientAddPreviousNamePage.SubmitForm();

//            if (_clientAddPreviousNamePage.HasErrors())
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
