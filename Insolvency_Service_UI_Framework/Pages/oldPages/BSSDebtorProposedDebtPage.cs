//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorProposedDebtPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorProposedDebtPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement Backlink { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-header")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-type")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-creditor")]
//        public virtual IPageElement DebtCreditor { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-amount")]
//        public virtual IPageElement DebtAmount { get; set; }
        
//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-ref")]
//        public virtual IPageElement DebtReference { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-question")]
//        public virtual IPageElement DebtQuestionHeading { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-accept")]
//        public virtual IRadioElement DebtAccept { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-reject")]
//        public virtual IRadioElement DebtReject { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-reject-reason")]
//        public virtual IInputTextElement DebtRejectReason { get; set; }

//        [Find(By: By.Id, Using: "ma-debtor-prop-debt-save")]
//        public virtual IButtonElement SaveProposedDebt { get; set; }
//    }
//}