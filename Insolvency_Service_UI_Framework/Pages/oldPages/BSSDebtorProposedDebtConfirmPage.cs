//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorProposedDebtConfirmPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorProposedDebtConfirmPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement Backlink { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-confirm-header")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-type")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-creditor")]
//        public virtual IPageElement DebtCreditor { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-amount")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-ref")]
//        public virtual IPageElement DebtReference { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-confirm-save")]
//        public virtual IPageElement ConfirmProposedDebt { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-confirm-why-reject-debt-heading")]
//        public virtual IPageElement WhyRejectingHeader { get; set; }

//        [Find(By: By.CssSelector, Using: "#ma-debtor-prop-debt-confirm-why-reject-debt-heading+div")]
//        public virtual IPageElement WhyRejectingValue { get; set; }

//    }
//}