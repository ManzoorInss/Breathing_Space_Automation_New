using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BSSTestAutomation.Pages
{
    public class BSSBreathingSpaceSearchPage
    {
        private IWebDriver _driver;
        private ScenarioContext _scenarioContext;

        public BSSBreathingSpaceSearchPage(IWebDriver driver, ScenarioContext scenarioContext)
        {
            _driver = driver;
            _scenarioContext = scenarioContext;
        }

        // Navigation Bar Elements
        public IWebElement SearchLink => _driver.FindElement(By.Id("home-navigation-search-link"));

        // Search Page Elements
        public IWebElement PageHeader => _driver.FindElement(By.Id("account-search-heading"));
        public IWebElement SearchByReferenceOption => _driver.FindElement(By.Id("searchedby-ref"));
        public IWebElement ReferenceInput => _driver.FindElement(By.Id("Reference-input"));
        public IWebElement SearchByLastNameAndDobOption => _driver.FindElement(By.Id("searchedby-dob-name"));
        public IWebElement LastNameInput => _driver.FindElement(By.Id("Surname-input"));
        public IWebElement DobDayInput => _driver.FindElement(By.Id("dob-day-input"));
        public IWebElement DobMonthInput => _driver.FindElement(By.Id("dob-month-input"));
        public IWebElement DobYearInput => _driver.FindElement(By.Id("dob-year-input"));
        public IWebElement SearchButton => _driver.FindElement(By.Id("save-button"));

        // Error Elements
        public IWebElement ErrorMessage => _driver.FindElement(By.Id("account-search-search-option-error-message"));

        // Method to navigate to the search page
        public void NavigateToSearchPage()
        {
            SearchLink.Click();
            Console.WriteLine("Navigated to the Search page.");
        }

        // Method to validate the page header
        public void ValidatePageHeader(string expectedHeader)
        {
            string actualHeader = PageHeader.Text.Trim();
            if (!actualHeader.Equals(expectedHeader, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page header mismatch. Expected: '{expectedHeader}', Actual: '{actualHeader}'");
            }
            Console.WriteLine($"Page header validated successfully: {actualHeader}");
        }

        // Method to search by Breathing Space reference number
        public void SearchBreathingSpaceByScenarioContext(string searchOption)
        {
            switch (searchOption.Trim().ToLower())
            {
                case "reference":
                    if (!_scenarioContext.ContainsKey("ReferenceNumber"))
                    {
                        throw new Exception("Reference number is missing from ScenarioContext. Ensure it is captured in a previous step.");
                    }

                    string referenceNumber = _scenarioContext["ReferenceNumber"]?.ToString();
                    if (string.IsNullOrWhiteSpace(referenceNumber))
                    {
                        throw new Exception("Reference number in ScenarioContext is null or empty.");
                    }

                    Console.WriteLine($"Searching for Breathing Space with Reference Number: {referenceNumber}");
                    NavigateToSearchPage();
                    SearchByReferenceNumber(referenceNumber);
                    break;

                case "lastnameanddob":
                    Console.WriteLine("Delegating 'LastName and DOB' search logic to a separate method.");
                    throw new NotImplementedException("Searching by Last Name and DOB is not yet implemented.");
                    // Call a dedicated method here if required.
                    break;

                default:
                    throw new ArgumentException($"Unsupported search option: {searchOption}");
            }
        }


        // Method to search by reference number
        public void SearchByReferenceNumber(string referenceNumber)
        {
            SearchByReferenceOption.Click();
            ReferenceInput.Clear();
            ReferenceInput.SendKeys(referenceNumber);
            Console.WriteLine($"Entered reference number: {referenceNumber}");
            SearchButton.Click();
            Console.WriteLine("Clicked the 'Search' button.");
        }

        // Method to search by last name and date of birth
        public void SearchByLastNameAndDob(string lastName, string day, string month, string year)
        {
            SearchByLastNameAndDobOption.Click();
            Console.WriteLine("Selected 'Last name and date of birth' search option.");

            LastNameInput.Clear();
            LastNameInput.SendKeys(lastName);
            Console.WriteLine($"Entered last name: {lastName}");

            DobDayInput.Clear();
            DobDayInput.SendKeys(day);
            Console.WriteLine($"Entered date of birth - Day: {day}");

            DobMonthInput.Clear();
            DobMonthInput.SendKeys(month);
            Console.WriteLine($"Entered date of birth - Month: {month}");

            DobYearInput.Clear();
            DobYearInput.SendKeys(year);
            Console.WriteLine($"Entered date of birth - Year: {year}");

            SearchButton.Click();
            Console.WriteLine("Clicked 'Search' button.");
        }

        // Method to handle search option dynamically using switch case
        public void SearchBreathingSpace(string searchOption, string referenceNumber = "", string lastName = "", string day = "", string month = "", string year = "")
        {
            switch (searchOption.Trim().ToLower())
            {
                case "reference":
                    SearchByReferenceNumber(referenceNumber);
                    break;

                case "lastnameanddob":
                    SearchByLastNameAndDob(lastName, day, month, year);
                    break;

                default:
                    throw new ArgumentException($"Invalid search option: {searchOption}");
            }
        }

        // Method to validate error message
        public void ValidateErrorMessage(string expectedMessage)
        {
            if (!ErrorMessage.Displayed)
            {
                throw new Exception("Error message is not displayed.");
            }

            string actualMessage = ErrorMessage.Text.Trim();
            if (!actualMessage.Equals(expectedMessage, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Error message mismatch. Expected: '{expectedMessage}', Actual: '{actualMessage}'");
            }
            Console.WriteLine($"Error message validated successfully: {actualMessage}");
        }
    }
}
