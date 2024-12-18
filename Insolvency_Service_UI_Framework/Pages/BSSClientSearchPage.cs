//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSClientSearchPage
//    {
//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "account-search-heading")]
//        public virtual IPageElement SearchPageTitle { get; set; }

//        [Find(By: By.Id, Using: "home-navigation-search-link")]
//        public virtual IPageElement SearchPageTopHeading { get; set; }

//        [FindAll(By: By.CssSelector, Using: "a#home-navigation-search-link")]
//        public virtual IPageElements SearchPageTopLink { get; set; }

//        [Find(By: By.Id, Using: "home-navigation-home-link")]
//        public virtual IPageElement HomePageTopLink { get; set; }

//        [Find(By: By.Id, Using: "account-search-searchedby-hint")]
//        public virtual IPageElement SelectOneOPtionHeading { get; set; }

//        [Find(By: By.Id, Using: "account-search-searchedby-ref-hint")]
//        public virtual IPageElement BreathingSpaceRefoption { get; set; }

//        [Find(By: By.Id, Using: "Reference-label")]
//        public virtual IPageElement RefLabel { get; set; }

//        [Find(By: By.Id, Using: "Reference-hint")]
//        public virtual IPageElement RefHintLabel { get; set; }

//        [Find(By: By.Id, Using: "Reference-input")]
//        public virtual IInputTextElement RefInput { get; set; }

//        [Find(By: By.Id, Using: "Reference-validation")]
//        public virtual IPageElement RefValidation { get; set; }

//        [Find(By: By.Id, Using: "account-search-searchedby-dob-hint")]
//        public virtual IPageElement LastNameandDOBoption { get; set; }

//        [Find(By: By.Id, Using: "account-search-dob-name-header")]
//        public virtual IPageElement LastNameDOBHeader { get; set; }

//        [Find(By: By.Id, Using: "Surname-label")]
//        public virtual IPageElement LastNameLabel { get; set; }

//        [Find(By: By.Id, Using: "Surname-input")]
//        public virtual IInputTextElement LastNameInput { get; set; }

//        [Find(By: By.CssSelector, Using: "h2#account-search-searchedby-dob-hint")]
//        public virtual IPageElement DobHeader { get; set; }

//        [Find(By: By.Id, Using: "dob-hint")]
//        public virtual IPageElement DobHint { get; set; }

//        [Find(By: By.Id, Using: "dob-day-input")]
//        public virtual IInputTextElement DobDay { get; set; }

//        [Find(By: By.Id, Using: "dob-month-input")]
//        public virtual IInputTextElement DobMonth { get; set; }

//        [Find(By: By.Id, Using: "dob-year-input")]
//        public virtual IInputTextElement DobYear { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IButtonElement SearchButton { get; set; }

//        [Find(By: By.Id, Using: "error-list")]
//        public virtual IPageElement ErrorList { get; set; }

//        [Find(By: By.Id, Using: "account-search-search-option-error-message")]
//        public virtual IPageElement AllFieldValidation { get; set; }

//        [Find(By: By.Id, Using: "Surname-validation")]
//        public virtual IPageElement SurnameValidation { get; set; }

//        [Find(By: By.Id, Using: "dob-validation")]
//        public virtual IPageElement DobValidation { get; set; }

//        public BSSClientSearchPage(IDriver driver)
//        {
//            Driver = driver;
//        }
//    }
//}
