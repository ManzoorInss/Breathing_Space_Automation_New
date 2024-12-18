using System;
using System.Diagnostics.Metrics;
using BSSTestAutomation.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BSS_Automation_Framework.Pages
{
    public class BSSDebtorAddBusinessDetailsPage
    {
        private IWebDriver _driver;
        private BSSCommonAddressPage _commonAddressPage;
        public BSSDebtorAddBusinessDetailsPage(IWebDriver driver,BSSCommonAddressPage bSSCommonAddressPage)
        {
            _driver = driver;
            _commonAddressPage = bSSCommonAddressPage;
        }

        // Page Elements

        public IWebElement PageTitle => _driver.FindElement(By.ClassName("govuk-heading-xl"));
        public IWebElement BusinessName => _driver.FindElement(By.Id("BusinessName-input"));
        public IWebElement NewBusinessAddress => _driver.FindElement(By.Id("submit-no"));
        public IWebElement CurrentAddressAsBusiness => _driver.FindElement(By.Id("submit-yes"));
        public IWebElement BusinessNameLabel => _driver.FindElement(By.Id("BusinessName-label"));
        public IWebElement SaveAndContinueBtn => _driver.FindElement(By.Id("debtor-add-business-save"));
        public IWebElement BackButtonLink => _driver.FindElement(By.Id("back-link"));
        public IWebElement ChooseAddressLabel => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));
        public IWebElement CurrentAddressLabel => _driver.FindElement(By.Id("debtor-add-business-curr-add"));
        public IWebElement AddAnotherAddressLabel => _driver.FindElement(By.Id("debtor-add-business-new-add"));
        public IWebElement ErrorBusinessName => _driver.FindElement(By.Id("BusinessName-validation"));
        public IWebElement ErrorList => _driver.FindElement(By.Id("error-list"));
        public IWebElement ErrorAddressSelection => _driver.FindElement(By.CssSelector("fieldset.govuk-fieldset span"));

        public void ValidatePageTitle(string expectedTitle)
        {
            string actualTitle = PageTitle.Text.Trim();
            expectedTitle = expectedTitle.Trim();

            if (!actualTitle.Equals(expectedTitle, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page title mismatch. Expected: {expectedTitle}, Actual: {actualTitle}");
            }

            Console.WriteLine($"Page title validated successfully: {actualTitle}");
        }

        public void EnterBusinessDetails(string businessName, string businessAddressOption,
                                         string enterAddressManually, string findAddressPostcode,
                                         string line1 = "", string line2 = "", string townCity = "",
                                         string postcode = "", string specificAddress = null)
        {
            // Validate and enter the business name
            if (!string.IsNullOrWhiteSpace(businessName))
            {
                BusinessName.Clear();
                BusinessName.SendKeys(businessName);
                Console.WriteLine($"Entered business name: {businessName}");
            }
            else
            {
                throw new Exception("Business name is required but was not provided.");
            }

            // Handle business address options
            switch (businessAddressOption?.ToLower())
            {
                case "sameashomeaddress":
                    CurrentAddressAsBusiness.Click();
                    // Click Save and Continue
                    SaveAndContinueBtn.Click();
                    Console.WriteLine("Selected 'Same as Home Address' option.");
                    break;

                case "anotheraddress":
                    NewBusinessAddress.Click();
                    Console.WriteLine("Selected 'Another Address' option.");
                    // Click Save and Continue
                    SaveAndContinueBtn.Click();
                    Console.WriteLine("Clicked 'Save and Continue' button.");

                    // address entry
                    if (!string.IsNullOrWhiteSpace(findAddressPostcode) && findAddressPostcode.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                    {
                        _commonAddressPage.EnterAddress("postcode", line1, line2, townCity, "", postcode, "UK", specificAddress);
                    }
                    else if (!string.IsNullOrWhiteSpace(enterAddressManually) && enterAddressManually.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                    {
                        _commonAddressPage.EnterAddress("manual", line1, line2, townCity, "", postcode, "UK");
                    }
                    else
                    {
                        throw new Exception("Address entry method not specified.");
                    }
                    break;

                default:
                    throw new ArgumentException($"Invalid business address option: {businessAddressOption}");
            }

   
        }
    }
}