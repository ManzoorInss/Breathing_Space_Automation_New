using BSSTestAutomation.Pages;
using TechTalk.SpecFlow;

namespace BSSTestAutomation.StepDefinitions
{
    [Binding]
    public class BSSHomePageSteps
    {
        private readonly BSSHomePage _homePage;

        public BSSHomePageSteps(BSSHomePage homePage)
        {
            _homePage = homePage;
        }

        [When(@"I choose to create a Breathing Space")]
        public void WhenIChooseToCreateABreathingSpace(Table table)
        {
            bool isAnyActionTriggered = false;

            foreach (var row in table.Rows)
            {
                // Extract table values
                string organisationName = row["Organisation"];
                string activeBSLink = row["ActiveBSLink"];
                string reviewDebtLink = row["ReviewDebtLink"];
                string proposedDebtLink = row["ProposedDebtLink"];
                string soldDebtLink = row["SoldDebtLink"];
                string transferClientLink = row["TransferClientLink"];
                string transferredClientsLink = row["TransferredClientsLink"];

                // Validate Organisation Name
                _homePage.ValidateOrganisationName(organisationName);

                // Perform actions dynamically based on "Yes"
                if (activeBSLink.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Navigating to Active Breathing Spaces...");
                    _homePage.ClickActiveBreathingSpacesLink();
                    isAnyActionTriggered = true;
                }

                if (reviewDebtLink.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Navigating to Review Debt Link...");
                    _homePage.ClickReviewDebtLink();
                    isAnyActionTriggered = true;
                }

                if (proposedDebtLink.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Navigating to Proposed Debt Link...");
                    _homePage.ClickProposedDebtLink();
                    isAnyActionTriggered = true;
                }

                if (soldDebtLink.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Navigating to Sold Debt Link...");
                    _homePage.ClickSoldDebtLink();
                    isAnyActionTriggered = true;
                }

                if (transferClientLink.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Navigating to Transfer Client Link...");
                    _homePage.ClickTransferClientLink();
                    isAnyActionTriggered = true;
                }

                if (transferredClientsLink.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Navigating to Transferred Clients Link...");
                    _homePage.ClickTransferredClientsLink();
                    isAnyActionTriggered = true;
                }
            }

            // Default action: Click the Create Breathing Space button if no links were "Yes"
            if (!isAnyActionTriggered)
            {
                Console.WriteLine("No actions specified. Clicking the default 'Create Breathing Space' button...");
                _homePage.ClickCreateBSButton();
            }
        }
    }
}
