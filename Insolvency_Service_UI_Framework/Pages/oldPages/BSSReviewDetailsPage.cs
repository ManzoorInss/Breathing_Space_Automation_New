//using System;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSReviewDetailsPage
//    {
//        private readonly IWebDriver _driver;

//        public BSSReviewDetailsPage(IWebDriver driver)
//        {
//            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
//        }

//        // Page Elements (using Selenium's By locators)

//        // Back Button
//        public IWebElement BackButton => _driver.FindElement(By.Id("back-link"));

//        // Page Title
//        public IWebElement PageTitle => _driver.FindElement(By.Id("debt-review-view-details-first-header"));

//        // Page Heading
//        public IWebElement PageHeading => _driver.FindElement(By.Id("debt-review-view-details-sixth-header"));

//        // Debt Label
//        public IWebElement DebtLabel => _driver.FindElement(By.Id("debt-review-view-details-debt-header"));

//        // Debt Type
//        public IWebElement DebtType => _driver.FindElement(By.Id("debt-task-debt-type-0"));

//        // Debt Amount
//        public IWebElement DebtAmount => _driver.FindElement(By.Id("debt-task-debt-amount-0"));

//        // Debt Reference
//        public IWebElement DebtReference => _driver.FindElement(By.Id("debt-task-debt-ref-0"));

//        // Debt National Insurance Number
//        public IWebElement DebtNI => _driver.FindElement(By.Id("debt-task-debt-nin-0"));

//        // Debt Entered On Date
//        public IWebElement DebtEnteredOn => _driver.FindElement(By.Id("debt-task-debt-createdon-0"));

//        // Breathing Space End Date
//        public IWebElement BreathingSpaceEnd => _driver.FindElement(By.Id("debt-task-breathingspace-end-0"));

//        // Reason for Review Heading
//        public IWebElement ReasonForReview => _driver.FindElement(By.Id("debt-review-view-details-seventh-header"));

//        // Reason for Review Text
//        public IWebElement ReasonForReviewText => _driver.FindElement(By.Id("debt-review-view-details-creditor-reason"));

//        // Details Supporting Review Heading
//        public IWebElement DetailsSupportToReview => _driver.FindElement(By.Id("debt-review-view-details-creditor-supporting"));

//        // Details Supporting Review Text
//        public IWebElement DetailsSupportToReviewText => _driver.FindElement(By.Id("debt-review-view-details-creditor-notes"));

//        // Related Content Title
//        public IWebElement RelatedContent => _driver.FindElement(By.Id("debt-review-view-details-related-title"));

//        // Related Content Link (Debt Eligibility Guidance)
//        public IWebElement DebtEligibilityGuidanceLink => _driver.FindElement(By.Id("debt-review-view-details-related-content"));

//        /// <summary>
//        /// Clicks the Back button.
//        /// </summary>
//        public void ClickBack()
//        {
//            BackButton.Click();
//        }
//    }
//}