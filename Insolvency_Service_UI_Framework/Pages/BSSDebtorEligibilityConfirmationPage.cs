using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BSSTestAutomation.Pages
{
    public class BSSDebtorEligibilityConfirmationPage
    {
        private IWebDriver _driver;

        public BSSDebtorEligibilityConfirmationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements 
        public IWebElement ConfirmEvidenceCheckbox => _driver.FindElement(By.Id("IsEligible"));
        public IWebElement SaveAndContinueButton => _driver.FindElement(By.Id("debtor-eligibility-save"));
        public IWebElement PageHeader => _driver.FindElement(By.CssSelector("h1.govuk-heading-l"));

        public void ValidatePageHeader(string expectedHeader)
        {
            string actualHeader = PageHeader.Text.Trim();
            if (!actualHeader.Equals(expectedHeader, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Header mismatch. Expected: {expectedHeader}, but got: {actualHeader}");
            }
            Console.WriteLine($"Page header validated: {actualHeader}");
        }

        public void ConfirmEligibilityAndProceed()
        {
            ConfirmEvidenceCheckbox.Click();
            Console.WriteLine("Checked 'I confirm I have seen the evidence and carried out a credit check on my client'.");
            SaveAndContinueButton.Click();
            Console.WriteLine("Clicked 'Save and Continue' button.");
        }
    }
}


      
