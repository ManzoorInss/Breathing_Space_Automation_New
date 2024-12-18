using TechTalk.SpecFlow;
using BSSTestAutomation.Pages;
using System;

[Binding]
public class BSSBConfirmEligibilityAndAddPointOfContactSteps
{
    private BSSSelectAndSubmitClientBreathingSpaceTypePage _selectBreathingSpaceTypePage;
    private BSSDebtorEligibilityConfirmationPage _eligibilityConfirmationPage;
    private BSSAddNominatedPointOfContactPage _addNominatedContactPage;

    public BSSBConfirmEligibilityAndAddPointOfContactSteps(
        BSSSelectAndSubmitClientBreathingSpaceTypePage selectBreathingSpaceTypePage,
        BSSDebtorEligibilityConfirmationPage eligibilityConfirmationPage,
        BSSAddNominatedPointOfContactPage addNominatedContactPage)
    {
        _selectBreathingSpaceTypePage = selectBreathingSpaceTypePage;
        _eligibilityConfirmationPage = eligibilityConfirmationPage;
        _addNominatedContactPage = addNominatedContactPage;
    }

    [When(@"I Select breathing space Type")]
    public void WhenISelectBreathingSpaceType(Table table)
    {
        foreach (var row in table.Rows)
        {
            string breathingSpaceType = row["BreathingSpaceType"];
            string nominatedContactRole = row["NominatedContactRole"];
            string fullName = row["Fullname"];
            string telephone = row["Telephone"];
            string email = row["Email"];
            string confirmEmail = row["ConfirmEmail"]; 
            string contactPrefrerenceMethod = row["ContactPrefrerenceMethod"]; 

            try
            {
                _selectBreathingSpaceTypePage.ValidatePageHeader("Which Breathing Space does your client need?");

                // Select the breathing space type 
                _selectBreathingSpaceTypePage.SelectBreathingSpaceType(
                    breathingSpaceType,
                    nominatedContactRole,
                    fullName,
                    telephone,
                    email,
                    confirmEmail,
                    contactPrefrerenceMethod
                );

                _addNominatedContactPage.SaveContactButton.Click();
                _addNominatedContactPage.SaveAndProceed();


                Console.WriteLine("Successfully Selected the breathing space Type and Added Nominated Contact details.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while processing breathing space selection: {ex.Message}");
                throw;
            }
        }
    }
}
