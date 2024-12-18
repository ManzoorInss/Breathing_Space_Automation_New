//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSCreditorHomePage
//    {
//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "cookie-banner-accept")]
//        public virtual IPageElement AcceptCookieButton { get; set; }

//        [Find(By: By.Id, Using: "home-navigation-user-name")]
//        public virtual IPageElement HomePageNavUserName { get; set; }

//        [Find(By: By.Id, Using: "home-navigation-home-link")]
//        public virtual IPageElement HomePageNavHomeLink { get; set; }

//        [Find(By: By.Id, Using: "home-navigation-organisation-name")]
//        public virtual IPageElement HomePageNavOrgName { get; set; }

//        [Find(By: By.Id, Using: "organisation-name")]
//        public virtual IPageElement HomePageOrgName { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-0-debts-link")]
//        public virtual IPageElement BSActiveCount { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-1-debts-link")]
//        public virtual IPageElement HomePageCreditCardLink { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-2-debts-link")]
//        public virtual IPageElement HomePageUnsecuredLoanLink { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-3-debts-link")]
//        public virtual IPageElement HomePageLeasingLink { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-4-debts-link")]
//        public virtual IPageElement HomePageMortgageLink { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-5-debts-link")]
//        public virtual IPageElement HomePageOtherLink { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-1-tasks-link")]
//        public virtual IPageElement HomePageCreditCardTasksToDoLink { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-2-tasks-link")]
//        public virtual IPageElement HomePageUnsecuredLoanTasksToDoLink { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-3-tasks-link")]
//        public virtual IPageElement HomePageLeasingTasksToDoLink { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-4-tasks-link")]
//        public virtual IPageElement HomePageMortgageTasksToDoLink { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-5-tasks-link")]
//        public virtual IPageElement HomePageOtherTasksToDoLink { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-0-debts-link")]
//        public virtual IPageElement HomePageTotalDebtsLink { get; set; }

//        [Find(By: By.Id, Using: "debt-type-card-0-tasks-link")]
//        public virtual IPageElement HomePageTotalDebtsTasksToDoLink { get; set; }
//        public BSSCreditorHomePage(IDriver driver)
//        {
//            Driver = driver;
//        }
//    }
//}
