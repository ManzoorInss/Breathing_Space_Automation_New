using TechTalk.SpecFlow;
using BSSTestAutomation.Pages;

[Binding]
public class BSSAddDebtorDebtTypeAmountAndRefrenceSteps
{
    private readonly BSSAddADebtAndCreditorPage _bSSDAddADebtAndCreditorPage;

    public BSSAddDebtorDebtTypeAmountAndRefrenceSteps(BSSAddADebtAndCreditorPage bSSAddADebtAndCreditorPage)
    {
        _bSSDAddADebtAndCreditorPage = bSSAddADebtAndCreditorPage;
    }

    //[When(@"I select the creditor contact preference")]
    //public void WhenISelectTheDebtorContactPreference(Table table)
    //{
    //    foreach (var row in table.Rows)
    //    {
    //        //// Validate page title and header
    //        //_debtorContactPreferencePage.ValidatePageTitleAndHeade('How would your client like to receive confirmation their Breathing Space has started and ended??'
    //        //);

    //        string preference = row["Preference"];
    //        string email = row["Email"];
    //        string confirmEmail = row["ConfirmEmail"];

    //        _debtorContactPreferencePage.ContactPreference(preference, email, confirmEmail);
         

    //    }
    //}
        [When(@"I add debt type amount and reference")]
        public void WhenIAddDebtTypeAmountAndReference(Table table)
        {
            foreach (var row in table.Rows)
            {
          
            string debtAmount = row["DebtAmount"];
            string debtType = row["DebtType"];
            string reference = row["Reference"];

            string expectedTitle = "Add debt type, amount and reference";
            _bSSDAddADebtAndCreditorPage.ValidateDebtTypePageTitle(expectedTitle);
            _bSSDAddADebtAndCreditorPage.SelectDebtType(debtType);
            _bSSDAddADebtAndCreditorPage.EnterDebtAmount(debtAmount);
            _bSSDAddADebtAndCreditorPage.EnterReference(reference);
            _bSSDAddADebtAndCreditorPage.ClickSaveAndContinue();

            }
        }
    }

