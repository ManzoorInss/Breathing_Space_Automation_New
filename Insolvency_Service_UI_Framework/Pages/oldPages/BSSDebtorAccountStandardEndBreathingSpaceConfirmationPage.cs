//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;
//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorAccountStandardEndBreathingSpaceConfirmationPage
//    {
//        public BSSDebtorAccountStandardEndBreathingSpaceConfirmationPage(IDriver driver)
//        {
//            Driver = driver;
//        }
//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "end-breathing-space-main-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "end-breathing-space-secondary-heading")]
//        public virtual IPageElement PageHeading { get; set; }

//        [Find(By: By.CssSelector, Using: "p.govuk-body-m")]
//        public virtual IPageElement ReasonLabel { get; set; }

//        [Find(By: By.Class, Using: "govuk-body-m")]
//        public virtual IPageElement ReasonValue { get; set; }

//        [Find(By: By.CssSelector, Using: "#content strong")]
//        public virtual IPageElement Warning { get; set; }

//        [Find(By: By.Id, Using: "confirm-button")]
//        public virtual IButtonElement Confirmbutton { get; set; }
//    }
//}
