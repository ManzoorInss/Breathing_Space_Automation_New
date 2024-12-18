//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSConfirmReportingCreditorPage
//    {
//        public IDriver Driver { get; }

//        public BSSConfirmReportingCreditorPage(IDriver driver)
//        {
//            Driver = driver;
//        }

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

//        [Find(By: By.Id, Using: "report-creditor-subtitle")]
//        public virtual IPageElement DebtTypeName { get; set; }

//        [Find(By: By.Id, Using: "report-creditor-obligations")]
//        public virtual IPageElement ReportACreditor { get; set; }

//        [Find(By: By.Id, Using: "report-creditor-obligations-info")]
//        public virtual IPageElement Message { get; set; }

//        [Find(By: By.Id, Using: "report-creditor-confirmation-warning")]
//        public virtual IPageElement WarningText { get; set; }

//        [Find(By: By.Id, Using: "submit-button")]
//        public virtual IPageElement ConfirmContinueButton { get; set; }
        
//    }
//}