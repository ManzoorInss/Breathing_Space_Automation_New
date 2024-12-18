//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtSoldPage
//    {
//        public BSSDebtSoldPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "debt-heading")]
//        public virtual IPageElement SubHeading { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-type-0")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-amount-0")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-ref-0")]
//        public virtual IPageElement DebtReference { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-nin-0")]
//        public virtual IPageElement DebtNI { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-createdon-0")]
//        public virtual IPageElement DebtEnteredOn { get; set; }

//        [Find(By: By.Id, Using: "debt-task-breathingspace-end-0")]
//        public virtual IPageElement BreathingSpaceEnd { get; set; }

//        [Find(By: By.Id, Using: "debt-sold-to-body")]
//        public virtual IPageElement SoldBodyMsg { get; set; }

//        [Find(By: By.Id, Using: "creditor-org")]
//        public virtual IPageElement CreditorName { get; set; }

//        [Find(By: By.Id, Using: "ma-org")]
//        public virtual IPageElement MAName { get; set; }

//        [Find(By: By.Id, Using: "submit-button")]
//        public virtual IButtonElement Confirmandsubmit { get; set; }
//    }
//}