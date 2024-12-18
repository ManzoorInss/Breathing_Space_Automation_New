//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;


//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtRemovedViewDetailPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtRemovedViewDetailPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-header-1")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-header-2")]
//        public virtual IPageElement PageSubTitle { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-debt-type")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-creditor")]
//        public virtual IPageElement DebtCreditor { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-amount")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-reference")]
//        public virtual IPageElement DebtReference { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-entered-date")]
//        public virtual IPageElement DebtEntered { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-removed-date")]
//        public virtual IPageElement DebtRemoved { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-header-3")]
//        public virtual IPageElement ReviewReasonHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-creditor-note")]
//        public virtual IPageElement ReviewReasonValue { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-header-4")]
//        public virtual IPageElement SupportDecisionHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-ma-note")]
//        public virtual IPageElement SupportDecisionValue { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-header-5")]
//        public virtual IPageElement ReviewOnHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-removed-view-detail-date-time")]
//        public virtual IPageElement ReviewOnvalue { get; set; }

//    }
//}
