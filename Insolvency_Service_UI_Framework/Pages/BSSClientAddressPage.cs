using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BSSTestAutomation.Pages
{
    public class BSSClientAddressPage
    {
        private IWebDriver _driver;

        public BSSClientAddressPage(IWebDriver driver)
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
        public IWebElement AddressPageErrorSummary => _driver.FindElement(By.Id("error-summary"));
        public IWebElement AddressPageErrorSummaryErrors => _driver.FindElement(By.Id("error-list"));
        public IWebElement AddressBackButton => _driver.FindElement(By.ClassName("govuk-back-link"));
        public IWebElement AddressTownCityValidation => _driver.FindElement(By.Id("TownCity-validation"));
        public IWebElement AddressBuildStreetValidation => _driver.FindElement(By.Id("Address1-validation"));
        public IWebElement AddressCountyValidation => _driver.FindElement(By.Id("County-validation"));
        public IWebElement AddressPostcodeValidation => _driver.FindElement(By.Id("Postcode-validation"));
        public IWebElement CountryDropdown => _driver.FindElement(By.Id("Country"));

        // Methods

        public void FillOutAddressForm(string line1, string line2, string townCity, string county, string postcode, string country)
        {
            if (string.IsNullOrWhiteSpace(line1))
                throw new ArgumentException("Address Line 1 is required.");
            AddressPageAddressLine1.Clear();
            AddressPageAddressLine1.SendKeys(line1);

            if (!string.IsNullOrWhiteSpace(line2))
            {
                AddressPageAddressLine2.Clear();
                AddressPageAddressLine2.SendKeys(line2);
            }

            if (string.IsNullOrWhiteSpace(townCity))
                throw new ArgumentException("Town/City is required.");
            AddressPageAddressTownCity.Clear();
            AddressPageAddressTownCity.SendKeys(townCity);

            if (string.IsNullOrWhiteSpace(county))
                throw new ArgumentException("County is required.");
            AddressPageAddressCounty.Clear();
            AddressPageAddressCounty.SendKeys(county);

            if (string.IsNullOrWhiteSpace(postcode))
                throw new ArgumentException("Postcode is required.");
            AddressPageAddressPostCode.Clear();
            AddressPageAddressPostCode.SendKeys(postcode);

            var countryDropdown = new SelectElement(CountryDropdown);
            countryDropdown.SelectByText(country);

            AddressPageAddressSaveButton.Click();
        }


        public void ValidateErrorMessages()
        {
            if (!string.IsNullOrEmpty(AddressTownCityValidation.Text))
                throw new Exception($"Validation Error: {AddressTownCityValidation.Text}");
            if (!string.IsNullOrEmpty(AddressBuildStreetValidation.Text))
                throw new Exception($"Validation Error: {AddressBuildStreetValidation.Text}");
            if (!string.IsNullOrEmpty(AddressCountyValidation.Text))
                throw new Exception($"Validation Error: {AddressCountyValidation.Text}");
            if (!string.IsNullOrEmpty(AddressPostcodeValidation.Text))
                throw new Exception($"Validation Error: {AddressPostcodeValidation.Text}");
        }
    }
}
