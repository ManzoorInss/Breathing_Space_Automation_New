//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorEligibilityReviewConfirmationPage
//    {
//        public IDriver Driver { get; }
//        public BSSDebtorEligibilityReviewConfirmationPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Class, Using: "govuk-heading-l")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-confirmation-end-breathing-space-header")]
//        public virtual IPageElement PageHeading { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-confirmation-details-to-support-decision-label")]
//        public virtual IPageElement SupporttheDecisionHeading { get; set; }

//        [Find(By: By.XPath, Using: "//*[@id=\"client-eligibility-review-confirmation-details-to-support-decision-label\"]/..")]
//        public virtual IPageElement SupporttheDecisionValue { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-confirmation-reviewed-on-label")]
//        public virtual IPageElement ReviewedbyHeading { get; set; }

//        [Find(By: By.XPath, Using: "//*[@id='client-eligibility-review-confirmation-reviewed-on-label']/..")]
//        public virtual IPageElement ReviewedbyValue { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-confirmation-not-eligible-label")]
//        public virtual IPageElement WhyNotEligibleHeading { get; set; }

//        [Find(By: By.XPath, Using: "//*[@id=\"client-eligibility-review-confirmation-not-eligible-label\"]/..")]
//        public virtual IPageElement WhyNotEligibleValue { get; set; }

//        [Find(By: By.CssSelector, Using: "p:nth-child(4) label")]
//        public virtual IPageElement EndSupporttheDecisionHeading { get; set; }

//        [Find(By: By.CssSelector, Using: "p:nth-child(4)")]
//        public virtual IPageElement EndSupporttheDecisionValue { get; set; }

//        [Find(By: By.CssSelector, Using: "p:nth-child(5) label")]
//        public virtual IPageElement EndReviewedbyHeading { get; set; }

//        [Find(By: By.CssSelector, Using: "p:nth-child(5)")]
//        public virtual IPageElement EndReviewedbyValue { get; set; }

//        [Find(By: By.CssSelector, Using: "div.govuk-warning-text strong")]
//        public virtual IPageElement WorningMsg { get; set; }

//        [Find(By: By.Id, Using: "confirm-button")]
//        public virtual IButtonElement ConfirmAndContinue { get; set; }
//    }
//}