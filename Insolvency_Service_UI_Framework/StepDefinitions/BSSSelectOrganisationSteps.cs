using BSSTestAutomation.Pages;
using System;
using System.Data;
using TechTalk.SpecFlow;

namespace BSSTestAutomation.StepDefinitions
{
    [Binding]
    public class BSSSelectOrganisationSteps
    {
        private readonly BSSSelectOrganisationPage _bSSSelectOrganisationpage;

        public BSSSelectOrganisationSteps(BSSSelectOrganisationPage bSSSelectOrganisationpage)
        {
            _bSSSelectOrganisationpage = bSSSelectOrganisationpage;
        }

        [When(@"I navigate to the Breathing Space portal homepage")]
        public void WhenINavigateToTheBreathingSpaceHomepageAs()
        {
            _bSSSelectOrganisationpage.ValidatePageHeader("Choose which organisation you want to view");
        }

        [When(@"I select organisation from the following:")]
        public void WhenISelectOrganisationFromTheFollowing(Table table)
        {
            foreach (var row in table.Rows)
            {
                string user = row["User"];
                string organisation = row["Organisation"];

                Console.WriteLine($"Navigating as user: {user}");
                Console.WriteLine($"Selecting organisation: {organisation}");

                // Select organisation from the dropdown
                _bSSSelectOrganisationpage.SelectOrganisation(organisation);
            }
        }
    }
}

