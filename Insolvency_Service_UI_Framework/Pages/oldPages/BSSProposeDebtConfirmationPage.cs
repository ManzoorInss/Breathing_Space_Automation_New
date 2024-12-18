//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSProposeDebtConfirmationPage
//    {
//        public BSSProposeDebtConfirmationPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-details-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-details-subheading")]
//        public virtual IPageElement PageSubHeading { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-details-debt-label")]
//        public virtual IPageElement DebtLabel { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-details-debt-type")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-details-debt-amount")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-details-debt-change-call-to-action")]
//        public virtual IPageElement ChangeDebtAmountLink { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-details-debt-reference")]
//        public virtual IPageElement DebtReference { get; set; }

//        [FindAll(By: By.Id, Using: "propose-debt-debt-details-debt-reference")]
//        public virtual IPageElements NotVisibleDebtReference { get; set; }

//        [Find(By: By.Id, Using: "propose-debt-debt-details-debt-nino")]
//        public virtual IPageElement DebtNino { get; set; }

//        [FindAll(By: By.Id, Using: "propose-debt-debt-details-debt-nino")]
//        public virtual IPageElements NotVisibleDebtNino { get; set; }

//        [Find(By: By.Id, Using: "confirm-and-submit")]
//        public virtual IPageElement ConfirmSubmitButton { get; set; }
//    }
//}
