//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorAccountConfirmationPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorAccountConfirmationPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using:"account-confirmation-back-to-home")]
//        public virtual IPageElement ServiceHomepageLink { get; set; }

//        [Find(By: By.Class, Using:"govuk-panel__title")]
//        public virtual IPageElement BreathingSpaceSubmitted { get; set; }
        
//        [Find(By: By.Id, Using:"account-confirmation-reference")]
//        public virtual IPageElement ReferenceNumber { get; set; }

//        [Find(By: By.CssSelector, Using: "#main-content h2.govuk-heading-m")]
//        public virtual IPageElement WhatHappensNext { get; set; }

//        [Find(By: By.CssSelector, Using: "p.govuk-body")]
//        public virtual IPageElement WillHappenNext { get; set; }
//    }
//}