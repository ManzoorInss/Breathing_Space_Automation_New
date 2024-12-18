using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using BSSTestAutomation.Pages;
using System.Data;

[Binding]
public class BSSAddADebtAndCreditorSteps
{
    private readonly BSSAddADebtAndCreditorPage _addDebtAndCreditorPage;

    public BSSAddADebtAndCreditorSteps(BSSAddADebtAndCreditorPage addDebtAndCreditorPage)
    {
        _addDebtAndCreditorPage = addDebtAndCreditorPage;
    }

    [When(@"I choose to add debt and creditor")]
    public void WhenIChooseToAddDebtAndCreditor(Table table)
    {
        foreach (var row in table.Rows)
        {
            // Extract data for each row
            string creditorType = row["CreditorType"];
            string creditorName = row["CreditorName"];
            string postcode = row["Postcode"];
            string preference =  row["Preference"];
            string email = row["Email"];
            string confirmEmail = row["ConfirmEmail"];
            string debtType = row["DebtType"];
            string debtAmount = row["DebtAmount"];
            string reference = row["Reference"];

            try
            { 
                // Click "Add Debt" button
                _addDebtAndCreditorPage.ClickAddDebt();
                string expectedTitle = "Add a creditor for this debt";
                _addDebtAndCreditorPage.ValidatePageTitle(expectedTitle);

                // Pass the data to the method
                _addDebtAndCreditorPage.EnterCreditorTypeDetails(
                    creditorType,
                    creditorName,
                    postcode,
                    preference,
                    email,
                    confirmEmail,
                    debtType,
                    debtAmount,
                    reference
                );

                Console.WriteLine($"Successfully added creditor '{creditorName}' with debt type '{debtType}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while processing creditor '{creditorName}': {ex.Message}");
                throw;
            }
        }
    }
}

