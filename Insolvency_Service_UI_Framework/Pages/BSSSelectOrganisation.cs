using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace BSSTestAutomation.Pages
{
    public class BSSSelectOrganisationPage
    {
        private IWebDriver _driver;

        public BSSSelectOrganisationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements
        public IWebElement HomePageTitle => _driver.FindElement(By.Id("organisation-selector-heading"));
        public IWebElement BSSOrganisation => _driver.FindElement(By.Id("organisation-selector"));
        public IWebElement SaveAndContinueBtn => _driver.FindElement(By.Id("organisation-selector-submit"));

        // Methods
        public void ValidatePageHeader(string expectedHeader)
        {
            string actualHeader = HomePageTitle.Text.Trim();
            if (!actualHeader.Equals(expectedHeader, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page header mismatch. Expected: '{expectedHeader}', Actual: '{actualHeader}'");
            }
            Console.WriteLine($"Page header validated successfully: '{actualHeader}'");
        }

        // Select an organisation 
        public void SelectOrganisation(string organisation)
        {
            var selectElement = new SelectElement(BSSOrganisation);
            selectElement.SelectByText(organisation);
            Console.WriteLine($"Selected organisation: {organisation}");
            SaveAndContinueBtn.Click();
        }
    }
}
