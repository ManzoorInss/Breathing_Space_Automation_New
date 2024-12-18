//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorPreviousAddressManualPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorPreviousAddressManualPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Class, Using: "govuk-fieldset__heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "debtor-add-previous-address-heading")]
//        public virtual IPageElement PreviousAddressHeading { get; set; }

//        [Find(By: By.Id, Using: "Address1-label")]
//        public virtual IPageElement Address1Label { get; set; }

//        [Find(By: By.Id, Using: "Address1-validation")]
//        public virtual IPageElement Address1error { get; set; }

//        [Find(By: By.Id, Using: "Address1-input")]
//        public virtual IInputTextElement Address1text { get; set; }

//        [Find(By: By.Id, Using: "Address2-input")]
//        public virtual IInputTextElement Address2text { get; set; }

//        [Find(By: By.Id, Using: "TownCity-label")]
//        public virtual IPageElement TownCityLabel { get; set; }

//        [Find(By: By.Id, Using: "TownCity-validation")]
//        public virtual IPageElement TownCityerror { get; set; }

//        [Find(By: By.Id, Using: "TownCity-input")]
//        public virtual IInputTextElement TownCitytext { get; set; }

//        [Find(By: By.Id, Using: "County-input")]
//        public virtual IInputTextElement Countytext { get; set; }

//        [Find(By: By.Id, Using: "Postcode-label")]
//        public virtual IPageElement PostcodeLabel { get; set; }

//        [Find(By: By.Id, Using: "Postcode-validation")]
//        public virtual IPageElement Postcodeerror { get; set; }

//        [Find(By: By.Id, Using: "Postcode-input")]
//        public virtual IInputTextElement Postcodetext { get; set; }

//        [Find(By: By.Id, Using: "Country")]
//        public virtual ISelectElement Country { get; set; }

//        [Find(By: By.Id, Using: "moved-in-label")]
//        public virtual IPageElement MoveInHeading { get; set; }

//        [Find(By: By.Id, Using: "movedInhint")]
//        public virtual IPageElement movedInhint { get; set; }

//        [Find(By: By.Id, Using: "moveInDate-month-input")]
//        public virtual IInputTextElement moveInDatemonthinput { get; set; }

//        [Find(By: By.Id, Using: "moveInDate-year-input")]
//        public virtual IInputTextElement moveInDateYearinput { get; set; }

//        [Find(By: By.Id, Using: "moveInDate-validation")]
//        public virtual IPageElement moveInDatevalidation { get; set; }

//        [Find(By: By.Id, Using: "moved-out-label")]
//        public virtual IPageElement MoveOutHeading { get; set; }

//        [Find(By: By.Id, Using: "movedOuthint")]
//        public virtual IPageElement movedOuthint { get; set; }

//        [Find(By: By.Id, Using: "moveOutDate-month-input")]
//        public virtual IInputTextElement moveOutDatemonthinput { get; set; }

//        [Find(By: By.Id, Using: "moveOutDate-year-input")]
//        public virtual IInputTextElement moveOutDateYearinput { get; set; }

//        [Find(By: By.Id, Using: "moveOutDate-validation")]
//        public virtual IPageElement moveOutDatevalidation { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IButtonElement SaveAndContinue { get; set; }

//        [Find(By: By.Id, Using: "error-summary")]
//        public virtual IPageElement ErrorList { get; set; }
//    }
//}