//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;


//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorTransferReviewConfirmationStatementPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorTransferReviewConfirmationStatementPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "debtor-transfer-review-confirmation-heading")]
//        public virtual IPageElement Confirmation { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-review-confirmation-body")]
//        public virtual IPageElement ConfirmationMsg { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-review-confirmation-next-step")]
//        public virtual IPageElement NextStep { get; set; }

//        [Find(By: By.Id, Using: "debtor-transfer-review-confirmation-index")]
//        public virtual IPageElement ReturnHome { get; set; }
//    }
//}