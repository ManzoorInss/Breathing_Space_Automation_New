//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorEndStandardBreathingSpaceDecisionPage
//    {
//        public IDriver Driver { get; }

//        [Find(By: By.Class, Using: "govuk-fieldset__heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Class, Using: "govuk-radios")]
//        public virtual IPageElement DecisionOptions { get; set; }

//        [Find(By: By.Id, Using: "save-button")]
//        public virtual IPageElement SaveButton { get; set; }

//        [Find(By: By.Id, Using: "submit-client-no-longer-eligible")]
//        public virtual IPageElement noLongerEligible { get; set; }

//        [Find(By: By.Id, Using: "submit-client-not-complied-with-obligations")]
//        public virtual IPageElement nonCompliedObs { get; set; }

//        [Find(By: By.Id, Using: "submit-unable-to-consult-client")]
//        public virtual IPageElement unableConsult { get; set; }

//        [Find(By: By.Id, Using: "submit-client-using-debt-management-solution")]
//        public virtual IPageElement bebtManSol { get; set; }

//        [Find(By: By.Id, Using: "submit-client-is-able-to-pay-their-debts")]
//        public virtual IPageElement ablePayDebts { get; set; }

//        [Find(By: By.Id, Using: "submit-client-is-deceased")]
//        public virtual IPageElement deceased { get; set; }

//        [Find(By: By.Id, Using: "submit-not-complied-with-obligation-is-decision-part-of-midway-review-yes")]
//        public virtual IPageElement obligationYes { get; set; }

//        [Find(By: By.Id, Using: "submit-not-complied-with-obligation-is-decision-part-of-midway-review-no")]
//        public virtual IPageElement obligationNo { get; set; }

//        [Find(By: By.Id, Using: "submit-unable-to-contact-client-is-decision-part-of-midway-review-yes")]
//        public virtual IPageElement contactYes { get; set; }

//        [Find(By: By.Id, Using: "submit-unable-to-contact-client-is-decision-part-of-midway-review-no")]
//        public virtual IPageElement contactNo { get; set; }

//        [Find(By: By.Id, Using: "submit-using-debt-management-is-decision-part-of-midway-review-yes")]
//        public virtual IPageElement debtManYes { get; set; }

//        [Find(By: By.Id, Using: "submit-using-debt-management-is-decision-part-of-midway-review-no")]
//        public virtual IPageElement debtManNo { get; set; }

//        [Find(By: By.Id, Using: "submit-client-has-interim-order-or-individual-voluntary-arrangement")]
//        public virtual IPageElement voluntaryArrangement { get; set; }
       
//        [Find(By: By.Id, Using: "error-summary")]
//        public virtual IPageElement ErrorSummaryList { get; set; }

//        [Find(By: By.Id, Using: "submit-client-no-longer-eligible-form")]
//        public virtual IPageElement EligibilityForm { get; set; }

//        [Find(By: By.Id, Using: "submit-client-not-complied-with-obligations-form")]
//        public virtual IPageElement ObligationsForm { get; set; }

//        [Find(By: By.Id, Using: "submit-unable-to-consult-client-form")]
//        public virtual IPageElement ConsultForm { get; set; }

//        [Find(By: By.Id, Using: "submit-client-using-debt-management-solution-form")]
//        public virtual IPageElement DebtSolForm { get; set; }

//        [Find(By: By.CssSelector, Using: "#submit-client-is-deceased-form span")]
//        public virtual IPageElement ClientdeceasedHeading { get; set; }

//        [Find(By: By.Id, Using: "deathOfDeath-hint")]
//        public virtual IPageElement ClientdeceasedDatehint { get; set; }

//        [Find(By: By.Id, Using: "deathOfDeath-day-input")]
//        public virtual IInputTextElement ClientdeceasedDateDay { get; set; }

//        [Find(By: By.Id, Using: "deathOfDeath-month-input")]
//        public virtual IInputTextElement ClientdeceasedDateMonth { get; set; }

//        [Find(By: By.Id, Using: "deathOfDeath-year-input")]
//        public virtual IInputTextElement ClientdeceasedDateYear { get; set; }

//        [Find(By: By.Id, Using: "errors")]
//        public virtual IPageElement optionErrors { get; set; }

//        [Find(By: By.Id, Using: "date-of-death-error-list")]
//        public virtual IPageElement DeathdateErrorList { get; set; }

//        [Find(By: By.Id, Using: "submit-client-is-deceased")]
//        public virtual IPageElement submitdeceased { get; set; }

//        public BSSDebtorEndStandardBreathingSpaceDecisionPage(IDriver driver)
//        {
//            Driver = driver;
//        }
//    }
//}