//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;
//namespace BSSTestAutomation.Pages
//{
//    public class BSSCreditorViewDebtorAccountPage
//    {
//        public IDriver Driver { get; }

//        public BSSCreditorViewDebtorAccountPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "home-navigation-home-link")]
//        public virtual IPageElement HomePageNavHomeLink { get; set; }

//        [Find(By: By.Id, Using: "home-navigation-user-name")]
//        public virtual IPageElement HomePageNavUserName { get; set; }

//        [Find(By: By.Id, Using: "home-navigation-organisation-name")]
//        public virtual IPageElement HomePageOrgName { get; set; }

//        [Find(By: By.Id, Using: "sign-out")]
//        public virtual IPageElement HomePageSignOut { get; set; }

//        [Find(By: By.Id, Using: "govuk-header-link-sign-out")]
//        public virtual IPageElement HomePageBlackBannerSignOut { get; set; }

//        [Find(By: By.Id, Using: "home-navigation-search-for-account")]
//        public virtual IPageElement HomeSearchForAccount { get; set; }
        
//        [Find(By: By.Id, Using: "breathing-space-for-label")]
//        public virtual IPageElement HomePageAccountNameRemoved { get; set; }

//        [Find(By: By.Id, Using: "ma-org-name-lead")]
//        public virtual IPageElement HomePageOrgNameText { get; set; }
        
//        [Find(By: By.Id, Using: "account-header-start-and-end")]
//        public virtual IPageElement HomePageStartsLabel { get; set; }

//        [Find(By: By.Id, Using: "creditor-ma-details-email")]
//        public virtual IPageElement HomePageMAEmail { get; set; }

//        [Find(By: By.Id, Using: "creditor-ma-details-name")]
//        public virtual IPageElement HomePageMAName { get; set; }

//        [Find(By: By.Id, Using: "creditor-org")]
//        public virtual IPageElement HomePageCreditorOrg { get; set; }

//        [Find(By: By.Id, Using: "ma-org")]
//        public virtual IPageElement HomePageMAOrg { get; set; }

//        [Find(By: By.Id, Using: "ma-name")]
//        public virtual IPageElement HomePageMAOrganisationName { get; set; }

//        [Find(By: By.Id, Using: "creditor-ma-details-telephone")]
//        public virtual IPageElement HomePageMATelephone { get; set; }

//        [Find(By: By.Id, Using: "sold-debt-view-details-0")]
//        public virtual IPageElement ViewReviewDetailsLink { get; set; }
        
//        [Find(By: By.Id, Using: "sold-debt-details-heading")]
//        public virtual IPageElement PageHeader { get; set; }

//        [Find(By: By.Id, Using: "view-proposed-debt-details-0")]
//        public virtual IPageElement ClickViewProposedDebtDetailsLink { get; set; }

//        [Find(By: By.Id, Using: "account-review-confirmation")]
//        public virtual IPageElement ConfirmationBanner { get; set; }
//    }
//}