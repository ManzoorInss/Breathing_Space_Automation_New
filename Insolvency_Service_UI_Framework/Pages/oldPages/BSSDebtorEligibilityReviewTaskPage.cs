//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorEligibilityReviewTaskPage
//    {
//        public IDriver Driver { get; }
//        public BSSDebtorEligibilityReviewTaskPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "heading-title")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "heading-creditor-name")]
//        public virtual IPageElement CreditorNameHeading { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "sidebar-heading")]
//        public virtual IPageElement RelatedContentHeading { get; set; }

//        [Find(By: By.Id, Using: "sidebar-link")]
//        public virtual IPageElement RelatedContentLink { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-eligibility-not-eligible-text")]
//        public virtual IPageElement DebtoreligibilityText { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-eligibility-provide-details-text")]
//        public virtual IPageElement DebtoreligibilitydetailstextLabel { get; set; }

//        [Find(By: By.Id, Using: "review-option-failed-criteria-label")]
//        public virtual IPageElement Option1 { get; set; }

//        [Find(By: By.Id, Using: "review-option-has-funds")]
//        public virtual IPageElement Option2 { get; set; }

//        [Find(By: By.Id, Using: "review-option-criteria-england-wales-label")]
//        public virtual IPageElement SubOption1 { get; set; }

//        [Find(By: By.Id, Using: "review-option-criteria-has-dro-label")]
//        public virtual IPageElement SubOption2 { get; set; }

//        [Find(By: By.Id, Using: "review-option-criteria-has-iva")]
//        public virtual IPageElement SubOption3 { get; set; }

//        [Find(By: By.Id, Using: "review-option-criteria-bankrupt")]
//        public virtual IPageElement SubOption4 { get; set; }

//        [Find(By: By.Id, Using: "review-option-criteria-has-had-bss")]
//        public virtual IPageElement SubOption5 { get; set; }

//        [Find(By: By.Id, Using: "CreditorNotes-input")]
//        public virtual IInputTextElement CreditorNotes { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IButtonElement SaveandContinue { get; set; }        
            
//    }
//}