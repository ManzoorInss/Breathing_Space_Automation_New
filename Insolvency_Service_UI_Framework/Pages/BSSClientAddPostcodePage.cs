using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace BSSTestAutomation.Pages
{
    public class BSSClientAddPostcodePage
    {
        private IWebDriver _driver;

        public BSSClientAddPostcodePage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page elements

        public IWebElement PageTitle => _driver.FindElement(By.CssSelector(".govuk-fieldset__heading"));
        public IWebElement ErrorSummary => _driver.FindElement(By.Id("error-summary"));
        public IWebElement SummaryErrors => _driver.FindElement(By.Id("error-list"));
        public IWebElement PostcodeValidation => _driver.FindElement(By.Id("Postcode-validation"));
        public IWebElement BackLink => _driver.FindElement(By.Id("back-link"));
        public IWebElement PostcodeInput => _driver.FindElement(By.Id("Postcode-input"));
        public IWebElement FindAddressButton => _driver.FindElement(By.Id("search-button"));
        public IWebElement ManualAddressLink => _driver.FindElement(By.Id("address-manual"));
        public IWebElement ChangeLink => _driver.FindElement(By.Id("address-search-change-postcode"));
        public IWebElement AddressList => _driver.FindElement(By.Id("SelectedAddress"));
        public IWebElement SaveAndContinueBtn => _driver.FindElement(By.Id("save-button"));

        //Methods

        public void ValidatePageTitle(string expectedTitle)
        {
            string actualTitle = _driver.Title; 
            Console.WriteLine($"Page title validated successfully: {actualTitle}");
        }

        public void ValidateLabelText(IWebElement labelElement, string expectedLabel)
        {
            string actualLabel = labelElement.Text.Trim(); 
            Console.WriteLine($"Label text validated successfully: {actualLabel}");
        }


        // Method to search address in dropdown
        public void AddressEntry(string enter, string postcode = "", string addressLine1 = "", string addressLine2 = "", string city = "")
        {
            switch (enter.ToLower())
            {
                case "postcode":
                    EnterPostcodeAndFindAddress(postcode);
                    break;

                case "manual":
                    EnterAddressManually(addressLine1, addressLine2, city);
                    break;

                default:
                    Console.WriteLine("Invalid action. Clicking Save and Continue directly.");
                    SaveAndContinueBtn.Click();
                    break;
            }
        }

        private void EnterPostcodeAndFindAddress(string postcode)
        {
            if (string.IsNullOrWhiteSpace(postcode))
            {
                Console.WriteLine("Postcode is empty. Cannot find address.");
                return;
            }

            PostcodeInput.Clear();
            PostcodeInput.SendKeys(postcode);
            FindAddressButton.Click();
            Console.WriteLine($"Entered postcode: {postcode} and clicked 'Find Address'.");
        }

        // Enters the address manually.

        private void EnterAddressManually(string addressLine1, string addressLine2, string city)
        {
            ManualAddressLink.Click();
            Console.WriteLine("Clicked 'Enter address manually'.");

            if (!string.IsNullOrWhiteSpace(addressLine1))
            {
                _driver.FindElement(By.Id("address-line1")).SendKeys(addressLine1);
            }

            if (!string.IsNullOrWhiteSpace(addressLine2))
            {
                _driver.FindElement(By.Id("address-line2")).SendKeys(addressLine2);
            }

            if (!string.IsNullOrWhiteSpace(city))
            {
                _driver.FindElement(By.Id("address-town")).SendKeys(city);
            }

            Console.WriteLine("Entered address manually.");
        }
    }
}


        //public void EnterPostcodeAndSelectRandomAddress(string postcode)
        //{
        //    // Enter the postcode
        //    PostcodeInput.Clear();
        //    PostcodeInput.SendKeys(postcode);
        //    Console.WriteLine($"Entered postcode: {postcode}");

        //    // Click the "Find Address" button
        //    FindAddressButton.Click();
        //    Console.WriteLine("Clicked 'Find Address' button.");

        //    // Wait for the dropdown to populate
        //    WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        //    wait.Until(driver => AddressDropdown.Displayed && AddressDropdown.FindElements(By.TagName("option")).Count > 1);

        //    // Get all options in the dropdown
        //    var addressOptions = AddressDropdown.FindElements(By.TagName("option")).ToList();

        //    if (addressOptions.Count <= 1)
        //    {
        //        throw new Exception("No address options available in the dropdown.");
        //    }

        //    // Select a random address
        //    Random random = new Random();
        //    int randomIndex = random.Next(1, addressOptions.Count); // Skip the first option (placeholder)
        //    addressOptions[randomIndex].Click();
        //    Console.WriteLine($"Selected random address: {addressOptions[randomIndex].Text}");
        
    
//}
    
