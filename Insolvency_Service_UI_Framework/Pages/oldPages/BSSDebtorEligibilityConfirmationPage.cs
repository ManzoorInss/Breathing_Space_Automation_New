//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorEligibilityConfirmationPage
//    {
//        public BSSDebtorEligibilityConfirmationPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Class, Using: "govuk-back-link")]
//        public virtual IPageElement BackButton { get; set; }

//        [Find(By: By.Class, Using: "govuk-fieldset__heading")]
//        public virtual IPageElement PageTitleText { get; set; }

//        [Find(By: By.CssSelector, Using: ".govuk-list:nth-of-type(1)")]
//        public virtual IPageElement BulletPoints { get; set; }

//        [Find(By: By.Id, Using: "IsEligible")]
//        public virtual IPageElement CheckBox { get; set; }

//        [Find(By: By.CssSelector, Using: ".govuk-label:nth-of-type(1)")]
//        public virtual IPageElement CheckBoxText { get; set; }

//        [Find(By: By.Id, Using: "debtor-eligibility-save")]
//        public virtual IPageElement SaveAndContinueButton { get; set; }
//    }
//}