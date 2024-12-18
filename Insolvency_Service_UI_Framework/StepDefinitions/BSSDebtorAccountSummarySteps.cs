using System;
using TechTalk.SpecFlow;
using BSSTestAutomation.Pages;

[Binding]
public class BSSDebtorAccountSummarySteps
{
    private readonly BSSDebtorAccountSummaryPage _bssdebtorAccountSummaryPage;

    public BSSDebtorAccountSummarySteps(BSSDebtorAccountSummaryPage bssdebtorAccountSummaryPage)
    {
        _bssdebtorAccountSummaryPage = bssdebtorAccountSummaryPage;
    }

    [When(@"I update the debtor account summary page")]
    public void WhenIUpdateTheDebtorAccountSummaryPage(Table table)
    {
        bool actionPerformed = false;

        foreach (var row in table.Rows)
        {
            // Retrieve all table fields
            string updateClientName = row["UpdateClientName"];
            string updateDOB = row["UpdateDOB"];
            string updateAddPreviousNames = row["UpdateAddPreviousNames"];
            string updateCurrentAddress = row["UpdateCurrentAddress"];
            string updateHideAddress = row["UpdateHideAddress"];
            string updateAddPreviousAddress = row["UpdateAddPreviousAddress"];
            string changeNotifications = row["ChangeNotifications"];
            string updateAddBusinessAddress = row["UpdateAddBusinessAddress"];
            string updateBusinessAddress = row["UpdateBusinessAddress"];
            string deleteBusinessAddress = row["DeleteBusinessAddress"];
            string preference = row["Preference"];

            // Call the Update method in the page class for each field
            if (!string.IsNullOrWhiteSpace(updateClientName) && updateClientName.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                _bssdebtorAccountSummaryPage.Update("changename");
                actionPerformed = true;
            }

            if (!string.IsNullOrWhiteSpace(updateDOB) && updateDOB.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                _bssdebtorAccountSummaryPage.Update("changedateofbirth");
                actionPerformed = true;
            }

            if (!string.IsNullOrWhiteSpace(updateAddPreviousNames) && updateAddPreviousNames.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                _bssdebtorAccountSummaryPage.Update("addpreviousname");
                actionPerformed = true;
            }

            if (!string.IsNullOrWhiteSpace(updateCurrentAddress) && updateCurrentAddress.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                _bssdebtorAccountSummaryPage.Update("changeaddress");
                actionPerformed = true;
            }

            if (!string.IsNullOrWhiteSpace(updateHideAddress) && updateHideAddress.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                _bssdebtorAccountSummaryPage.Update("hideaddress");
                actionPerformed = true;
            }

            if (!string.IsNullOrWhiteSpace(updateAddPreviousAddress) && updateAddPreviousAddress.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                _bssdebtorAccountSummaryPage.Update("addpreviousaddress");
                actionPerformed = true;
            }

            if (!string.IsNullOrWhiteSpace(changeNotifications) && changeNotifications.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                _bssdebtorAccountSummaryPage.Update("changenotification", preference);
                actionPerformed = true;
            }

            if (!string.IsNullOrWhiteSpace(updateAddBusinessAddress) && updateAddBusinessAddress.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                _bssdebtorAccountSummaryPage.Update("addbusinessaddress");
                actionPerformed = true;
            }

            if (!string.IsNullOrWhiteSpace(updateBusinessAddress) && updateBusinessAddress.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                _bssdebtorAccountSummaryPage.Update("changebusinessaddress");
                actionPerformed = true;
            }

            if (!string.IsNullOrWhiteSpace(deleteBusinessAddress) && deleteBusinessAddress.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                _bssdebtorAccountSummaryPage.Update("deletebusinessaddress");
                actionPerformed = true;
            }
        }

        // If no actions are performed, click Save and Continue
        if (!actionPerformed)
        {
            _bssdebtorAccountSummaryPage.DebtorSummaryPageSaveContiueBtn.Click();
            Console.WriteLine("No actions performed. Clicked Save and Continue.");
        }
    }
}