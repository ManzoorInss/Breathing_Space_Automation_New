//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtStoppedAllActionPage
//    {
//        public IDriver Driver { get; }
//        public BSSDebtStoppedAllActionPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "banner-text")]
//        public virtual IPageElement BannerText { get; set; }

//        [Find(By: By.Id, Using: "debt-heading")]
//        public virtual IPageElement DebtHeading { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-type-0")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-amount-0")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-ref-0")]
//        public virtual IPageElement DebtRef { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-createdon-0")]
//        public virtual IPageElement DebtEntered { get; set; }

//        [Find(By: By.Id, Using: "debt-task-breathingspace-end-0")]
//        public virtual IPageElement BreathingspacEnd { get; set; }

//        [Find(By: By.Id, Using: "submit-button")]
//        public virtual IButtonElement SaveAndContinue { get; set; }
//    }
//}