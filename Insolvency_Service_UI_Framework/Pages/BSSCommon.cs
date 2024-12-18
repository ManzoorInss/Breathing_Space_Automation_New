using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BSSTestAutomation.Common
{
    public class BSSCommonAddressPage
    {
        private IWebDriver _driver;

        public BSSCommonAddressPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements
        public IWebElement AddressPageTitle => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));
        public IWebElement AddressPageAddressLine1 => _driver.FindElement(By.Id("Address1-input"));
        public IWebElement AddressPageAddressLine2 => _driver.FindElement(By.Id("Address2-input"));
        public IWebElement AddressPageAddressTownCity => _driver.FindElement(By.Id("TownCity-input"));
        public IWebElement AddressPageAddressCounty => _driver.FindElement(By.Id("County-input"));
        public IWebElement AddressPageAddressPostCode => _driver.FindElement(By.Id("Postcode-input"));
        public IWebElement AddressPageAddressSaveButton => _driver.FindElement(By.Id("save-button"));
        public IWebElement ManualAddressLink => _driver.FindElement(By.Id("address-manual"));
        public IWebElement FindAddressButton => _driver.FindElement(By.Id("search-button"));
        public IWebElement AddressPageErrorSummary => _driver.FindElement(By.Id("error-summary"));
        public IWebElement AddressPostcodeValidation => _driver.FindElement(By.Id("Postcode-validation"));
        public IWebElement CountryDropdown => _driver.FindElement(By.Id("Country"));
        public IWebElement SelectAddressDropdown => _driver.FindElement(By.Id("SelectedAddress"));

      
        // address-related actions using a switch-case statement.
   
        public void EnterAddress(string enter, string line1 = "", string line2 = "", string townCity = "", string county = "", string postcode = "", string country = "", string specificAddress = null)
        {
            switch (enter.ToLower())
            {
                case "postcode":
                    EnterPostcodeAndFindAddress(postcode, specificAddress);
                   // AddressPageAddressSaveButton.Click();
                    break;

                case "manual":
                    EnterAddressManually(line1, line2, townCity, county, postcode, country);
                    break;

                case "validateerrors":
                    ValidateErrorMessages();
                    break;

                default:
                    Console.WriteLine($"Invalid action: {enter}. Clicking Save and Continue.");
                    AddressPageAddressSaveButton.Click();
                    break;
            }
        }
       
        // Enters a postcode, clicks the "Find Address" button, selects a specific address or the first one, and validates it.
     
        public void EnterPostcodeAndFindAddress(string postcode, string specificAddress = null)
        {
            if (string.IsNullOrWhiteSpace(postcode))
            {
                Console.WriteLine("Postcode is empty. Cannot find address.");
                return;
            }

            AddressPageAddressPostCode.Clear();
            AddressPageAddressPostCode.SendKeys(postcode);
            FindAddressButton.Click();
            SelectAddressDropdown.Click();
            Console.WriteLine($"Postcode entered: {postcode} and clicked 'Find Address'.");

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => SelectAddressDropdown.Displayed);

            var addressOptions = new SelectElement(SelectAddressDropdown).Options;

            if (addressOptions.Count <= 1)
            {
                throw new Exception("No address options available in the dropdown.");
            }

            // Select a specific address if provided
            if (!string.IsNullOrWhiteSpace(specificAddress))
            {
                foreach (var option in addressOptions)
                {
                    if (option.Text.Equals(specificAddress, StringComparison.OrdinalIgnoreCase))
                    {
                        new SelectElement(SelectAddressDropdown).SelectByText(specificAddress);
                        Console.WriteLine($"Specific address selected: {specificAddress}");
                        AddressPageAddressSaveButton.Click();
                        Console.WriteLine("Address saved.");

                        return;
                    }
                }

                throw new Exception($"Specified address '{specificAddress}' not found in the dropdown options.");
            }

            // If no specific address is provided, select the first available address
            string firstAddress = addressOptions[1].Text; // Index 0 is the placeholder
            new SelectElement(SelectAddressDropdown).SelectByIndex(1);
            Console.WriteLine($"First available address selected: {firstAddress}");
            AddressPageAddressSaveButton.Click();
            Console.WriteLine("Address saved.");

        }

        public void EnterAddressByPostcode(string postcode)
        {
            AddressPageAddressPostCode.Clear();
            AddressPageAddressPostCode.SendKeys(postcode);
            Console.WriteLine($"Entered postcode: {postcode}");

            FindAddressButton.Click();
            Console.WriteLine("Clicked 'Find Address' button.");

            var addressDropdown = new SelectElement(SelectAddressDropdown);
            addressDropdown.SelectByIndex(1); // Selecting the first address from the dropdown
            Console.WriteLine("Selected the first address from the dropdown.");
        }

        public void EnterAddressManually(string line1, string line2, string townCity, string county, string postcode, string country)
        {
            ManualAddressLink.Click();
            Console.WriteLine("Clicked 'Enter Address Manually'.");

            if (!string.IsNullOrWhiteSpace(line1))
            {
                AddressPageAddressLine1.Clear();
                AddressPageAddressLine1.SendKeys(line1);
                Console.WriteLine($"Address Line 1: {line1}");
            }

            if (!string.IsNullOrWhiteSpace(line2))
            {
                AddressPageAddressLine2.Clear();
                AddressPageAddressLine2.SendKeys(line2);
                Console.WriteLine($"Address Line 2: {line2}");
            }

            if (!string.IsNullOrWhiteSpace(townCity))
            {
                AddressPageAddressTownCity.Clear();
                AddressPageAddressTownCity.SendKeys(townCity);
                Console.WriteLine($"Town/City: {townCity}");
            }

            if (!string.IsNullOrWhiteSpace(county))
            {
                AddressPageAddressCounty.Clear();
                AddressPageAddressCounty.SendKeys(county);
                Console.WriteLine($"County: {county}");
            }

            if (!string.IsNullOrWhiteSpace(postcode))
            {
                AddressPageAddressPostCode.Clear();
                AddressPageAddressPostCode.SendKeys(postcode);
                Console.WriteLine($"Postcode: {postcode}");
            }

            if (!string.IsNullOrWhiteSpace(country))
            {
                var countryDropdown = new SelectElement(CountryDropdown);
                countryDropdown.SelectByText(country);
                Console.WriteLine($"Country selected: {country}");
            }

            AddressPageAddressSaveButton.Click();
            Console.WriteLine("Address saved.");
        }

        public void ValidateErrorMessages()
        {
            if (AddressPageErrorSummary.Displayed)
            {
                Console.WriteLine($"Error summary: {AddressPageErrorSummary.Text}");
            }

            if (!string.IsNullOrEmpty(AddressPostcodeValidation.Text))
            {
                Console.WriteLine($"Validation Error: {AddressPostcodeValidation.Text}");
            }
        }
    }
}
