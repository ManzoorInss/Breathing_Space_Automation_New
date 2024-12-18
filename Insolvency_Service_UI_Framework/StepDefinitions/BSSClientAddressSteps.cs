using BSSTestAutomation.Common;
using BSSTestAutomation.Pages;
using TechTalk.SpecFlow;

namespace BSSTestAutomation.StepDefinitions
{
    [Binding]
    public class BSSClientAddressSteps
    {
        private BSSCommonAddressPage _bsscommonAddressPage;
        private BSSDebtorAddressesPage _bSSDebtorAddressesPage;

        public BSSClientAddressSteps(BSSCommonAddressPage bsscommonAddressPage, BSSDebtorAddressesPage bSSDebtorAddressesPage)
        {
            _bsscommonAddressPage = bsscommonAddressPage;
            _bSSDebtorAddressesPage = bSSDebtorAddressesPage;
        }

        [When(@"I enter the Client address")]
        public void WhenIEnterTheClientAddress(Table table)
        {
            foreach (var row in table.Rows)
            {
                string postcodeOption = row["FindAddress-Postcode"];
                string enterAddressManuallyOption = row["EnterAddressManually"];
                string postcode = row["Postcode"];
                string addressLine1 = row["AddressLine1"];
                string addressLine2 = row["AddressLine2"];
                string city = row["City"];
                string specificAddress = row["SpecificAddress"];

                if (postcodeOption.Equals("enterPostcode", StringComparison.OrdinalIgnoreCase))
                {
                    _bsscommonAddressPage.EnterPostcodeAndFindAddress(postcode, specificAddress);
                }
                else if (enterAddressManuallyOption.Equals("enterAddressManually", StringComparison.OrdinalIgnoreCase))
                {
                    _bsscommonAddressPage.EnterAddressManually(addressLine1, addressLine2, city, "", postcode, "");
                }
                else
                {
                    Console.WriteLine("No specific actions required. Clicking Save and Continue.");
                    _bsscommonAddressPage.AddressPageAddressSaveButton.Click();


                }
            }
        }



    }
        }

        //[Then(@"the error summary should be displayed")]
        //public void ThenTheErrorSummaryShouldBeDisplayed()
        //{
        //    _bsscommonAddressPage.ValidateErrorMessages();
        //}

        //[Then(@"the page title should be '(.*)'")]
        //public void ThenThePageTitleShouldBe(string expectedTitle)
        //{
        //    string actualTitle = _bsscommonAddressPage.AddressPageTitle.Text.Trim();
        //    if (!actualTitle.Equals(expectedTitle, StringComparison.OrdinalIgnoreCase))
        //    {
        //        throw new Exception($"Page title mismatch. Expected: {expectedTitle}, Actual: {actualTitle}");
        //    }
        //    Console.WriteLine($"Page title validated: {actualTitle}");
        //}
    

