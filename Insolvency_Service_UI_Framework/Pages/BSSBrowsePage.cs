using OpenQA.Selenium;
using System.Collections.Generic;

namespace BSSTestAutomation.Pages
{
    public class BSSBrowsePage
    {
        private IWebDriver _driver;

        public BSSBrowsePage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page elements 

        // Filter By Label
        public IWebElement FilterByLabel => _driver.FindElement(By.CssSelector(".govuk-fieldset h2.govuk-heading-m"));

        // Page Heading
        public IWebElement PageHeading => _driver.FindElement(By.CssSelector(".govuk-heading-l"));

        // Radio Button for Active Breathing Spaces
        public IWebElement ActiveBSRadioButton => _driver.FindElement(By.Id("browse-by-category-active-breathing-spaces"));

        // Label for Active Breathing Spaces Radio Button
        public IWebElement ActiveBSRadioButtonLabel => _driver.FindElement(By.CssSelector("#browse-by-category-active-breathing-spaces + label"));

        // Radio Button for Task To Do
        public IWebElement TaskToDoRadioButton => _driver.FindElement(By.Id("browse-by-category-tasks-to-do"));

        // Label for Task To Do Radio Button
        public IWebElement TaskToDoRadioButtonLabel => _driver.FindElement(By.CssSelector("#browse-by-category-tasks-to-do + label"));

        // Debt Reviewed Radio Button Label
        public IWebElement DebtReviewedRadioButtonLabel => _driver.FindElement(By.CssSelector("#browse-by-task-tasks-debts-to-be-reviewed + label"));

        // Client Reviewed Button Label
        public IWebElement ClientReviewedButtonLabel => _driver.FindElement(By.CssSelector("#browse-by-task-tasks-clients-to-be-reviewed + label"));

        // Proposed Debt Radio Button Label
        public IWebElement ProposedDebtRadioButtonLabel => _driver.FindElement(By.CssSelector("#browse-by-task-tasks-new-debts-proposed + label"));

        // Sold Debt Radio Button Label
        public IWebElement SoldDebtRadioButtonLabel => _driver.FindElement(By.CssSelector("#browse-by-task-tasks-debts-to-be-transferred + label"));

        // Transfer MA Radio Button Label
        public IWebElement TransferMARadioButtonLabel => _driver.FindElement(By.CssSelector("#browse-by-task-tasks-clients-transferred-to-money-adviser + label"));

        // Transferred Client Radio Button Label
        public IWebElement TransferredClientRadioButtonLabel => _driver.FindElement(By.CssSelector("#browse-by-task-tasks-clients-to-be-transferred + label"));

        // Sent To MA Radio Button Label
        public IWebElement SentToMARadioButtonLabel => _driver.FindElement(By.CssSelector("#browse-by-category-sent-to-money-adviser + label"));

        // Showing Label
        public IWebElement ShowingLabel => _driver.FindElement(By.CssSelector("#content-list > h2"));

        // List of Results (multiple elements)
        public IReadOnlyCollection<IWebElement> ListofResults => _driver.FindElements(By.CssSelector("#content-list > ul > li"));

        // Sort Dropdown
        public IWebElement SortDropdown => _driver.FindElement(By.Id("sort"));

        // Sort Button
        public IWebElement SortButton => _driver.FindElement(By.Id("sort-button"));
    }
}
