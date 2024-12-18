using System;
using TechTalk.SpecFlow;
using BSSTestAutomation.Pages;

[Binding]
public class BSSBreathingSpaceSearchSteps
{
    private BSSBreathingSpaceSearchPage _searchPage;
    private ScenarioContext _scenarioContext;

    public BSSBreathingSpaceSearchSteps(
        BSSBreathingSpaceSearchPage searchPage,
        ScenarioContext scenarioContext)
    {
        _searchPage = searchPage;
        _scenarioContext = scenarioContext;
    }
    [When(@"I search for the Breathing Space using the following options")]
    public void WhenISearchForTheBreathingSpaceUsingTheFollowingOptions(Table table)
    {
        foreach (var row in table.Rows)
        {
            string bssReferenceNumber = row["BSSReferenceNumber"];
            string lastNameAndDobOption = row["LastNameDOB"];
            Console.WriteLine($"Search Option: {bssReferenceNumber}, LastNameDOB Option: {lastNameAndDobOption}");

            if (bssReferenceNumber.Trim().ToLower() == "reference")
            {
                _searchPage.SearchBreathingSpaceByScenarioContext(bssReferenceNumber);
            }
            else if (lastNameAndDobOption.Trim().ToLower() == "lastnameanddob")
            {
                throw new NotImplementedException("Search by Last Name and DOB not implemented.");
            }
            else
            {
                throw new ArgumentException($"Unsupported search option: {bssReferenceNumber}");
            }
        }
    }
}

