//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorAddBusinessAddressManualPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorAddBusinessAddressManualPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Class, Using: "govuk-fieldset__heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.CssSelector, Using: "h2.govuk-heading-s")]
//        public virtual IPageElement BusinessHeading { get; set; }

//        [Find(By: By.CssSelector, Using: "p.govuk-body")]
//        public virtual IPageElement BusinessNameValue { get; set; }

//        [Find(By: By.Id, Using: "debtor-manuanl-business-change")]
//        public virtual IPageElement ChangeBusinessName { get; set; }

//        [Find(By: By.Id, Using: "debtor-add-business-address-heading")]
//        public virtual IPageElement ClientBusinessAddressHeading { get; set; }

//        [Find(By: By.Id, Using: "Address1-label")]
//        public virtual IPageElement AddressLine1Label { get; set; }

//        [Find(By: By.Id, Using: "Address1-validation")]
//        public virtual IPageElement AddressLine1Validation { get; set; }

//        [Find(By: By.Id, Using: "Address1-input")]
//        public virtual IInputTextElement Addresslinetext { get; set; }

//        [Find(By: By.Id, Using: "Address2-input")]
//        public virtual IInputTextElement Addressline2text { get; set; }

//        [Find(By: By.Id, Using: "TownCity-label")]
//        public virtual IPageElement TownCityLabel { get; set; }

//        [Find(By: By.Id, Using: "TownCity-validation")]
//        public virtual IPageElement TownCityValidation { get; set; }

//        [Find(By: By.Id, Using: "TownCity-input")]
//        public virtual IInputTextElement TownCitytext { get; set; }

//        [Find(By: By.Id, Using: "County-label")]
//        public virtual IPageElement CountyLabel { get; set; }

//        [Find(By: By.Id, Using: "County-validation")]
//        public virtual IPageElement CountyValidation { get; set; }

//        [Find(By: By.Id, Using: "County-input")]
//        public virtual IInputTextElement Countytext { get; set; }

//        [Find(By: By.Id, Using: "Postcode-input")]
//        public virtual IPageElement PostcodeLabel { get; set; }

//        [Find(By: By.Id, Using: "Postcode-validation")]
//        public virtual IPageElement PostcodeValidation { get; set; }

//        [Find(By: By.Id, Using: "Postcode-input")]
//        public virtual IInputTextElement Postcodetext { get; set; }

//        [Find(By: By.CssSelector, Using: "#country_container label")]
//        public virtual IPageElement CountryLabel { get; set; }

//        [Find(By: By.Id, Using: "Country")]
//        public virtual IPageElement CountryDropdownVal { get; set; }

//        [Find(By: By.Id, Using: "error-list")]
//        public virtual IPageElement ErrorList { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IPageElement SaveAndContinue { get; set; }
//    }
//}
