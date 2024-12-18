//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorTransferAcknowledgePage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorTransferAcknowledgePage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "debtor-transfer-confirm-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement Backlink { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-confirm-description")]
//        public virtual IPageElement PageSubHeading { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-client-name")]
//        public virtual IPageElement ClientName { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-reference")]
//        public virtual IPageElement ClientReference { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-started")]
//        public virtual IPageElement BSStarted { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-details-due-to-end")]
//        public virtual IPageElement BSDuetoEnd { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-requested-by")]
//        public virtual IPageElement RequestedBy { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-reason")]
//        public virtual IPageElement TransferReason { get; set; }

//        [Find(By: By.Id, Using: "submit-complete-transfer-yes")]
//        public virtual IRadioElement TransferYes { get; set; }

//        [Find(By: By.Id, Using: "submit-complete-transfer-no")]
//        public virtual IRadioElement TransferNo { get; set; }

//        [Find(By: By.Id, Using: "submit-transfer-button")]
//        public virtual IButtonElement SubmitButton { get; set; }
//    }
//}