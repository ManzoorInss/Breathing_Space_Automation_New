using System;
using TechTalk.SpecFlow;
using BSS_Automation_Framework.Pages;
using BSSTestAutomation.Common;

namespace BSSTestAutomation.StepDefinitions
{
    [Binding]
    public class BSSDebtorBusinessAddressSteps
    {
        private readonly BSSCommonAddressPage _commonAddressPage;

        public BSSDebtorBusinessAddressSteps(BSSCommonAddressPage commonAddressPage)
        {
            _commonAddressPage = commonAddressPage;
        }

        [When(@"I enter the debtor another address")]
        public void WhenIEnterTheDebtorAnotherAddress(Table table)
        {
            foreach (var row in table.Rows)
            {
                string enterAddressManually = row["EnterAddressManually"];
                string findAddressPostcode = row["FindAddress-Postcode"];
                string postcode = row["Postcode"];
                string addressLine1 = row["AddressLine1"];
                string addressLine2 = row["AddressLine2"];
                string city = row["City"];
                string specificAddress = row["SpecificAddress"];

                if (!string.IsNullOrWhiteSpace(enterAddressManually))
                {
                    Console.WriteLine("Entering address manually...");
                    _commonAddressPage.EnterAddress(
                        enter: "manual",
                        line1: addressLine1,
                        line2: addressLine2,
                        townCity: city,
                        county: "",
                        postcode: postcode,
                        country: "United Kingdom"
                    );
                }
                else if (!string.IsNullOrWhiteSpace(findAddressPostcode))
                {
                    Console.WriteLine("Finding address using postcode...");
                    _commonAddressPage.EnterAddress(
                        enter: "postcode",
                        postcode: postcode,
                        specificAddress: specificAddress
                    );
                }
                else
                {
                    Console.WriteLine("No address entry method provided. Defaulting to save.");
                    _commonAddressPage.EnterAddress(enter: "validateerrors");
                }
            }
        }
    }
}
