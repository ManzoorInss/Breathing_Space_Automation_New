using TechTalk.SpecFlow;
using BSSTestAutomation.Pages;

[Binding]
public class BSSDebtorContactPreferenceSteps
{
    private readonly BSSDebtorContactPreferencePage _debtorContactPreferencePage;

    public BSSDebtorContactPreferenceSteps(BSSDebtorContactPreferencePage debtorContactPreferencePage)
    {
        _debtorContactPreferencePage = debtorContactPreferencePage;
    }

    [When(@"I select the debtor contact preference")]
    public void WhenISelectTheDebtorContactPreference(Table table)
    {
        foreach (var row in table.Rows)
        {
          
            _debtorContactPreferencePage.ValidatePageTitleAndHeader("How would your client like to receive confirmation their Breathing Space has started and ended?");

            string preference = row["Preference"];
            string email = row["Email"];
            string confirmEmail = row["ConfirmEmail"];

            _debtorContactPreferencePage.ContactPreference(preference, email, confirmEmail);
            _debtorContactPreferencePage.SaveAndContinue();
        }
    }
}
