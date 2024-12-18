//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorPointContactAddressManualPage
//    {
//        public BSSDebtorPointContactAddressManualPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Class, Using: "govuk-fieldset__heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "Address1-input")]
//        public virtual IPageElement Address1 { get; set; }

//        [Find(By: By.Id, Using: "Address1-validation")]
//        public virtual IPageElement Address1validation { get; set; }

//        [Find(By: By.Id, Using: "Address2-input")]
//        public virtual IPageElement Address2 { get; set; }

//        [Find(By: By.Id, Using: "TownCity-input")]
//        public virtual IPageElement TownCity { get; set; }

//        [Find(By: By.Id, Using: "TownCity-validation")]
//        public virtual IPageElement TownCityvalidation { get; set; }

//        [Find(By: By.Id, Using: "County-input")]
//        public virtual IPageElement County { get; set; }

//        [Find(By: By.Id, Using: "Postcode-input")]
//        public virtual IPageElement Postcode { get; set; }

//        [Find(By: By.Id, Using: "Postcode-validation")]
//        public virtual IPageElement PostcodeValidation { get; set; }

//        [Find(By: By.Id, Using: "Country")]
//        public virtual IPageElement Country { get; set; }

//        [Find(By: By.Id, Using: "error-list")]
//        public virtual IPageElement ErrorList { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IPageElement Savebutton { get; set; }
//    }
//}