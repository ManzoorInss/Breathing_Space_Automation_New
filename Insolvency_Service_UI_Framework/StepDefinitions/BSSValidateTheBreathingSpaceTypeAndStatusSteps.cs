using BSSTestAutomation.Pages;
using System;
using TechTalk.SpecFlow;

namespace BSSTestAutomation.StepDefinitions
{
    [Binding]
    public class BSSTypeAndStatusValidationSteps
    {
        private BSSTypeAndStatusValidationPage _validationPage;

        // Constructor
        public BSSTypeAndStatusValidationSteps(BSSTypeAndStatusValidationPage validationPage)
        {
            _validationPage = validationPage;
        }

        [When(@"I validate the breathing space search results")]
        public void WhenIValidateTheBreathingSpaceSearchResults(Table table)
        {
            foreach (var row in table.Rows)
            {

                string expectedStatus = row["BSSStatus"];
                string expectedTag = row["MentalHealthTag"];

                // Validating each element
                _validationPage.ValidatePageHeader("Search results");
                _validationPage.ValidateSearchResultHeading("Searched by Breathing Space reference");
                _validationPage.ValidateStatus(expectedStatus);
                _validationPage.ValidateMentalHealthTag(expectedTag);

            }
        }

        [When(@"I click on the name link to view details")]
        public void WhenIClickOnTheNameLinkToViewDetails()
        {
            _validationPage.ClickOnNameLink();
        }
    }
}
