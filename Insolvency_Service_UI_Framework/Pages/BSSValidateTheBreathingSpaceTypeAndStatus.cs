using OpenQA.Selenium;
using System;

namespace BSSTestAutomation.Pages
{
    public class BSSTypeAndStatusValidationPage
    {
        private  IWebDriver _driver;
        public BSSTypeAndStatusValidationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements
        public IWebElement PageHeader => _driver.FindElement(By.Id("account-search-result-text"));
        public IWebElement SearchResultHeading => _driver.FindElement(By.Id("account-search-result-heading"));
        public IWebElement BreathingSpaceReference => _driver.FindElement(By.CssSelector("dd.dd-card-detail"));
        public IWebElement NameLink => _driver.FindElement(By.Id("acount-search-result-0"));
        public IWebElement StatusTag => _driver.FindElement(By.Id("account-search-result-status-0"));
        public IWebElement MentalHealthTag => _driver.FindElement(By.Id("account-search-result-moratorium-type-0"));
        public IWebElement ReferenceText => _driver.FindElement(By.Id("account-search-result-reference-0"));
        public IWebElement StartDateText => _driver.FindElement(By.Id("account-search-result-date-0"));
        public IWebElement DOBText => _driver.FindElement(By.Id("account-search-result-dob-0"));
        public IWebElement AddressText => _driver.FindElement(By.Id("account-search-result-address-0"));
        public IWebElement MoneyAdviceOrgText => _driver.FindElement(By.Id("account-search-result-org-0"));

        // Validation Methods

        public void ValidatePageHeader(string expectedHeader)
        {
            string actualHeader = PageHeader.Text.Trim();
            if (!actualHeader.Equals(expectedHeader, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page header mismatch. Expected: '{expectedHeader}', Actual: '{actualHeader}'");
            }
            Console.WriteLine($"Page header validated successfully: {actualHeader}");
        }

        public void ValidateSearchResultHeading(string expectedHeading)
        {
            string actualHeading = SearchResultHeading.Text.Trim();
            if (!actualHeading.Equals(expectedHeading, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Search result heading mismatch. Expected: '{expectedHeading}', Actual: '{actualHeading}'");
            }
            Console.WriteLine($"Search result heading validated successfully: {actualHeading}");
        }

        public void ValidateBreathingSpaceReference(string expectedReference)
        {
            string actualReference = BreathingSpaceReference.Text.Trim();
            if (!actualReference.Equals(expectedReference, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Reference mismatch. Expected: '{expectedReference}', Actual: '{actualReference}'");
            }
            Console.WriteLine($"Breathing Space reference validated successfully: {actualReference}");
        }

        public void ValidateName(string expectedName)
        {
            string actualName = NameLink.Text.Trim();
            if (!actualName.Equals(expectedName, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Name mismatch. Expected: '{expectedName}', Actual: '{actualName}'");
            }
            Console.WriteLine($"Name validated successfully: {actualName}");
        }

        public void ValidateStatus(string expectedStatus)
        {
            string actualStatus = StatusTag.Text.Trim();
            if (!actualStatus.Equals(expectedStatus, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Status mismatch. Expected: '{expectedStatus}', Actual: '{actualStatus}'");
            }
            Console.WriteLine($"Status validated successfully: {actualStatus}");
        }

        public void ValidateMentalHealthTag(string expectedTag)
        {
            string actualTag = MentalHealthTag.Text.Trim();
            if (!actualTag.Equals(expectedTag, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Mental Health tag mismatch. Expected: '{expectedTag}', Actual: '{actualTag}'");
            }
            Console.WriteLine($"Mental Health tag validated successfully: {actualTag}");
        }

        public void ValidateDOB(string expectedDOB)
        {
            string actualDOB = DOBText.Text.Trim();
            if (!actualDOB.Equals(expectedDOB, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"DOB mismatch. Expected: '{expectedDOB}', Actual: '{actualDOB}'");
            }
            Console.WriteLine($"DOB validated successfully: {actualDOB}");
        }

        public void ValidateAddress(string expectedAddress)
        {
            string actualAddress = AddressText.Text.Trim();
            if (!actualAddress.Equals(expectedAddress, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Address mismatch. Expected: '{expectedAddress}', Actual: '{actualAddress}'");
            }
            Console.WriteLine($"Address validated successfully: {actualAddress}");
        }

        public void ValidateMoneyAdviceOrganisation(string expectedOrganisation)
        {
            string actualOrganisation = MoneyAdviceOrgText.Text.Trim();
            if (!actualOrganisation.Equals(expectedOrganisation, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Money Advice Organisation mismatch. Expected: '{expectedOrganisation}', Actual: '{actualOrganisation}'");
            }
            Console.WriteLine($"Money Advice Organisation validated successfully: {actualOrganisation}");
        }

        // Navigation Methods

        public void ClickOnNameLink()
        {
            NameLink.Click();
            Console.WriteLine("Clicked on the name link to view details.");
        }
    }
}
