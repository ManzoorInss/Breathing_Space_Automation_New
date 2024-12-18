//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtEligibilityReviewPage
//    {
//        public BSSDebtEligibilityReviewPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "page-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-type-0")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-amount-0")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-nin-0")]
//        public virtual IPageElement DebtNationInsurance { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-ref-0")]
//        public virtual IPageElement DebtRef { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-createdon-0")]
//        public virtual IPageElement DebtCreatedon { get; set; }

//        [Find(By: By.Id, Using: "debt-task-breathingspace-end-0")]
//        public virtual IPageElement DebtEndBreathingSpace { get; set; }

//        [Find(By: By.Id, Using: "reason-heading")]
//        public virtual IPageElement ReasonHeading { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "reason-not-eligible")]
//        public virtual IRadioElement ReasonnoteligibleButton { get; set; }

//        [Find(By: By.Id, Using: "review-option-failed-criteria-label")]
//        public virtual IPageElement Reasonnoteligible { get; set; }

//        [Find(By: By.Id, Using: "reason-unfair-prejudices")]
//        public virtual IRadioElement ReasonUnfairPreJudicesButton { get; set; }

//        [Find(By: By.Id, Using: "review-option-has-funds")]
//        public virtual IPageElement ReviewOptionHasFunds { get; set; }

//        [Find(By: By.CssSelector, Using: "h2.govuk-label-wrapper > label")]
//        public virtual IPageElement CreditorNotesHeading { get; set; }

//        [Find(By: By.Id, Using: "CreditorNotes-input")]
//        public virtual IInputTextElement CreditorNotes { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IButtonElement SaveButton { get; set; }

//        [Find(By: By.Id, Using: "debt-eligibility-review-related-content")]
//        public virtual IPageElement RelatedContentLink { get; set; }

//        [Find(By: By.Id, Using: "sidebar-link")]
//        public virtual IPageElement AdhocDebtEligibilityRelatedContentLink { get; set; }

//        [Find(By: By.Id, Using: "sidebar-heading")]
//        public virtual IPageElement RelatedContent { get; set; }

//        [Find(By: By.Id, Using: "reason-unfair-prejudices-hint")]
//        public virtual IPageElement Example { get; set; }

//        [Find(By: By.Id, Using: "error-list")]
//        public virtual IPageElement ErrorList { get; set; }

//        [Find(By: By.CssSelector, Using: ".govuk-error-message")]
//        public virtual IPageElement RadiobuttonError { get; set; }

//        [Find(By: By.Id, Using: "creditor-notes-error-message")]
//        public virtual IPageElement TextBoxError { get; set; }

//        [Find(By: By.Id, Using: "debt-eligibility-review-related-content")]
//        public virtual IPageElement ReviewRelatedContent { get; set; }
//    }
//}