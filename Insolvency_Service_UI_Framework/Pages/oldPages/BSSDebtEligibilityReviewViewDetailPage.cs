//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtEligibilityReviewViewDetailPage
//    {
//        public BSSDebtEligibilityReviewViewDetailPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-first-header")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-second-header")]
//        public virtual IPageElement ReviewedCompleted { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-third-header")]
//        public virtual IPageElement OutcomeHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-outcome-status")]
//        public virtual IPageElement OutcomeValue { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-fourth-header")]
//        public virtual IPageElement SupportDecisionHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-supporting-comment")]
//        public virtual IPageElement SupportDecisionValue { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-fifth-header")]
//        public virtual IPageElement ReviewedOnHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-ma-date-time")]
//        public virtual IPageElement ReviewedOnValue { get; set; }


//        [Find(By: By.Id, Using: "debt-review-view-detail-sixth-header")]
//        public virtual IPageElement PageSubHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-review-title")]
//        public virtual IPageElement DebtTitle { get; set; }

//        [Find(By: By.Id, Using: "debt-review-debt-type")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "debt-review-creditor")]
//        public virtual IPageElement DebtCreditor { get; set; }

//        [Find(By: By.Id, Using: "debt-review-debt-amount")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "debt-review-debt-ref")]
//        public virtual IPageElement DebtReference { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-seventh-header")]
//        public virtual IPageElement ReviewReason { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-creditor-reason")]
//        public virtual IPageElement CreditorReason { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-creditor-supporting")]
//        public virtual IPageElement CreditorSupporting { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-creditor-notes")]
//        public virtual IPageElement CreditorNotes { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-eighth-header")]
//        public virtual IPageElement RequestedOn { get; set; }

//        [Find(By: By.Id, Using: "debt-review-view-detail-creditor-date-time")]
//        public virtual IPageElement RequestedOnValue { get; set; }

//    }
//}
