//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSMADebtEligibilityReviewConfirmationPage
//    {
//        public IDriver Driver { get; }

//        public BSSMADebtEligibilityReviewConfirmationPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "debt-eligibility-confirmation-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "debt-review-title")]
//        public virtual IPageElement DebtHeading { get; set; }

//        [Find(By: By.Id, Using: "debt-review-debt-type")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "debt-review-creditor")]
//        public virtual IPageElement DebtCreditor { get; set; }

//        [Find(By: By.Id, Using: "debt-review-debt-amount")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "debt-review-debt-ref")]
//        public virtual IPageElement DebtRef { get; set; }

//        [Find(By: By.Id, Using: "debt-eligibility-confirmation-reason-title")]
//        public virtual IPageElement RemovingDebtHeading { get; set; }

//        [Find(By: By.Id, Using: "debt-eligibility-confirmation-reason")]
//        public virtual IPageElement RemovingDebtValue { get; set; }

//        [Find(By: By.Id, Using: "debt-eligibility-confirmation-decision-title")]
//        public virtual IPageElement DecisionHeading { get; set; }

//        [Find(By: By.Id, Using: "debt-eligibility-confirmation-decision")]
//        public virtual IPageElement DecisionValue { get; set; }

//        [Find(By: By.CssSelector, Using: "strong#debt-eligibility-confirmation-warning")]
//        public virtual IPageElement Warning { get; set; }

//        [Find(By: By.Id, Using: "debt-eligibility-confirmation-save")]
//        public virtual IPageElement SaveButton { get; set; }
//    }
//}