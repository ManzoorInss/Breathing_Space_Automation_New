using OpenQA.Selenium;
using System;

namespace BSSTestAutomation.Pages
{
    public class BSSDebtorDeclarationPages
    {
        private IWebDriver _driver;

        // Constructor
        public BSSDebtorDeclarationPages(IWebDriver driver)
        {
            _driver = driver;
        }


        // Page Elements
        public IWebElement HeaderTitle => _driver.FindElement(By.CssSelector("header .govuk-header__link--service-name"));
        public IWebElement SignOutLink => _driver.FindElement(By.Id("govuk-header-link-sign-out"));

        // Navigation Links
        public IWebElement HomeLink => _driver.FindElement(By.Id("home-navigation-home-link"));
        public IWebElement SearchLink => _driver.FindElement(By.Id("home-navigation-search-link"));
        public IWebElement GuidanceLink => _driver.FindElement(By.Id("view-guidance-link"));
        public IWebElement ManageOrganisationLink => _driver.FindElement(By.Id("view-management-link"));


        // Declaration Section
        public IWebElement DeclarationHeader => _driver.FindElement(By.CssSelector("#content .govuk-heading-xl"));
        public IWebElement DeclarationAgreeButton => _driver.FindElement(By.Id("debtor-declaration-agree-btn"));

        // Methods

        public void ValidateHeaderTitle(string expectedTitle)
        {
            string actualTitle = HeaderTitle.Text.Trim();
            if (!actualTitle.Equals(expectedTitle, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Header title mismatch. Expected: '{expectedTitle}', but got: '{actualTitle}'.");
            }
            Console.WriteLine($"Header title validated successfully: {actualTitle}");
        }

        public void ClickSignOut()
        {
            SignOutLink.Click();
            Console.WriteLine("Clicked the 'Sign Out' link.");
        }


        public void NavigateToSection(string section)
        {
            switch (section.Trim().ToLower())
            {
                case "home":
                    HomeLink.Click();
                    Console.WriteLine("Navigated to 'Home' section.");
                    break;

                case "search":
                    SearchLink.Click();
                    Console.WriteLine("Navigated to 'Search' section.");
                    break;

                case "guidance":
                    GuidanceLink.Click();
                    Console.WriteLine("Navigated to 'Guidance' section.");
                    break;

                case "manage organisation":
                    ManageOrganisationLink.Click();
                    Console.WriteLine("Navigated to 'Manage Organisation' section.");
                    break;

                default:
                    throw new ArgumentException($"Invalid section: {section}");
            }
        }

        public void ValidateDeclarationHeader(string expectedText)
        {
            string actualText = DeclarationHeader.Text.Trim();
            if (!actualText.Equals(expectedText, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Declaration header mismatch. Expected: '{expectedText}', but got: '{actualText}'.");
            }
            Console.WriteLine($"Declaration header validated successfully: {actualText}");
        }

        public void AgreeAndSubmit()
        {
            DeclarationAgreeButton.Click();
            Console.WriteLine("Clicked 'Agree and Submit' button.");
        }


    }
}
