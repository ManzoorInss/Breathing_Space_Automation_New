//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorTransferDebtConfirmationPage
//    {

//        public BSSDebtorTransferDebtConfirmationPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "transfer-debt-confirmation-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-confirmation-subtitle")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-confirmation-creditor")]
//        public virtual IPageElement DebtCreditor { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-confirmation-old-creditor")]
//        public virtual IPageElement DebtOldCreditor { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-confirmation-debt-amount")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-confirmation-debt-ref")]
//        public virtual IPageElement DebtReference { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-confirmation-entered-on")]
//        public virtual IPageElement DebtEnteredOn { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-confirmation-confirm-and-continue")]
//        public virtual IButtonElement TransferdebtButton { get; set; }
//    }
//}