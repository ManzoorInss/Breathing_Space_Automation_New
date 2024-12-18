//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtSoldSearchPage
//    {
//        public BSSDebtSoldSearchPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "CreditorName-label")]
//        public virtual IPageElement EnterNameLabel { get; set; }

//        [Find(By: By.Id, Using: "CreditorName-hint")]
//        public virtual IPageElement Example { get; set; }

//        [Find(By: By.Id, Using: "CreditorName-validation")]
//        public virtual IPageElement CreditorError { get; set; }

//        [Find(By: By.Id, Using: "autocomplete-result-0")]
//        public virtual IPageElement CmpSelection { get; set; }

//        [Find(By: By.Id, Using: "CreditorName-input")]
//        public virtual IInputTextElement EnterNameTxt { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IPageElement SaveandContinue { get; set; }

//        [Find(By: By.Id, Using: "debt-heading")]
//        public virtual IPageElement CreditorAddressHeader { get; set; }

//        [Find(By: By.Id, Using: "detail-text")]
//        public virtual IPageElement CreditorAddressText { get; set; }

//        [Find(By: By.Id, Using: "error-summary")]
//        public virtual IPageElement ErrorSummaryList { get; set; }

//        [Find(By: By.Id, Using: "CreditorName-validation")]
//        public virtual IPageElement CreditorFieldErrorMessage { get; set; }
//    }
//}