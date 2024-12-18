//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorTransferPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorTransferPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "debtor-transfer-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement Backlink { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-client-name")]
//        public virtual IPageElement DebtorName { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-reference")]
//        public virtual IPageElement ReferenceNo { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-started")]
//        public virtual IPageElement BSStarted { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-due-to-end")]
//        public virtual IPageElement BSdueToEnd { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-money-advice-organisation")]
//        public virtual IPageElement MoneyAdviserName { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-reason")]
//        public virtual IInputTextElement TransferReason { get; set; }

//        [Find(By: By.Id, Using: "continue-button")]
//        public virtual IButtonElement ConfirmButton { get; set; }
//    }
//}