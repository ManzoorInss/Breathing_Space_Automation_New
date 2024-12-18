using TechTalk.SpecFlow;
using BSSTestAutomation.Pages;
using System;

[Binding]
public class BSSDebtorBreathingSpaceAccountSubmitSteps
{
    private readonly BSSDebtorBreathingSpaceAccountSubmitPage _debtorBreathingSpaceAccountSubmitPage;

    public BSSDebtorBreathingSpaceAccountSubmitSteps(BSSDebtorBreathingSpaceAccountSubmitPage debtorBreathingSpaceAccountSubmitPage)
    {
        _debtorBreathingSpaceAccountSubmitPage = debtorBreathingSpaceAccountSubmitPage;
    }
    [When(@"I choose to submit breathing space")]
    public void WhenIChooseToSubmitBreathingSpace(Table table)
    {
        var submitOption = table.Rows[0]["SubmitTheBreathingSpace"];
        Console.WriteLine($"Attempting to submit Breathing Space with option: {submitOption}");

        try
        {
            string expectedTitle = "Do you want to submit your client and their debts into Breathing Space?";
            _debtorBreathingSpaceAccountSubmitPage.ThenThePageTitleShouldBe(expectedTitle);
            _debtorBreathingSpaceAccountSubmitPage.SubmitBreathingSpace(submitOption);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during Breathing Space submission: {ex.Message}");
            throw;
        }
    }

    [Then(@"I should see a validation error if no option is selected")]
    public void ThenIShouldSeeAValidationErrorIfNoOptionIsSelected()
    {
        try
        {
            _debtorBreathingSpaceAccountSubmitPage.HandleValidationError();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Validation error handling failed: {ex.Message}");
            throw;
        }
    }

}
