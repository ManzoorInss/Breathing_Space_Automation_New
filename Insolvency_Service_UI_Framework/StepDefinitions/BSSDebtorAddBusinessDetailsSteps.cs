using TechTalk.SpecFlow;
using BSS_Automation_Framework.Pages;

[Binding]
public class BSSAddDebtorDetailsSteps
{
    private BSSDebtorAddBusinessDetailsPage _bSSDebtorAddBusinessDetailsPage;

    public BSSAddDebtorDetailsSteps(BSSDebtorAddBusinessDetailsPage bSSDebtorAddBusinessDetailsPage)
    {
        _bSSDebtorAddBusinessDetailsPage = bSSDebtorAddBusinessDetailsPage;
    }
    [When(@"I added the debtor business name and address")]
    public void WhenIAddedTheDebtorBusinessNameAndAddress(Table table)
    {
        foreach (var row in table.Rows)
        {
            string businessName = row["BusinessName"];
            string businessAddressOption = row["ClientBusinessAddress"];
            string enterAddressManually = row["EnterAddressManually"];
            string findAddressPostcode = row["FindAddress-Postcode"];
            string postcode = row["Postcode"];
            string line1 = row["AddressLine1"];
            string line2 = row["AddressLine2"];
            string townCity = row["City"];
            string specificAddress = row["SpecificAddress"];

            Console.WriteLine($"Adding business details: Name = {businessName}, AddressOption = {businessAddressOption}");

            _bSSDebtorAddBusinessDetailsPage.ValidatePageTitle("Add client's business or trading name and address");
            _bSSDebtorAddBusinessDetailsPage.EnterBusinessDetails(businessName, businessAddressOption, enterAddressManually, findAddressPostcode, line1, line2, townCity, postcode, specificAddress);
        }
    }
}
