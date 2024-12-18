//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSCreditorClientEligibilityReviewViewDetailsPage
//    {

//        public IDriver Driver { get; }

//        public BSSCreditorClientEligibilityReviewViewDetailsPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-header-1")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-header-2")]
//        public virtual IPageElement PageSubTitle { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-header-3")]
//        public virtual IPageElement OutcomeHeader { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-outcome")]
//        public virtual IPageElement OutcomeValue { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-header-4")]
//        public virtual IPageElement DecisionHeader { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-ma-supporting-detail")]
//        public virtual IPageElement DecisionValue { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-header-5")]
//        public virtual IPageElement ReviewedOnHeader { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-ma-date-time")]
//        public virtual IPageElement ReviewedOnValue { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-header-6")]
//        public virtual IPageElement ReviewedRquestHeader { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-header-7")]
//        public virtual IPageElement ReasonNotEligibleHeader { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-reason")]
//        public virtual IPageElement ReasonNotEligibleValue { get; set; }
        
//        [Find(By: By.Id, Using: "client-eligibility-view-details-header-8")]
//        public virtual IPageElement SupportReviewHeader { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-creditor-notes")]
//        public virtual IPageElement SupportReviewValue { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-creditor-notes")]
//        public virtual IPageElement RequestedOnValue { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-related-title")]
//        public virtual IPageElement RelatedContentHeader { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-related-content")]
//        public virtual IPageElement RelatedContentValue { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-remove-from-to-do-list-heading")]
//        public virtual IPageElement RemovefromToDoQuestion { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-remove-from-to-do-list-instructions")]
//        public virtual IPageElement GovHint { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-submit-complete-review-yes-label")]
//        public virtual IPageElement YesRemove { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-view-details-submit-complete-review-no-label")]
//        public virtual IPageElement NoDontRemove { get; set; }

//        [Find(By: By.Id, Using: "save-and-continue-button")]
//        public virtual IButtonElement SaveAndContinue { get; set; }

//        [Find(By: By.Id, Using: "error-list-item-client-eligibility-view-details-submit-complete-review-yes-1")]
//        public virtual IPageElement ErrorList { get; set; }

//        [Find(By: By.Id, Using: "errors")]
//        public virtual IPageElement ErrorOption { get; set; }
//    }
//}
