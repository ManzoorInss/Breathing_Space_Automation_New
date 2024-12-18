//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;
//namespace BSSTestAutomation.Pages
//{
//    public class BSSCreditorHomeBrowsePage
//    {
//        public IDriver Driver { get; }

//        public BSSCreditorHomeBrowsePage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "browse-by-category-active-creditors-label")]
//        public virtual IPageElement AllActiveBSRadioButtonLabel { get; set; }

//        [Find(By: By.Id, Using: "browse-by-category-tasks-to-do-label")]
//        public virtual IPageElement TasksToDoRadioButtonLabel { get; set; }

//        [Find(By: By.Id, Using: "browse-by-category-sent-to-money-adviser-label")]
//        public virtual IPageElement SentToMARadioButtonLabel { get; set; }

//        [Find(By: By.CssSelector, Using: ".govuk-heading-l")]
//        public virtual IPageElement PageHeading { get; set; }

//        [Find(By: By.Id, Using: "browse-by-category-active-creditors")]
//        public virtual IPageElement AllActiveBSRadioButton { get; set; }

//        [Find(By: By.CssSelector, Using: "#content-list > h2")]
//        public virtual IPageElement ShowingLabel { get; set; }

//        [Find(By: By.Id, Using: "sort")]
//        public virtual IPageElement SortDropdown { get; set; }

//        [Find(By: By.Id, Using: "sort-button")]
//        public virtual IPageElement SortButton { get; set; }

//        [Find(By: By.Id, Using: "debts-heading")]
//        public virtual IPageElement DebtTitle { get; set; }

//        [FindAll(By: By.CssSelector, Using: "#content-list > ul > li")]
//        public virtual IPageElements ListofResults { get; set; }

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

//        [Find(By: By.Id, Using: "browse-by-debt-status-active-new-debt-label")]
//        public virtual IPageElement DebtReviewedRadioButtonLabel { get; set; }

//        [Find(By: By.Id, Using: "browse-by-debt-status-active-after-review-label")]
//        public virtual IPageElement ActiveAfterMoneyAdviserRadioButtonLabel { get; set; }

//    }
//}