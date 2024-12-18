using System;
using TechTalk.SpecFlow;
using BSSTestAutomation.Pages;

[Binding]
public class BSSBreathingSpaceConfirmationSteps
{
    private readonly BSSBreathingSpaceConfirmationPage _confirmationPage;
    private readonly ScenarioContext _scenarioContext;

    public BSSBreathingSpaceConfirmationSteps(BSSBreathingSpaceConfirmationPage confirmationPage, ScenarioContext scenarioContext)
    {
        _confirmationPage = confirmationPage;
        _scenarioContext = scenarioContext;
    }

    [When(@"I Submited Client Breathing Space and generated BSS Client reference number")]
    public void ThenICaptureTheClientSReferenceNumberr()
    {
        _confirmationPage.ValidateConfirmationText();
        string referenceNumber = _confirmationPage.GetBSSReferenceNumber();

        if (string.IsNullOrWhiteSpace(referenceNumber))
        {
            throw new Exception("Failed to capture the reference number. Ensure the page is loaded and the number is available.");
        }

        // Store in ScenarioContext
        _scenarioContext["ReferenceNumber"] = referenceNumber;
        Console.WriteLine($"Reference number stored in ScenarioContext: {referenceNumber}");
        _confirmationPage.ReturnToHomePage();
    }
    
    }


