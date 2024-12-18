using System;
using TechTalk.SpecFlow;
using BSSTestAutomation.Pages;

[Binding]
public class BSSDebtorDeclarationSteps
{
    private BSSDebtorDeclarationPages _bSSDebtorDeclarationPage;

    public BSSDebtorDeclarationSteps(BSSDebtorDeclarationPages bSSDebtorDeclarationPages)
    {
        _bSSDebtorDeclarationPage = bSSDebtorDeclarationPages;
    }


    [When(@"I agree declaration and submit to Breathing space")]
    public void WhenIAgreeDeclarationAndSubmitToBreathingSpace()
    {
        _bSSDebtorDeclarationPage.ValidateDeclarationHeader("Declaration");
        _bSSDebtorDeclarationPage.AgreeAndSubmit();
    }
}

