//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorPreviousAddressPage
//    {
//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "Postcode-input")]
//        public virtual IInputTextElement PostcodeInput { get; set; }

//        [Find(By: By.Id, Using: "debtor-prev-add-search")]
//        public virtual IPageElement FindAddressButton { get; set; }

//        [Find(By: By.Class, Using: "govuk-fieldset__heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "SelectedAddress")]
//        public virtual ISelectElement AddressSelect { get; set; }

//        [Find(By: By.Id, Using: "moveInDate-month-input")]
//        public virtual IInputTextElement MoveInMonthInput { get; set; }

//        [Find(By: By.Id, Using: "moveInDate-year-input")]
//        public virtual IInputTextElement MoveInYearInput { get; set; }

//        [Find(By: By.Id, Using: "moveOutDate-month-input")]
//        public virtual IInputTextElement MoveOutMonthInput { get; set; }

//        [Find(By: By.Id, Using: "moveOutDate-year-input")]
//        public virtual IInputTextElement MoveOutYearInput { get; set; }

//        [Find(By: By.Id, Using: "debtor-prev-add-save")]
//        public virtual IPageElement SaveAndContinueButton { get; set; }

//        [Find(By: By.Id, Using: "debtor-prev-add-error-summary")]
//        public virtual IPageElement ErrorSummary { get; set; }

//        [Find(By: By.Id, Using: "moveInDate-validation")]
//        public virtual IPageElement MoveInValidationMessage { get; set; }

//        [Find(By: By.Id, Using: "moveOutDate-validation")]
//        public virtual IPageElement MoveOutValidationMessage { get; set; }

//        [Find(By: By.Class, Using: "govuk-error-message")]
//        public virtual IPageElement AddressValidationMessage { get; set; }

//        [Find(By: By.Id, Using: "debtor-prev-add-manual")]
//        public virtual IPageElement ManualAddressLink { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement Backlink { get; set; }

//        [Find(By: By.Id, Using: "address-search-change-postcode")]
//        public virtual IPageElement ChangePostcode { get; set; }
        
//        public BSSDebtorPreviousAddressPage(IDriver driver)
//        {
//            Driver = driver;
//        }
//    }
//}