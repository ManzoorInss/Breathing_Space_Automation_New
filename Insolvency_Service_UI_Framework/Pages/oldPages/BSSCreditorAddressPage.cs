//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSCreditorAddressPage
//    {
//        public IDriver Driver { get; }

//        [Find(By: By.Class, Using:"govuk-fieldset__heading")]
//        public virtual IPageElement AddressPageTitle { get; set; }

//        [Find(By: By.Id, Using:"Address1-input")]
//        public virtual IInputTextElement AddressPageAddressLine1 { get; set; }

//        [Find(By: By.Id, Using:"Address2-input")]
//        public virtual IInputTextElement AddressPageAddressLine2 { get; set; }

//        [Find(By: By.Id, Using:"TownCity-input")]
//        public virtual IInputTextElement AddressPageAddressTownCity { get; set; }

//        [Find(By: By.Id, Using:"County-input")]
//        public virtual IInputTextElement AddressPageAddressCounty { get; set; }

//        [Find(By: By.Id, Using:"Postcode-input")]
//        public virtual IInputTextElement AddressPageAddressPostCode { get; set; }

//        [Find(By: By.Id, Using:"save-button")]
//        public virtual IPageElement AddressPageAddressSaveButton { get; set; }

//        [Find(By: By.Id, Using:"error-summary")]
//        public virtual IPageElement AddressPageErrorSummary { get; set; }

//        [Find(By: By.Id, Using:"error-list")]
//        public virtual IPageElement AddressPageErrorSummaryErrors { get; set; }

//        [Find(By: By.Class, Using:"govuk-back-link")]
//        public virtual IPageElement AddressBackButton { get; set; }

//        [Find(By: By.Id, Using:"TownCity-validation")]
//        public virtual IPageElement AddressTownCityValidation { get; set; }

//        [Find(By: By.Id, Using:"Address1-validation")]
//        public virtual IPageElement AddressBuildStreetValidation { get; set; }

//        [Find(By: By.Id, Using:"County-validation")]
//        public virtual IPageElement AddressCountyValidation { get; set; }

//        [Find(By: By.Id, Using:"Postcode-validation")]
//        public virtual IPageElement AddressPostcodeValidation { get; set; }
        
//        [Find(By: By.Id, Using: "Country")]
//        public virtual ISelectElement SelectCountry { get; set; }

//        public BSSCreditorAddressPage(IDriver driver)
//        {
//            Driver = driver;
//        }
//    }
//}