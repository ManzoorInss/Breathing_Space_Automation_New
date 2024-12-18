using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace BSS_Automation_Framework.Pages.oldPages
{
    public class BSSAccountSearchResultPage
    {
        private IWebDriver _driver;

        public BSSAccountSearchResultPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements 
        public IWebElement BackLink => _driver.FindElement(By.Id("back-link"));

        public IWebElement PageTitle => _driver.FindElement(By.Id("account-search-result-text"));

        public IWebElement PageHeading => _driver.FindElement(By.Id("account-search-result-heading"));

        public IWebElement SearchTypeRef => _driver.FindElement(By.Id("account-search-result-by-reference"));

        public IWebElement SearchTypeSurname => _driver.FindElement(By.Id("account-search-result-by-surname"));

        public IWebElement SearchTypedob => _driver.FindElement(By.Id("account-search-result-by-dob"));

        public IWebElement ChangeSearchTerms => _driver.FindElement(By.Id("account-search-change-filter"));

        public IWebElement ShowCount => _driver.FindElement(By.Id("account-search-result-helper"));

        public IWebElement ResultCount => _driver.FindElement(By.Id("search-result-count"));

        public IWebElement DebtorNameLink => _driver.FindElement(By.Id("acount-search-result-0"));

        public IWebElement BSReference => _driver.FindElement(By.Id("account-search-result-reference-0"));

        public IWebElement BSStartandEndDate => _driver.FindElement(By.Id("account-search-result-date-0"));

        public IWebElement BSDOB => _driver.FindElement(By.Id("account-search-result-dob-0"));

        public IWebElement BSAddress => _driver.FindElement(By.Id("account-search-result-address-0"));

        // For multiple elements, return as a list of IWebElements
        public IReadOnlyCollection<IWebElement> BSAddressHidden => _driver.FindElements(By.Id("account-search-result-address-0"));

        public IWebElement BSMoneyAdviser => _driver.FindElement(By.Id("account-search-result-org-0"));

        public IWebElement BSState => _driver.FindElement(By.CssSelector("hr + strong"));

        public IWebElement NoResultsFoundMsg => _driver.FindElement(By.Id("account-search-result-no-item"));

        public IWebElement TryAgainMsg => _driver.FindElement(By.Id("account-search-result-try-again"));

        public IWebElement BSType => _driver.FindElement(By.Id("account-search-result-moratorium-type-0"));
    }
}
