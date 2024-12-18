using TechTalk.SpecFlow;
using BSS_Automation_Framework.Pages;
using BSSTestAutomation.Pages;

[Binding]
public class BSSDebtorAddBusinessDebptsSteps
{
    private BSSDebtorContactPreferencePage _contactPreferencePage;
    private BSSDebtorAddBusinessDebtsPage _bSSDebtorAddBusinessDebtsPage;

    public BSSDebtorAddBusinessDebptsSteps(BSSDebtorContactPreferencePage contactPreferencePage, BSSDebtorAddBusinessDebtsPage bSSDebtorAddBusinessDebtsPage)
    {
        _contactPreferencePage = contactPreferencePage;
        _bSSDebtorAddBusinessDebtsPage = bSSDebtorAddBusinessDebtsPage;
    }
    [When(@"I provide the debtor business debts details")]
    public void WhenIProvideTheDebtorBusinessDebtsDetails(Table table)
    {
        foreach (var row in table.Rows)
        {
            string option = row["Option"];
            string expectedTitle = "Does your client have any businesses with debts that are eligible for Breathing Space?";

            _bSSDebtorAddBusinessDebtsPage.ValidatePageTitle(expectedTitle);
            _bSSDebtorAddBusinessDebtsPage.BusinessDetails(option);
        }
    }
}
