//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;
//using System;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorPointContactAddressPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorPointContactAddressPage(IDriver driver)
//        {
//            Driver = driver;
//        }
        
//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackButton { get; set; }

//        [Find(By: By.Class, Using: "govuk-heading-l")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "Postcode-label")]
//        public virtual IPageElement PostcodeHeader { get; set; }

//        [Find(By: By.Id, Using: "Postcode-input")]
//        public virtual IInputTextElement PostCodeField { get; set; }

//        [Find(By: By.Id, Using: "search-button")]
//        public virtual IButtonElement FindAddressButton { get; set; }

//        [Find(By: By.Id, Using: "address-search-sub-heading")]
//        public virtual IPageElement InputPostcodeHeader { get; set; }

//        [Find(By: By.Id, Using: "address-search-change-postcode")]
//        public virtual IPageElement ChangeLink { get; set; }

//        [Find(By: By.Id, Using: "debtor-nominated-contact-manual-address")]
//        public virtual IPageElement EnterManualAddressLink { get; set; }

//        [Find(By: By.Id, Using: "SelectedAddress")]
//        public virtual ISelectElement AddressDropDown { get; set; }

//        [FindAll(By: By.Id, Using: "govuk-form-group")]
//        public virtual IPageElements AllAddressValues { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IButtonElement SaveAndContinueButton { get; set; }

//        [Find(By: By.Id, Using: "error-list")]
//        public virtual IPageElement ErrorListSummary { get; set; }

//        [Find(By: By.Id, Using: "Postcode-validation")]
//        public virtual IPageElement PostcodeValidationMessage { get; set; }

//        [FindAll(By: By.Class, Using: "govuk-form-group")]
//        public virtual IPageElements SelectAddressErrorMessage { get; set; }

//        internal string SearchAddressInDropdown(string postcode, string optionValues)
//        {
//            string errorMessage = null;
//            string[] optionVal = optionValues.Split(new string[] { "\r\n" }, StringSplitOptions.None);
//            for (int i = 1; i < optionVal.Length; i++)
//            {                
//                if (!optionVal[i].Contains(postcode))
//                {
//                    errorMessage = errorMessage + optionVal[i] + "\n";
//                }
//            }
//            return errorMessage;
//        }
//    }
//}