//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtEligibilityReviewTaskConfirmationPage
//    {
//        public BSSDebtEligibilityReviewTaskConfirmationPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "lead-line")]
//        public virtual IPageElement SubHeading { get; set; }

//        [Find(By: By.Id, Using: "debt-review-title")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-creditor")]
//        public virtual IPageElement DebtCreditor { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-debt-ref")]
//        public virtual IPageElement DebtReference { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-debt-amount")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-debt-createdon")]
//        public virtual IPageElement DebtEnteredOn { get; set; }

//        [Find(By: By.Id, Using: "reason")]
//        public virtual IPageElement ReasonHeading { get; set; }

//        [Find(By: By.Id, Using: "reason-text")]
//        public virtual IPageElement ReasonText { get; set; }

//        [Find(By: By.Id, Using: "detail")]
//        public virtual IPageElement DetailHeading { get; set; }

//        [Find(By: By.Id, Using: "detail-text")]
//        public virtual IPageElement DetailText { get; set; }

//        [Find(By: By.Id, Using: "submit-button")]
//        public virtual IPageElement Confirmandcontinue { get; set; }
//    }
//}