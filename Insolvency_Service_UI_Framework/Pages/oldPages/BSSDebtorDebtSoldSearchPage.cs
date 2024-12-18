//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;


//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorDebtSoldSearchPage
//    {
//        public BSSDebtorDebtSoldSearchPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "title")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-subtitle")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-creditor")]
//        public virtual IPageElement DebtCreditor { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-debt-amount")]
//        public virtual IPageElement DebtAmount { get; set; }A

//        [Find(By: By.Id, Using: "transfer-debt-debt-ref")]
//        public virtual IPageElement DebtReference { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-entered-on")]
//        public virtual IPageElement DebtEnteredOn { get; set; }

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
//        public virtual IButtonElement SaveandContinue { get; set; }
//    }
//}