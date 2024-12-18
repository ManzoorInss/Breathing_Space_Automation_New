//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorRemoveDebtPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorRemoveDebtPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "page-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "heading")]
//        public virtual IPageElement RemoveDebtConfirmPageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "remove-debt-subtitle")]
//        public virtual IPageElement PageSubHeading { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-creditor")]
//        public virtual IPageElement debtCreditor { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-debt-amount")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-debt-ref")]
//        public virtual IPageElement DebtReference { get; set; }

//        [Find(By: By.Id, Using: "debt-detail-debt-createdon")]
//        public virtual IPageElement DebtCreatedon { get; set; }

//        [Find(By: By.Id, Using: "reason-heading")]
//        public virtual IPageElement ReasonHeading { get; set; }

//        [Find(By: By.Id, Using: "remove-debt-submit-not-eligible-label")]
//        public virtual IPageElement NoteligibleOption { get; set; }

//        [Find(By: By.Id, Using: "remove-debt-submit-unfair-label")]
//        public virtual IPageElement UnfairOption { get; set; }

//        [Find(By: By.Id, Using: "reason-unfair-prejudices-hint")]
//        public virtual IPageElement Hintlabel { get; set; }

//        [Find(By: By.CssSelector, Using: ".govuk-label-wrapper label")]
//        public virtual IPageElement ProvidedetailsLabel { get; set; }

//        [Find(By: By.Id, Using: "MoreDetails-input")]
//        public virtual IInputTextElement ProvidedetailsInput { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IPageElement SaveAndContinue { get; set; }

//        [Find(By: By.Id, Using: "error-list")]
//        public virtual IPageElement ErrorList { get; set; }

//        [Find(By: By.Id, Using: "val-message-reason")]
//        public virtual IPageElement removingdebtError { get; set; }

//        [Find(By: By.Id, Using: "val-message-more-details")]
//        public virtual IPageElement MoreDetailsError { get; set; }

//        [Find(By: By.Id, Using: "remove-debt-reason")]
//        public virtual IPageElement ConfirmationDebtReasonlabel { get; set; }

//        [Find(By: By.Id, Using: "remove-debt-reason-text")]
//        public virtual IPageElement ConfirmationDebtReasonvalue { get; set; }

//        [Find(By: By.Id, Using: "remove-debt-reason-more-details")]
//        public virtual IPageElement ConfirmationsupportDecisionLabel { get; set; }

//        [Find(By: By.Id, Using: "remove-debt-reason-more-details-text")]
//        public virtual IPageElement ConfirmationsupportDecisionValue { get; set; }

//        [Find(By: By.Id, Using: "remove-debt-confirmation-warning")]
//        public virtual IPageElement Warningtxt { get; set; }

//        [Find(By: By.Id, Using: "submit-button")]
//        public virtual IButtonElement RemoveDebtBtn { get; set; }

//        [Find(By: By.Id, Using: "sidebar-heading")]
//        public virtual IPageElement RelatedContent { get; set; }

//        [Find(By: By.Id, Using: "remove-debt-guidance-link")]
//        public virtual IPageElement RelatedContentlink { get; set; }

//        [Find(By: By.Id, Using: "debt-not-removable-text")]
//        public virtual IPageElement CannotRemoveThisDebtHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-not-removable-reason")]
//        public virtual IPageElement CannotRemoveDebtReason { get; set; }

//    }
//}