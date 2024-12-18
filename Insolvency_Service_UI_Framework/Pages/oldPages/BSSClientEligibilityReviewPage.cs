//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSClientEligibilityReviewPage
//    {
//        public IDriver Driver { get; }
//        public BSSClientEligibilityReviewPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "legend-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "review-option-failed-criteria")]
//        public virtual IRadioElement TopOption1 { get; set; }

//        [Find(By: By.Id, Using: "review-option-failed-criteria-label")]
//        public virtual IPageElement TopOption1Label { get; set; }

//        [Find(By: By.Id, Using: "review-option-has-funds")]
//        public virtual IRadioElement TopOption2 { get; set; }

//        [Find(By: By.CssSelector, Using: "label#review-option-has-funds")]
//        public virtual IPageElement TopOption2Label { get; set; }

//        [Find(By: By.Id, Using: "sidebar-link")]
//        public virtual IPageElement SideBarLink { get; set; }

//        [Find(By: By.Id, Using: "sidebar-heading")]
//        public virtual IPageElement sidebarheading { get; set; }

//        [Find(By: By.CssSelector, Using: "h2.govuk-label-wrapper label")]
//        public virtual IPageElement Textboxheading { get; set; }

//        [Find(By: By.CssSelector, Using: "textarea#CreditorNotes-input")]
//        public virtual IInputTextElement CreditorNotes { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IButtonElement savebutton { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-related-content")]
//        public virtual IButtonElement ClientEligibilityRelatedContentLink { get; set; }

//        [Find(By: By.Id, Using: "review-option-criteria-england-wales")]
//        public virtual IRadioElement SubOption1 { get; set; }

//        [Find(By: By.Id, Using: "review-option-criteria-england-wales-label")]
//        public virtual IPageElement SubOption1Label { get; set; }

//        [Find(By: By.Id, Using: "review-option-criteria-has-dro")]
//        public virtual IRadioElement SubOption2 { get; set; }

//        [Find(By: By.Id, Using: "review-option-criteria-has-dro-label")]
//        public virtual IPageElement SubOption2Label { get; set; }

//        [Find(By: By.Id, Using: "review-option-criteria-has-iva")]
//        public virtual IRadioElement SubOption3 { get; set; }

//        [Find(By: By.CssSelector, Using: "label#review-option-criteria-has-iva")]
//        public virtual IPageElement SubOption3Label { get; set; }

//        [Find(By: By.Id, Using: "review-option-criteria-bankrupt")]
//        public virtual IRadioElement SubOption4 { get; set; }

//        [Find(By: By.CssSelector, Using: "label#review-option-criteria-bankrupt")]
//        public virtual IPageElement SubOption4Label { get; set; }

//        [Find(By: By.Id, Using: "review-option-criteria-has-had-bss")]
//        public virtual IRadioElement SubOption5 { get; set; }

//        [Find(By: By.CssSelector, Using: "label#review-option-criteria-has-had-bss")]
//        public virtual IPageElement SubOption5Label { get; set; }

//        [Find(By: By.Id, Using: "error-list")]
//        public virtual IRadioElement ErrorList { get; set; }

//        [Find(By: By.Id, Using: "creditor-notes-error-message")]
//        public virtual IPageElement TextboxError { get; set; }

//        [Find(By: By.Id, Using: "no-longer-eligible-reason-error-message")]
//        public virtual IPageElement SubOptionError { get; set; }

//        [Find(By: By.Id, Using: "end-reason-error-message")]
//        public virtual IPageElement TopOptionError { get; set; }

//    }
//}
