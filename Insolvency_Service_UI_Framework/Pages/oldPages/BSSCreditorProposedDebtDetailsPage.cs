//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSCreditorProposedDebtDetailsPage
//    {
//        public BSSCreditorProposedDebtDetailsPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackButton { get; set; }

//        [Find(By: By.Id, Using: "view-proposed-debt-details-heading")]
//        public virtual IPageElement DebtDetailsHeading { get; set; }

//        [Find(By: By.Id, Using: "view-proposed-debt-details-subheading")]
//        public virtual IPageElement DebtDetailsSubHeading { get; set; }

//        [Find(By: By.Id, Using: "view-proposed-debt-details-debt-label")]
//        public virtual IPageElement DebtLabel { get; set; }

//        [Find(By: By.Id, Using: "debt-details-debt-type-0")]
//        public virtual IPageElement ProposedDebtType { get; set; }

//        [Find(By: By.Id, Using: "debt-details-debt-amount-0")]
//        public virtual IPageElement ProposedDebtAmount{ get; set; }

//        [Find(By: By.Id, Using: "debt-details-debt-ref-0")]
//        public virtual IPageElement ProposedDebtReference { get; set; }

//        [Find(By: By.Id, Using: "debt-details-debt-nin-0")]
//        public virtual IPageElement ProposedDebtNino { get; set; }

//        [Find(By: By.Id, Using: "view-proposed-debt-details-requested-on-label")]
//        public virtual IPageElement RequestedOnLabel { get; set; }

//        [Find(By: By.Id, Using: "view-proposed-debt-details-requested-on")]
//        public virtual IPageElement RequestedOnDate { get; set; }
//    }
//}
