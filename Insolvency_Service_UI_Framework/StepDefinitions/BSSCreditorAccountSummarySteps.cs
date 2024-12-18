using TechTalk.SpecFlow;
using BSSTestAutomation.Pages;
using System;
using AventStack.ExtentReports.Gherkin.Model;

[Binding]
public class BSSCreaditorAccountSummarySteps
{
    private readonly BSSCreaditorAccountSummaryPage _creditorAccountSummaryPage;

    public BSSCreaditorAccountSummarySteps(BSSCreaditorAccountSummaryPage creditorAccountSummaryPage)
    {
        _creditorAccountSummaryPage = creditorAccountSummaryPage;
    }

    [When(@"I updated creditor account summary")]
    public void WhenIUpdatedCreditorAccountSummary(Table table)
    {
        foreach (var row in table.Rows)
        {
            string creditorName = row["CreditorName"];
            string findAddressPostcode = row["FindAddress-Postcode"];
            string preference = row["Preference"];
            string email = row["Email"];
            string confirmEmail = row["ConfirmEmail"];
            string postcode = row["Postcode"];
            string addressLine1 = row["AddressLine1"];
            string addressLine2 = row["AddressLine2"];
            string city = row["City"];
            string specificAddress = row["SpecificAddress"];
            string debtType = row["DebtType"];
            Console.WriteLine($"Processing Update:CreditorName: {creditorName}, DebtType: {debtType}");

        
            _creditorAccountSummaryPage.ValidatePageTitle("Check the debt details");

            //method to update creditor account summary
            _creditorAccountSummaryPage.UpdateCreditorAccountSummary(
                creditorName,
                findAddressPostcode,
                preference,
                email,
                confirmEmail,
                addressLine1,
                addressLine2,
                city,
                postcode,
                specificAddress,
                debtType
            );
        }
    }

}

    

