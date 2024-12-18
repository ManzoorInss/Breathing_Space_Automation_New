//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorAccountEndConfirmationPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorAccountEndConfirmationPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "debtor-account-end-heading")]
//        public virtual IPageElement ConfirmationHeading { get; set; }

//        [Find(By: By.Id, Using: "debtor-account-end-body")]
//        public virtual IPageElement ConfirmationBody { get; set; }

//        [Find(By: By.Id, Using: "debtor-account-end-next")]
//        public virtual IPageElement WhatHappensNextHeading { get; set; }

//        [Find(By: By.Id, Using: "debtor-account-end-next-step")]
//        public virtual IPageElement WhatHappensNextBody { get; set; }

//        [Find(By: By.Id, Using: "debtor-account-end-client")]
//        public virtual IPageElement ReturnToClientPageLink { get; set; }

//        [Find(By: By.Id, Using: "debtor-account-end-index")]
//        public virtual IPageElement ReturnToServiceHomePageLink { get; set; }
//    }
//}