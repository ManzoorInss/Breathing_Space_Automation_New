






////using BSSTestAutomation.Pages; // Import the correct namespaces
////using BSS_Automation_Framework.Utilities;
////using OpenQA.Selenium;
////using System;
////using TechTalk.SpecFlow;

////namespace BSS_Automation_Framework.StepDefinitions
////{
////    [Binding]
////    public class EndToEndJourneyStepDefinitions
////    {
////        private readonly IWebDriver _driver;
////        private readonly BSSLoginPage _bssLoginPage;
////        private readonly BSSSelectOrganisation _bSSSelectOrganisation; // Initialize this object

////        // Constructor to initialize WebDriver and Page Objects
////        public EndToEndJourneyStepDefinitions(IWebDriver driver)
////        {
////            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
////            _bssLoginPage = new BSSLoginPage(_driver); // Instantiate the login page object
////            _bSSSelectOrganisation = new BSSSelectOrganisation(_driver); // Instantiate the organisation selection page object
////        }

////        // Step definition for navigating to the homepage and logging in
////        [Given(@"I log into the Breathing Space Application")]
////        public void GivenILogIntoTheBreathingSpaceApplication()
////        {

////                // Navigate to the portal URL
////                _driver.Navigate().GoToUrl("https://webapp-uksouth-sit-portal001.azurewebsites.net/");

////                // Login with credentials
////                _bssLoginPage.BSSLogin("28 09 73 31 15 10", "Test@123456");
////                _bssLoginPage.EnterOnetimePassword("123456");

////                // Select an organisation from the dropdown by visible text
////                string textToSelect = "Manzoor Money Advisor";
////                _bSSSelectOrganisation.SelectByVisibleText(textToSelect);

////                // Validate that the correct option is selected
////                bool isCorrect = _bSSSelectOrganisation.IsSelectedOption(textToSelect);
////                Console.WriteLine(isCorrect ? "Option selected correctly." : "Option selection failed.");
////            }

////        [When(@"I navigate to the Breathing Space Homepage as '([^']*)'")]
////        public void WhenINavigateToTheBreathingSpaceHomepageAs(string p0)
////        {
////            try
////            {

////                // Select an organisation from the dropdown by visible text
////                string textToSelect = "Manzoor Money Advisor";
////                _bSSSelectOrganisation.SelectByVisibleText(textToSelect);

////                // Validate that the correct option is selected
////                bool isCorrect = _bSSSelectOrganisation.IsSelectedOption(textToSelect);
////                Console.WriteLine(isCorrect ? "Option selected correctly." : "Option selection failed.");
////            }
////            catch (Exception ex)
////            {
////                // Log error if anything goes wrong
////                Console.WriteLine("Error: " + ex.Message);
////            }
////        }
////    }
////}


//using BSSTestAutomation.Pages; // Import the correct namespaces
//using BSS_Automation_Framework.Utilities;
//using OpenQA.Selenium;
//using System;
//using TechTalk.SpecFlow;
//using Bankruptcy_Automation_Framework.Pages;
//using NUnit.Framework;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;

//namespace BSS_Automation_Framework.StepDefinitions
//{
//    [Binding]
//    public class EndToEndJourneyStepDefinitions
//    {
//        private readonly IWebDriver _driver;
//        private readonly BSSLoginPage _bssLoginPage;
//        private readonly BSSSelectOrganisation _bSSSelectOrganisation;
//        private readonly BSSHomePage _homePage;
//        private readonly BSSClientDetailsPage _clientDetailsPage;



//        // Constructor to initialize WebDriver and Page Objects
//        public EndToEndJourneyStepDefinitions(IWebDriver driver)
//        {
//            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
//            _bssLoginPage = new BSSLoginPage(_driver);
//            _bSSSelectOrganisation = new BSSSelectOrganisation(_driver);
//            _homePage = new BSSHomePage(_driver);
//            _clientDetailsPage = new BSSClientDetailsPage(driver);

//        }

//        // Step definition for navigating to the homepage and logging in
//        [Given(@"I log into the Breathing Space Application")]
//        public void GivenILogIntoTheBreathingSpaceApplication()
//        {
//            // Navigate to the portal URL
//            _driver.Navigate().GoToUrl("https://webapp-uksouth-sit-portal001.azurewebsites.net/");

//            // Login with credentials
//            _bssLoginPage.BSSLogin("28 09 73 31 15 10", "Test@123456");
//            _bssLoginPage.EnterOnetimePassword("123456");
//        }

//        // Step definition for navigating to the Breathing Space homepage as a user
//        [When(@"I navigate to the Breathing Space Homepage as '(.*)'")]
//        public void WhenINavigateToTheBreathingSpaceHomepageAs(string user)
//        {
//            // The 'user' variable will contain the username or role from the Feature file
//            Console.WriteLine($"Navigating to the Breathing Space homepage as {user}...");

//            // Optionally, you could use this user parameter to perform user-specific actions (like logging in as a different user).
//            // But for now, we assume login steps are handled in the Given step.
//        }

//        // Step definition for selecting an organisation dynamically from the data table
//        [When(@"I select organisation '(.*)'")]
//        public void WhenISelectOrganisation(string organisation)
//        {
//            try
//            {
//                // Use the passed organisation name to select it from the dropdown
//                Console.WriteLine($"Selecting organisation: {organisation}");
//                _bSSSelectOrganisation.SelectByVisibleText(organisation);

