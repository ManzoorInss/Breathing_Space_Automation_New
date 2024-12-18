//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSCreditorDebtEligibilityReviewViewDetails
//    {
//        public BSSCreditorDebtEligibilityReviewViewDetails(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual ILinkElement BackButton { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-first-header")]
//        public virtual IPageElement FirstHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-second-header")]
//        public virtual IPageElement SecondHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-third-header")]
//        public virtual IPageElement ThirdHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-outcome-status")]
//        public virtual IPageElement OutcomeStatus { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-fourth-header")]
//        public virtual IPageElement FourthHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-fifth-header")]
//        public virtual IPageElement FifthHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-supporting-comment")]
//        public virtual IPageElement SupportingComment { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-reviewed-on-date-time")]
//        public virtual IPageElement ReviewedDateTime { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-sixth-header")]
//        public virtual IPageElement SixthHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-debt-header")]
//        public virtual IPageElement DebtHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-type-0")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-amount-0")]
//        public virtual IPageElement Amount { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-ref-0")]
//        public virtual IPageElement Reference { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-createdon-0")]
//        public virtual IPageElement CreatedOn { get; set; }

//        [Find(By: By.Id, Using: "debt-task-breathingspace-end-0")]
//        public virtual IPageElement EndsOn { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-seventh-header")]
//        public virtual IPageElement SeventhHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-creditor-reason")]
//        public virtual IPageElement Reason { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-creditor-supporting")]
//        public virtual IPageElement EighthHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-creditor-notes")]
//        public virtual IPageElement Notes { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-eighth-header")]
//        public virtual IPageElement NinthHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-requested-on-date-time")]
//        public virtual IPageElement DateTime { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-related-title")]
//        public virtual IPageElement RelatedContentTitle { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-related-content")]
//        public virtual IButtonElement RelatedContent { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-remove-from-to-do-list-heading")]
//        public virtual IPageElement RemoveFromToDoListHeading { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-remove-from-to-do-list-instructions")]
//        public virtual IPageElement RemoveFromToDoListInstructions { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-submit-complete-review-yes-label")]
//        public virtual IPageElement YesLabel { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-submit-complete-review-no-label")]
//        public virtual IPageElement NoLabel { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-submit-complete-review-yes")]
//        public virtual IRadioElement YesRadioButton { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-details-submit-complete-review-no")]
//        public virtual IRadioElement NoRadioButton { get; set; }

//        [Find(By: By.Id, Using: "save-and-continue-button")]
//        public virtual IButtonElement SaveAndContinueButton { get; set; }
//    }
//}