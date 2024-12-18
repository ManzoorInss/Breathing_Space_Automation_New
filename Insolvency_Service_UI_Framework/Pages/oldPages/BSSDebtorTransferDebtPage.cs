//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorTransferDebtPage
//    {
//        public BSSDebtorTransferDebtPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "transfer-debt-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-subtitle")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-creditor")]
//        public virtual IPageElement DebtCreditor { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-debt-amount")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-debt-ref")]
//        public virtual IPageElement DebtReference { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-entered-on")]
//        public virtual IPageElement DebtEnteredOn { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-message")]
//        public virtual IPageElement SoldBodyMsg { get; set; }

//        [Find(By: By.Id, Using: "transfer-debt-transfer-this-debt-to-the-new-creditor")]
//        public virtual IPageElement TransferdebtButton { get; set; }
//    }
//}