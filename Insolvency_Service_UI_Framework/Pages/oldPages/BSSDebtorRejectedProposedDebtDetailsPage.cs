//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;


//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorRejectedProposedDebtDetailsPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorRejectedProposedDebtDetailsPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement Backlink { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-rejected-header")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-type")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-creditor")]
//        public virtual IPageElement DebtCreditor { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-amount")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-ref")]
//        public virtual IPageElement DebtReference { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-why-reject-debt-heading")]
//        public virtual IPageElement WhyRejectedHeader { get; set; }

//        [Find(By: By.CssSelector, Using: "#ma-debtor-prop-debt-why-reject-debt-heading+div")]
//        public virtual IPageElement WhyRejectedValue { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-reject-on-heading")]
//        public virtual IPageElement RejectedOnHeader { get; set; }

//        [Find(By: By.CssSelector, Using: "#ma-debtor-prop-debt-reject-on-heading+div")]
//        public virtual IPageElement RejectedOnValue { get; set; }

//    }
//}
