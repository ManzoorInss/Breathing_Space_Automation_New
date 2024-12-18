//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSReportThisCreditorPage
//    {
//        public IDriver Driver { get; }

//        public BSSReportThisCreditorPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "report-creditor-subtitle")]
//        public virtual IPageElement DebtTypeName { get; set; }

//        [Find(By: By.Id, Using: "page-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-debt-ref")]
//        public virtual IPageElement DebtReference { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-creditor")]
//        public virtual IPageElement DebtCreditor { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-debt-amount")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-eligibility-ni")]
//        public virtual IPageElement DebtNINo { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-debt-createdon")]
//        public virtual IPageElement DebtEntered { get; set; }

//        [Find(By: By.Id, Using: "report-creditor-confirmation-warning")]
//        public virtual IPageElement WarningSign { get; set; }

//        [Find(By: By.Id, Using: "report-creditor-stop-chasing-client-bullet-point")]
//        public virtual IPageElement DisclamierInformationLine1 { get; set; }

//        [Find(By: By.Id, Using: "report-creditor-stop-any-enforcement-action-bullet-point")]
//        public virtual IPageElement DisclamierInformationLine2 { get; set; }

//        [Find(By: By.Id, Using: "report-creditor-stop-any-interest-bullet-point")]
//        public virtual IPageElement DisclamierInformationLine3 { get; set; }

//        [Find(By: By.Id, Using: "report-creditor-obligations")]
//        public virtual IPageElement CreditorObligationsLabel { get; set; }

//        [Find(By: By.Id, Using: "report-creditor-a-creditor-must-label")]
//        public virtual IPageElement CreditorMustText { get; set; }

//        [Find(By: By.Id, Using: "report-creditor-obligation-message")]
//        public virtual IPageElement CreditorNotMeetingObligation { get; set; }

//        [Find(By: By.Id, Using: "submit-button")]
//        public virtual IPageElement ConfirmContinueButton { get; set; }

//        [Find(By: By.Id, Using: "sidebar-heading")]
//        public virtual IPageElement RelatedContent { get; set; }

//        [Find(By: By.Id, Using: "remove-debt-guidance-link")]
//        public virtual IPageElement SeeGuidanceDebtEligibilityLink { get; set; }

//    }
//}
