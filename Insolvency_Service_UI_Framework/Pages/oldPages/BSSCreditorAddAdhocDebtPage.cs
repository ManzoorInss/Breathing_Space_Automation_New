//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSCreditorAddAdhocDebtPage
//    {
//        public BSSCreditorAddAdhocDebtPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackButton { get; set; }

//        [Find(By: By.Id, Using: "creditor-add-ad-hoc-debt-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Class, Using: "govuk-body")]
//        public virtual IPageElement CreditorName { get; set; }

//        [Find(By: By.Id, Using: "creditor-change")]
//        public virtual IPageElement ChangeLink { get; set; }

//        [Find(By: By.Id, Using: "creditor-add-ad-hoc-debt-creditor-label")]
//        public virtual IPageElement CreditorLabel { get; set; }

//        [Find(By: By.Id, Using: "DebtAmount-input")]
//        public virtual IInputTextElement DebtAmountField { get; set; }

//        [Find(By: By.Id, Using: "SelectedDebtTypeName-input")]
//        public virtual IInputTextElement DebtTypeField { get; set; }

//        [Find(By: By.Id, Using: "Reference-input")]
//        public virtual IInputTextElement DebtReferenceField { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IButtonElement SaveAndContinueButton { get; set; }

//        [Find(By: By.Id, Using: "error-summary")]
//        public virtual IButtonElement ErrorSummaryList { get; set; }

//        [Find(By: By.Id, Using: "DebtAmount-validation")]
//        public virtual IButtonElement DebtAmountValidation { get; set; }

//        [Find(By: By.Id, Using: "debt_type_1")]
//        public virtual IButtonElement CreditCardRadioButton { get; set; }
//    }
//}