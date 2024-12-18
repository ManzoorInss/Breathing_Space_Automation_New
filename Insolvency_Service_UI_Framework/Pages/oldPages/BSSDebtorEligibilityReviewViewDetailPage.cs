//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorEligibilityReviewViewDetailPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorEligibilityReviewViewDetailPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-header-1")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-header-2")]
//        public virtual IPageElement PageSubTitle { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-header-3")]
//        public virtual IPageElement OutcomeHeader { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-outcome")]
//        public virtual IPageElement OutcomeValue { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-header-4")]
//        public virtual IPageElement SupportDecisionHeader { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-ma-supporting-detail")]
//        public virtual IPageElement SupportDecisionValue { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-header-5")]
//        public virtual IPageElement ReviewOnHeader { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-ma-date-time")]
//        public virtual IPageElement ReviewOnvalue{ get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-header-6")]
//        public virtual IPageElement PageSubHeader { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-header-7")]
//        public virtual IPageElement WhyNotEligibleHeader { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-reason")]
//        public virtual IPageElement WhyNotEligibleValue { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-header-8")]
//        public virtual IPageElement SupportRviewHeader { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-creditor-notes")]
//        public virtual IPageElement CreditorNotes { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-header-9")]
//        public virtual IPageElement RequestedOn { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-view-detail-creditor-date-time")]
//        public virtual IPageElement RequestedOnVal { get; set; }
//    }
//}
