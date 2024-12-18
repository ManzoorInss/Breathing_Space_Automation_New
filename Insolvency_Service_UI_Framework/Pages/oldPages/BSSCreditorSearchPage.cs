//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSCreditorSearchPage
//    {
//        public BSSCreditorSearchPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "CreditorName-input")]
//        public virtual IInputTextElement AddCreditorField { get; set; }

//        [Find(By: By.Id, Using: "autocomplete-result-0")]
//        public virtual IPageElement CmpSelection { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IPageElement SaveAndContinueButton { get; set; }

//        [Find(By: By.Class, Using: "govuk-fieldset__heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "creditor-search-instructions")]
//        public virtual IPageElement UserInstructionText { get; set; }

//        [Find(By: By.Id, Using: "CreditorName-label")]
//        public virtual IPageElement CreditorNameLabel { get; set; }

//        [Find(By: By.Id, Using: "CreditorName-hint")]
//        public virtual IPageElement CreditorNameHint { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "CreditorName-validation")]
//        public virtual IPageElement FieldErrorMessage { get; set; }

//        [Find(By: By.Id, Using: "error-list")]
//        public virtual IPageElement HeaderErrorMessage { get; set; }
//    }
//}