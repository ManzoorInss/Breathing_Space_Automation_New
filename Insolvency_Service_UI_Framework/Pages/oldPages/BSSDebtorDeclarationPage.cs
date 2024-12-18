using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BSSTestAutomation.Pages
{
    public class BSSDebtorDeclarationPage
    {
        private readonly IWebDriver _driver;

        public BSSDebtorDeclarationPage(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        // Page Elements (using Selenium's By locators)

        // Page Title
        public IWebElement PageTitle => _driver.FindElement(By.ClassName("govuk-heading-xl"));

        // Declaration Information
        public IWebElement DeclarationInfo1 => _driver.FindElement(By.CssSelector("p.govuk-body"));

        // Declaration Bullet Points
        public IWebElement DeclarationBullet => _driver.FindElement(By.Id("debtor-declaration-bullet-point-1"));
        public IWebElement DeclarationBullet1 => _driver.FindElement(By.Id("debtor-declaration-bullet-point-2"));
        public IWebElement DeclarationBullet2 => _driver.FindElement(By.Id("debtor-declaration-bullet-point-3"));
        public IWebElement DeclarationBullet3 => _driver.FindElement(By.Id("debtor-declaration-bullet-point-4"));
        public IWebElement DeclarationBullet4 => _driver.FindElement(By.Id("debtor-declaration-bullet-point-5"));
        public IWebElement DeclarationBullet5 => _driver.FindElement(By.Id("debtor-declaration-bullet-point-6"));
        public IWebElement DeclarationBullet6 => _driver.FindElement(By.Id("debtor-declaration-bullet-point-7"));
        public IWebElement DeclarationBullet7 => _driver.FindElement(By.Id("debtor-declaration-bullet-point-8"));

        // Save Button
        public IWebElement SaveButton => _driver.FindElement(By.Id("debtor-declaration-agree-btn"));

        // Debtor Declaration Name
        public IWebElement DebtorDeclarationName => _driver.FindElement(By.Id("debtor-declaration-you-also-agree-that"));

        // Back Link
        public IWebElement BackLink => _driver.FindElement(By.Id("back-link"));

        /// <summary>
        /// Clicks the Save button.
        /// </summary>
        public void ClickSave()
        {
            SaveButton.Click();
            // Optionally, add a wait for the next page to load if necessary.
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.Url.Contains("next-page-url-part"));  // Replace with actual URL part of the next page.
        }

        /// <summary>
        /// Clicks the Back link.
        /// </summary>
        public void ClickBack()
        {
            BackLink.Click();
        }
    }
}