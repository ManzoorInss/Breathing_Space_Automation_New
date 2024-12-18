using BSSTestAutomation.Pages;
using TechTalk.SpecFlow;

namespace BSSTestAutomation.StepDefinitions
    {
        [Binding]
        public class BSSDebtorAddressesSteps
        {
            private readonly BSSDebtorAddressesPage _debtorAddressesPage;

            public BSSDebtorAddressesSteps(BSSDebtorAddressesPage debtorAddressesPage)
            {
                _debtorAddressesPage = debtorAddressesPage;
            }

            [When(@"I enter the Client address summary page")]
            public void WhenIEnterTheClientAddressSummaryPage(Table table)
            {
                foreach (var row in table.Rows)
                {
                    // Extract data from the table
                    string changeAddress = row["ChangeCurrentAddress"];
                    string hideAddress = row["HideAddress"];
                    string addPreviousAddress = row["AddPreviousAddress"];
                    string postcode = row["Postcode"];
                    string addressLine1 = row["AddressLine1"];
                    string addressLine2 = row["AddressLine2"];
                    string city = row["City"];
                    string specificAddress = row["SpecificAddress"];

                   _debtorAddressesPage.ValidatePageHeader("Client Addresses");

                   
                    if (changeAddress.Equals("ChangeCurrentAddress", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Performing 'Change Address' action...");
                        _debtorAddressesPage.UpdateAddressDetails("changecurrentaddress", addressLine1, addressLine2, city, "", postcode, "", specificAddress);
                    }

                    if (hideAddress.Equals("HideAddress", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Performing 'Hide Address' action...");
                        _debtorAddressesPage.UpdateAddressDetails("hideadress");
                    }

                    if (addPreviousAddress.Equals("AddPreviousAddress", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Performing 'Add Previous Address' action...");
                        _debtorAddressesPage.UpdateAddressDetails("add previous address", addressLine1, addressLine2, city, "", postcode, "", specificAddress);
                    }

                    // Default action if no conditions are met
                    if (string.IsNullOrWhiteSpace(changeAddress) && string.IsNullOrWhiteSpace(hideAddress) && string.IsNullOrWhiteSpace(addPreviousAddress))
                    {
                        Console.WriteLine("No specific actions required. Clicking Save and Continue.");
                        _debtorAddressesPage.ClickSaveAndContinue();
                    }
                }
            }
        }
    }
