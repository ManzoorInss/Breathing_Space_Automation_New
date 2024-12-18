using System;
using OpenQA.Selenium;

namespace BSSTestAutomation.Pages
{
    public class BSSDebtDetailsPage
    {
        private IWebDriver _driver;

        public BSSDebtDetailsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements 

        public IWebElement PageTitle => _driver.FindElement(By.Id("debt-details-heading"));
        public IWebElement SaveAndContinueBtn => _driver.FindElement(By.Id("next-step"));
        public IWebElement BackLink => _driver.FindElement(By.Id("back-link"));

        public IWebElement NameLabel => _driver.FindElement(By.Id("debt-details-name-label"));
        public IWebElement AddressLabel => _driver.FindElement(By.Id("debt-details-address-label"));
        public IWebElement AddressHiddenLabel => _driver.FindElement(By.Id("debt-details-address-label"));

        public IWebElement DebtTypeLabel => _driver.FindElement(By.Id("debt-details-debt-type"));
        public IWebElement CreditorName => _driver.FindElement(By.Id("creditor-name"));
        public IWebElement CreditorNameChangeLink => _driver.FindElement(By.Id("creditor-name-change"));
        public IWebElement CreditorAddressChangeLink => _driver.FindElement(By.Id("creditor-address-change"));
        public IWebElement DebtTypeChangeLink => _driver.FindElement(By.Id("debt-change"));

        public IWebElement FirstLineOfAddress => _driver.FindElement(By.Id("creditor-address-line1"));
        public IWebElement SecondLineOfAddress => _driver.FindElement(By.Id("creditor-address-line2"));
        public IWebElement ThirdLineOfAddress => _driver.FindElement(By.Id("creditor-address-city"));
        public IWebElement FourthLineOfAddress => _driver.FindElement(By.Id("creditor-address-county"));
        public IWebElement FifthLineOfAddress => _driver.FindElement(By.Id("creditor-address-postcode"));

        public IWebElement DebtType => _driver.FindElement(By.Id("debt-details-debt-type"));
        public IWebElement DebtAmount => _driver.FindElement(By.Id("debt-amount"));
        public IWebElement DebtReference => _driver.FindElement(By.Id("debt-reference"));

        //Methods
        public void ClickSaveAndContinue()
        {
            SaveAndContinueBtn.Click();
        }

        public void ClickBack()
        {
            BackLink.Click();
        }

        public void FillCreditorAddress(string line1, string line2, string city, string county, string postcode)
        {
            FirstLineOfAddress.Clear();
            FirstLineOfAddress.SendKeys(line1);

            SecondLineOfAddress.Clear();
            SecondLineOfAddress.SendKeys(line2);

            ThirdLineOfAddress.Clear();
            ThirdLineOfAddress.SendKeys(city);

            FourthLineOfAddress.Clear();
            FourthLineOfAddress.SendKeys(county);

            FifthLineOfAddress.Clear();
            FifthLineOfAddress.SendKeys(postcode);
        }

    }
}