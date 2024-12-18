//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorEligibilityReviewPage
//    {
//        public IDriver Driver { get; }
//        public BSSDebtorEligibilityReviewPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "client-eligibility-review-header")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-subheader")]
//        public virtual IPageElement CreditorNameHeading { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }
        
//        [Find(By: By.Id, Using: "client-eligibility-review-not-eligible-label")]
//        public virtual IPageElement WhyNotEligibleHeading { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-reason")]
//        public virtual IPageElement WhyNotEligibleValue { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-details-to-support-review")]
//        public virtual IPageElement SupportReviewHeading { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-creditor-notes")]
//        public virtual IPageElement SupportReviewValue { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-requeste-on-label")]
//        public virtual IPageElement RequestedbyHeading { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-requested-on")]
//        public virtual IPageElement RequestedbyValue { get; set; }

//        [Find(By: By.Class, Using: "govuk-fieldset__heading")]
//        public virtual IPageElement EndClientBreathingSpaceHeading { get; set; }

//        [Find(By: By.Id, Using: "submit-end-breathing-space-yes")]
//        public virtual IPageElement RadioButtonYes { get; set; }

//        [Find(By: By.Id, Using: "submit-end-breathing-space-no")]
//        public virtual IPageElement RadioButtonNo { get; set; }

//        [Find(By: By.CssSelector, Using: ".govuk-label-wrapper label")]
//        public virtual IPageElement detailsSupportReviewHeading { get; set; }

//        [Find(By: By.Id, Using: "MoneyAdviserNotes-input")]
//        public virtual IInputTextElement detailsSupportReviewTextBox { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IPageElement SaveAndContinue { get; set; }

//        [Find(By: By.Id, Using: "sidebar-heading")]
//        public virtual IPageElement RelatedContent { get; set; }

//        [Find(By: By.Id, Using: "sidebar-link")]
//        public virtual IPageElement RelatedContentLink { get; set; }

//        [Find(By: By.Id, Using: "error-list")]
//        public virtual IPageElement ErrorList { get; set; }

//        [Find(By: By.Id, Using: "errors")]
//        public virtual IPageElement EndBreathingSpaceOptionError { get; set; }

//        [Find(By: By.Id, Using: "review-details-error")]
//        public virtual IPageElement detailsSupportReviewTextBoxError { get; set; }
//    }
//}