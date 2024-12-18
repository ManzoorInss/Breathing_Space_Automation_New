//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorTransferConfirmationPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorTransferConfirmationPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "debtor-transfer-confirmation-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement Backlink { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-client-name")]
//        public virtual IPageElement ClientName { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-reference")]
//        public virtual IPageElement ClientReference { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-started")]
//        public virtual IPageElement BSStarted { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-due-to-end")]
//        public virtual IPageElement BSDuetoEnd { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-money-advice-organisation")]
//        public virtual IPageElement MoneyAdviser { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-reason")]
//        public virtual IPageElement TransferReason { get; set; }

//        [Find(By: By.Id, Using: "continue-button")]
//        public virtual IButtonElement ConfirmSave { get; set; }
//    }
//}