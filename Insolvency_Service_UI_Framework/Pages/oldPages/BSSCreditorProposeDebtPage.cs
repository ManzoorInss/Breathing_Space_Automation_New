//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSCreditorProposeDebtPage
//    {
//        public BSSCreditorProposeDebtPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackButton { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-heading")]
//        public virtual IPageElement ProposeDebtTitle { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-type-label")]
//        public virtual IPageElement ProposeDebtLabel { get; set; }

//        [Find(By: By.Id, Using: "debt_type_1")]
//        public virtual IPageElement RadioButtonOne { get; set; }

//        [Find(By: By.Id, Using: "debt_type_2")]
//        public virtual IPageElement RadioButtonTwo { get; set; }

//        [Find(By: By.Id, Using: "debt_type_3")]
//        public virtual IPageElement RadioButtonThree { get; set; }

//        [Find(By: By.Id, Using: "debt_type_4")]
//        public virtual IPageElement RadioButtonFour { get; set; }

//        [Find(By: By.Id, Using: "debt_type_5")]
//        public virtual IPageElement RadioButtonFive { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-type-name")]
//        public virtual IPageElement DebtTypeLabel { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-type-name-(0)")]
//        public virtual IPageElement RadioButtonOneLabel { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-type-name-(1)")]
//        public virtual IPageElement RadioButtonTwoLabel { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-type-name-(2)")]
//        public virtual IPageElement RadioButtonThreeLabel { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-type-name-(3)")]
//        public virtual IPageElement RadioButtonFourLabel { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-type-name-(4)")]
//        public virtual IPageElement RadioButtonFiveLabel { get; set; }

//        [Find(By: By.Id, Using: "DebtAmount-label")]
//        public virtual IPageElement AmountFieldLabel { get; set; }

//        [Find(By: By.Id, Using: "NINO-label")]
//        public virtual IPageElement NINOLabel { get; set; }

//        [Find(By: By.Id, Using: "NINO-hint")]
//        public virtual IPageElement NINOHint { get; set; }

//        [Find(By: By.Id, Using: "NINO-input")]
//        public virtual IInputTextElement NINOInput { get; set; }

//        [Find(By: By.Id, Using: "error-list-item-NINO-input-2")]
//        public virtual IPageElement NINOHeaderError { get; set; }

//        [Find(By: By.Id, Using: "NINO-validation")]
//        public virtual IPageElement NINOFieldError { get; set; }

//        [Find(By: By.Id, Using: "DebtAmount-input")]
//        public virtual IInputTextElement DebtAmountField { get; set; }

//        [Find(By: By.Id, Using: "Reference-label")]
//        public virtual IPageElement ReferenceFieldLabel { get; set; }

//        [Find(By: By.Id, Using: "Reference-input")]
//        public virtual IInputTextElement ReferenceInputField { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IPageElement SaveAndContinueButton { get; set; }

//        [Find(By: By.Id, Using: "error-list-item-DebtAmount-input-1")]
//        public virtual IPageElement HeaderValidationMessage { get; set; }

//        [Find(By: By.Id, Using: "DebtAmount-validation")]
//        public virtual IPageElement FieldValidationMessage { get; set; }

//    }
//}