//                // Validate that the correct option is selected
//                bool isCorrect = _bSSSelectOrganisation.IsSelectedOption(organisation);
//                Console.WriteLine(isCorrect ? "Option selected correctly." : "Option selection failed.");
//            }
//            catch (Exception ex)
//            {
//                // Log error if anything goes wrong
//                Console.WriteLine("Error: " + ex.Message);
//            }
//        }

//        // Step definition to check if the correct organisation is selected (optional)
//        //[Then(@"the organisation should be selected successfully")]
//        //public void ThenTheOrganisationShouldBeSelectedSuccessfully()
//        //{
//        //    // Get the text of the selected option
//        //  //  string selectedText = _bSSSelectOrganisation.BSSOrganisation.Text;
//        //    Console.WriteLine($"Selected Organisation: {selectedText}");

//        //    // Assert that the expected organisation was selected
//        //    if (string.IsNullOrEmpty(selectedText))
//        //    {
//        //        throw new Exception("Organisation selection failed!");
//        //    }
//        [When(@"I choose to create a Breathing Space")]
//        public void WnIChooseToCreateABreathingSpace(Table table)
//        {
//            foreach (var row in table.Rows)
//            {
//                // In this case, no headers, so we get the columns by index.
//                string linkName = row[0];  // Link Name is in the first column
//                string action = row[1];    // Action (yes/no) is in the second column

//                switch (linkName)
//                {
//                    case "HomePageActiveBSLink":
//                        if (action.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
//                        {
//                            _homePage.ClickActiveBreathingSpacesLink();
//                        }
//                        break;

//                    case "HomePageReviewDebtLink":
//                        if (action.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
//                        {
//                            _homePage.ClickReviewDebtLink();
//                        }
//                        break;

//                    case "HomePageProposedDebtLink":
//                        if (action.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
//                        {
//                            _homePage.ClickProposedDebtLink();
//                        }
//                        break;

//                    case "HomePageSoldDebtLink":
//                        if (action.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
//                        {
//                            _homePage.ClickSoldDebtLink();
//                        }
//                        break;

//                    case "HomePageTransferClientLink":
//                        if (action.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
//                        {
//                            _homePage.ClickTransferClientLink();
//                        }
//                        break;

//                    case "HomePageTransferredClientsLink":
//                        if (action.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
//                        {
//                            _homePage.ClickTransferredClientsLink();
//                        }
//                        break;

//                    default:
//                        // If no action is defined for the link or the action is 'no', click the "Create new breathing space" link by default
//                        _homePage.ClickCreateBSButton();
//                        break;
//                }
//            }
//        }


//        [When(@"I enter the client details")]
//        public void WhenIEnterTheClientDetails(Table table)
//        {
//            Assert.That(_clientDetailsPage.ClientDetailsPageTitle.Displayed, Is.True, "Client Details Page is not displayed.");

//            var row = table.Rows[0];
//            string clientDetailsFieldValue = row["ClientDetailsFields"]; // "Fill" or "empty"
//            string firstName = row["FirstName"];
//            string middleName = row["MiddleName"];
//            string lastName = row["LastName"];
//            string birthDay = row["BirthDay"];
//            string birthMonth = row["BirthMonth"];
//            string birthYear = row["BirthYear"];

//            if (clientDetailsFieldValue.Equals("Fill", StringComparison.OrdinalIgnoreCase))
//            {
//                // Normal scenario: Just fill and submit
//                _clientDetailsPage.FillAllFields(firstName, middleName, lastName, birthDay, birthMonth, birthYear);
//                _clientDetailsPage.SubmitForm();

//                if (_clientDetailsPage.HasErrors())
//                {
//                    throw new Exception("Form submission failed. Errors are present on the page even though fields were filled.");
//                }
//                Console.WriteLine("Form submitted successfully with filled details.");
//            }
//            else if (clientDetailsFieldValue.Equals("empty", StringComparison.OrdinalIgnoreCase))
//            {
//                // Empty scenario:
//                // 1. Submit the form empty first to trigger validation errors.
//                _clientDetailsPage.SubmitForm();

//                // Now there should be errors since fields are empty
//                if (!_clientDetailsPage.HasErrors())
//                {
//                    throw new Exception("Expected validation errors, but none were displayed after submitting empty form.");
//                }

//                // 2. Validate that the expected validation errors are displayed
//                _clientDetailsPage.ValidateEmptyFields();
//                Console.WriteLine("Validation errors confirmed for empty fields.");

//                // 3. After confirming errors, fill in the correct fields now.
//                _clientDetailsPage.FillAllFields(firstName, middleName, lastName, birthDay, birthMonth, birthYear);

//                // 4. Submit the form again after correcting fields
//                _clientDetailsPage.SubmitForm();

//                if (_clientDetailsPage.HasErrors())
//                {
//                    throw new Exception("Form submission failed again. Expected no errors after filling the fields.");
//                }

//                Console.WriteLine("Form submitted successfully after correcting empty fields.");
//            }
//            else
//            {
//                throw new ArgumentException($"Unknown ClientDetailsFieldValue: {clientDetailsFieldValue}");
//            }
//        }
//    }

//}
    












