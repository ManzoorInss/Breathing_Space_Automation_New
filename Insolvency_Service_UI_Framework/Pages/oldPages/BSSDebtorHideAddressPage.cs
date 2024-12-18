//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorHideAddressPage
//    {
//        public IDriver Driver { get; }

//        [Find(By: By.Class, Using:"govuk-heading-xl")]
//        public virtual IPageElement PageTitle { get; set; }//

//        [Find(By: By.Class, Using: "govuk-warning-text__text")]
//        public virtual IPageElement PageWarning { get; set; }//

//        [Find(By: By.Class, Using: "govuk-fieldset__heading")]
//        public virtual IPageElement PageAgreement { get; set; }//

//        [Find(By: By.Class, Using: "govuk-radios")]
//        public virtual IPageElement PageRadioButtons { get; set; }//

//        [Find(By: By.Id, Using:"submit-yes")]
//        public virtual IRadioElement WithholdYesRadioButton { get; set; }//

//        [Find(By: By.Id, Using: "submit-no")]
//        public virtual IRadioElement WithholdNoRadioButton { get; set; }//

//        [Find(By: By.Id, Using: "parv-hint")]
//        public virtual IPageElement SumbmitHint { get; set; }//

//        [Find(By: By.Id, Using: "debtor-hide-add-save")]
//        public virtual IPageElement SaveButton { get; set; }//

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }//

//        [Find(By: By.Id, Using: "error-summary")]
//        public virtual IPageElement ErrorSummary { get; set; }//

//        [Find(By: By.Class, Using: "govuk-error-message")]
//        public virtual IPageElement FieldError { get; set; }//

//        [Find(By: By.CssSelector, Using: "input#submit-yes")]
//        public virtual IButtonElement RadioButtonYes { get; set; }//

//        [Find(By: By.Id, Using: "submit-no")]
//        public virtual IButtonElement RadioButtonNo { get; set; }//

//        public BSSDebtorHideAddressPage(IDriver driver)
//        {
//            Driver = driver;
//        }
//    }
//}
