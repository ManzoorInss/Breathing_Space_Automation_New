using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using TechTalk.SpecFlow;
using BSSTestAutomation.Pages;
using BSSTestAutomation.Common;

[Binding]
public class BSSAddCreditorAddresSteps
{
    private BSSAddADebtAndCreditorPage _bSSDAddADebtAndCreditorPage;
    private BSSCommonAddressPage _commonAddressPage;


    public BSSAddCreditorAddresSteps(BSSAddADebtAndCreditorPage bSSDAddADebtAndCreditorPage, BSSCommonAddressPage bSSCommonAddressPage)
    {
        _bSSDAddADebtAndCreditorPage = bSSDAddADebtAndCreditorPage;
        _commonAddressPage = bSSCommonAddressPage;
    }
    [When(@"I enter the creaditor address")]
    public void WhenIAddDebtTypeAmountAndReference(Table table)
    {
        foreach (var row in table.Rows)
        {
            string findAddressPostcode = row["FindAddress-Postcode"];
            string postcode = row["Postcode"];
            string line1 = row["AddressLine1"];
            string line2 = row["AddressLine2"];
            string townCity = row["City"];
            string specificAddress = row["SpecificAddress"];

            string expectedTitle = "Choose creditor address";
            _bSSDAddADebtAndCreditorPage.ValidatePageTitle(expectedTitle);
            _commonAddressPage.EnterAddress("postcode", line1, line2, townCity, "", postcode, "UK", specificAddress);
            _bSSDAddADebtAndCreditorPage.ClickSaveAndContinue();
        }
    }
}

