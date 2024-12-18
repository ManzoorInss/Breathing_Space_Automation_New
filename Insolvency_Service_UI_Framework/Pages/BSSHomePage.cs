using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading.Tasks;

namespace BSSTestAutomation.Pages
{
    public class BSSHomePage
    {
        private readonly IWebDriver _driver;

        public BSSHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements

        public IWebElement HomePageTitle => _driver.FindElement(By.Id("page-caption"));
        public IWebElement OrganisationName => _driver.FindElement(By.Id("organisation-name"));
        public IWebElement HomePageNavHomeLink => _driver.FindElement(By.Id("home-navigation-home-link"));
        public IWebElement HomePageNavSearchLink => _driver.FindElement(By.Id("home-navigation-search-link"));
        public IWebElement HomePageNavOrgName => _driver.FindElement(By.Id("home-navigation-organisation-name"));
        public IWebElement HomePageNavUserName => _driver.FindElement(By.Id("home-navigation-user-name"));
        public IWebElement BSActiveCount => _driver.FindElement(By.Id("total-info-breathing-space-count"));
        public IWebElement HomePageCreateBSButton => _driver.FindElement(By.Id("create-button"));
        public IWebElement BSActiveBegin => _driver.FindElement(By.Id("total-info-heading-begin"));
        public IWebElement BSActiveEnd => _driver.FindElement(By.Id("total-info-heading-end"));
        public IWebElement HomePageActiveBSLink => _driver.FindElement(By.Id("active-breathing-spaces-link"));
        public IWebElement HomePageActiveTasksLink => _driver.FindElement(By.Id("tasks-to-do-caption"));
        public IWebElement HomePageReviewDebtLink => _driver.FindElement(By.Id("review-a-debt-link"));
        public IWebElement HomePageReviewClientLink => _driver.FindElement(By.Id("review-a-client-link"));
        public IWebElement HomePageProposedDebtLink => _driver.FindElement(By.Id("proposed-new-debt-link"));
        public IWebElement HomePageSoldDebtLink => _driver.FindElement(By.Id("transfer-sold-debt-link"));
        public IWebElement HomePageTransferClientLink => _driver.FindElement(By.Id("transfer-client-link"));
        public IWebElement HomePageTransferredClientsLink => _driver.FindElement(By.Id("client-has-been-transferred-link"));
        public IWebElement HomePageGuidanceLink => _driver.FindElement(By.Id("view-guidance-link"));
        public IWebElement HomePageWarningText => _driver.FindElement(By.Id("create-new-eligible-warning"));
        public IWebElement HomePageCreateNewContent => _driver.FindElement(By.Id("brething-space-create-content-box"));


        // Wait utility class to wait for element to be visible or clickable
        private WebDriverWait Wait => new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

        // Action Methods

        // Click Create Breathing Space button
        public void ClickCreateBSButton()
        {
            Thread.Sleep(5000);
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HomePageCreateBSButton)).Click();


        }
        public void ValidateOrganisationName(string expectedOrganisation)
        {
            string actualCaption = HomePageTitle.Text.Trim();
            string actualOrganisation = OrganisationName.Text.Trim();

            // Combine the header parts into a single string
            string fullHeader = $"{actualCaption} {actualOrganisation}".Trim();

            // Normalize the text to handle extra spaces or line breaks
            string normalizedHeader = System.Text.RegularExpressions.Regex.Replace(fullHeader, @"\s+", " ");
            string normalizedExpected = System.Text.RegularExpressions.Regex.Replace(expectedOrganisation, @"\s+", " ");

            // Check if the header contains the expected organisation name
            if (!normalizedHeader.Contains(normalizedExpected, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Organisation name mismatch. Expected: '{normalizedExpected}', Actual: '{normalizedHeader}'");
            }

            Console.WriteLine($"Organisation name validated successfully: '{normalizedHeader}'");
        }


        // Method to perform actions based on link name
        public bool PerformActionBasedOnLinkName(string tasks, string action)
        {
            if (!action.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine($"No action required for link: {tasks}");
                return false; // No action triggered
            }

            switch (tasks.ToLower())
            {
                case "activebslink":
                    ClickActiveBreathingSpacesLink();
                    break;

                case "reviewdebtlink":
                    ClickReviewDebtLink();
                    break;

                case "proposeddebtlink":
                    ClickProposedDebtLink();
                    break;

                case "solddebtlink":
                    ClickSoldDebtLink();
                    break;

                case "transferclientlink":
                    ClickTransferClientLink();
                    break;

                case "transferredclientslink":
                    ClickTransferredClientsLink();
                    break;

                default:
                    Console.WriteLine("Unknown link name. Clicking Create Breathing Space button by default.");
                    ClickCreateBSButton();
                    break;
            }

            return true; // Action was successfully triggered
        }

        // Get the Active Breathing Space count text
        public string GetActiveBreathingSpaceCount()
        {
            return BSActiveCount.Text;
        }

        // Navigate to Home Page Link
        public void ClickHomeLink()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HomePageNavHomeLink)).Click();
        }

        // Navigate to Search Page
        public void ClickSearchLink()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HomePageNavSearchLink)).Click();
        }

        // Get the Organization Name
        public string GetOrganizationName()
        {
            return HomePageNavOrgName.Text;
        }

        // Get the User Name
        public string GetUserName()
        {
            return HomePageNavUserName.Text;
        }

        // Navigate to Active Breathing Spaces Section
        public void ClickActiveBreathingSpacesLink()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HomePageActiveBSLink)).Click();
        }

        // Navigate to Tasks Section
        public void ClickActiveTasksLink()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HomePageActiveTasksLink)).Click();
        }

        // Navigate to "Review Debt" Section
        public void ClickReviewDebtLink()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HomePageReviewDebtLink)).Click();
        }

        // Navigate to "Review Client" Section
        public void ClickReviewClientLink()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HomePageReviewClientLink)).Click();
        }

        // Navigate to "Proposed New Debt" Section
        public void ClickProposedDebtLink()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HomePageProposedDebtLink)).Click();
        }

        // Navigate to "Sold Debt" Section
        public void ClickSoldDebtLink()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HomePageSoldDebtLink)).Click();
        }

        // Navigate to "Transfer Client" Section
        public void ClickTransferClientLink()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HomePageTransferClientLink)).Click();
        }

        // Navigate to "Transferred Clients" Section
        public void ClickTransferredClientsLink()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HomePageTransferredClientsLink)).Click();
        }

        // Navigate to "Guidance" Section
        public void ClickGuidanceLink()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(HomePageGuidanceLink)).Click();
        }

        // Get Warning Text
        public string GetWarningText()
        {
            return HomePageWarningText.Text;
        }

        // Get Create New Content text
        public string GetCreateNewContentText()
        {
            return HomePageCreateNewContent.Text;
        }

    }
}
