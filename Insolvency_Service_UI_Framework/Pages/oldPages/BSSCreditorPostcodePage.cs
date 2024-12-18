//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSCreditorPostcodePage
//    {
//        public BSSCreditorPostcodePage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "add-creditor-address-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "Postcode-input")]
//        public virtual IInputTextElement PostcodeField { get; set; }

//        [Find(By: By.Id, Using: "Postcode-label")]
//        public virtual IInputTextElement PostcodeLabel { get; set; }

//        [Find(By: By.Id, Using: "search-button")]
//        public virtual IButtonElement FindAddressButton { get; set; }

//        [Find(By: By.Id, Using: "SelectedAddress")]
//        public virtual ISelectElement AddressDropdownList { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IButtonElement SaveAndContinueButton { get; set; }

//        [Find(By: By.Id, Using: "add-creditor-address-heading")]
//        public virtual IPageElement AddCreditorAddress { get; set; }

//        [Find(By: By.Id, Using: "add-creditor-address-change-call-to-action")]
//        public virtual IPageElement ChangeLink { get; set; }

//        [Find(By: By.Id, Using: "address-manual")]
//        public virtual IPageElement EnterAddressManually { get; set; }

//        [Find(By: By.Id, Using: "error-list")]
//        public virtual IPageElement ErrorMessageSummary { get; set; }

//        [Find(By: By.Id, Using: "Postcode-validation")]
//        public virtual IPageElement PostCodeErrorMessage { get; set; }

//        [Find(By: By.Id, Using: "error-summary")]
//        public virtual IPageElement ErrorMessageSummaryBox { get; set; }

//        [Find(By: By.Id, Using: "selected-address-validation-errors")]
//        public virtual IPageElement SelectAddressErrorMessage { get; set; }

//        [Find(By: By.Id, Using: "add-creditor-address-creditor-label")]
//        public virtual IPageElement CreditorLabel { get; set; }

//        [Find(By: By.Id, Using: "add-creditor-address-creditor-name")]
//        public virtual IPageElement CreditorName { get; set; }

//        [Find(By: By.Id, Using: "add-creditor-address-step-caption")]
//        public virtual IPageElement StepProgress { get; set; }
//    }
//}