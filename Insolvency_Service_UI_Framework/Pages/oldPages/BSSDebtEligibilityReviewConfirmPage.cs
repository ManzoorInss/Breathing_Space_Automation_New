//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;


//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtEligibilityReviewConfirmPage
//    {
//        public IDriver Driver { get; }
//        public BSSDebtEligibilityReviewConfirmPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "lead-line")]
//        public virtual IPageElement Pageheading { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "debt-heading")]
//        public virtual IPageElement DebtHeading { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-type-0")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-amount-0")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-ref-0")]
//        public virtual IPageElement DebtRef { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-createdon-0")]
//        public virtual IPageElement DebtCreatedOn { get; set; }

//        [Find(By: By.Id, Using: "debt-task-breathingspace-end-0")]
//        public virtual IPageElement DebtEndBreathingspace { get; set; }

//        [Find(By: By.Id, Using: "reason")]
//        public virtual IPageElement ReasonHeading { get; set; }

//        [Find(By: By.Id, Using: "reason-text")]
//        public virtual IPageElement ReasonValue { get; set; }

//        [Find(By: By.Id, Using: "detail")]
//        public virtual IPageElement DetailHeading { get; set; }

//        [Find(By: By.Id, Using: "detail-text")]
//        public virtual IPageElement DetailValue { get; set; }

//        [Find(By: By.Id, Using: "submit-button")]
//        public virtual IPageElement Confirmandsubmit { get; set; }
//    }
//}