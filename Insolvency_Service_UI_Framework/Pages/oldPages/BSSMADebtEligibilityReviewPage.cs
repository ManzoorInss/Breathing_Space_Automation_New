//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSMADebtEligibilityReviewPage
//    {
//        public IDriver Driver { get; }

//        public BSSMADebtEligibilityReviewPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-eligibility-creditor-req")]
//        public virtual IPageElement CreditorHeading { get; set; }

//        [Find(By: By.Id, Using: "debt-review-title")]
//        public virtual IPageElement DebtTitle { get; set; }

//        [Find(By: By.Id, Using: "debt-review-debt-type")]
//        public virtual IPageElement debttype { get; set; }

//        [Find(By: By.Id, Using: "debt-review-creditor")]
//        public virtual IPageElement Debtcreditor { get; set; }

//        [Find(By: By.Id, Using: "debt-review-debt-amount")]
//        public virtual IPageElement Debtamount { get; set; }

//        [Find(By: By.Id, Using: "debt-review-debt-ref")]
//        public virtual IPageElement Debtref { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-reason-title")]
//        public virtual IPageElement ReasontitleHeading { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-review-reason")]
//        public virtual IPageElement ReviewreasonText { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-review-support-title")]
//        public virtual IPageElement SupporttitleHeading { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-review-support-reason")]
//        public virtual IPageElement SupportreasonText { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-requested-on-title")]
//        public virtual IPageElement RequestedbyHeading { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-requested-on")]
//        public virtual IPageElement RequestedbyText { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-remove-confirmation")]
//        public virtual IPageElement RemoveconfirmationHeading{ get; set; }

//        [Find(By: By.Id, Using: "debt-eligibility-submit-yes")]
//        public virtual IRadioElement Yes { get; set; }

//        [Find(By: By.Id, Using: "debt-eligibility-submit-no")]
//        public virtual IRadioElement No { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-removal-support-title")]
//        public virtual IPageElement RemovalsupporttitleHeading { get; set; }

//        [Find(By: By.Id, Using: "ReviewSupportingDetail-input")]
//        public virtual IInputTextElement ReviewSupportingDetail { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-review-save")]
//        public virtual IButtonElement SaveButton { get; set; }

//        [Find(By: By.Id, Using: "error-list")]
//        public virtual IPageElement ErrorList { get; set; }

//        [Find(By: By.Id, Using: "errors")]
//        public virtual IPageElement DebteligibilitysubmitError { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-review-supporting-detail-error-message")]
//        public virtual IPageElement TextboxError { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-related-title")]
//        public virtual IPageElement RelatedContent { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-eligibility-related-content")]
//        public virtual IPageElement RelatedContentLink { get; set; }

//        [Find(By: By.Id, Using: "debt-not-removable-text")]
//        public virtual IPageElement CannotRemoveThisDebtHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-not-removable-reason")]
//        public virtual IPageElement CannotRemoveDebtReason { get; set; }
//    }
//}