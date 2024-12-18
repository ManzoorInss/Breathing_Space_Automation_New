//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorEndMentalHealthBreathingSpaceDecisionPage
//    {
//        public IDriver Driver { get; }

//        [Find(By: By.Id, Using: "submit-no-longer-eligible")]
//        public virtual IPageElement noLongerEligible { get; set; }

//        [Find(By: By.Id, Using: "submit-stopped-treatment")]
//        public virtual IPageElement stoppedTreatment { get; set; }

//        [Find(By: By.Id, Using: "submit-unable-to-reach-point-of-contact")]
//        public virtual IPageElement unableToReach { get; set; }

//        [Find(By: By.Id, Using: "submit-no-longer-eligible-sub-question-has-another-breathing-space-within-twelve-months")]
//        public virtual IPageElement hadAnotherMoratorium { get; set; }

//        [Find(By: By.Id, Using: "submit-stopped-treatment-sub-question-yes")]
//        public virtual IPageElement stopTreatmentYes { get; set; }

//        [Find(By: By.Id, Using: "submit-stopped-treatment-sub-question-no")]
//        public virtual IPageElement stopTreatmentNo { get; set; }

//        [Find(By: By.Id, Using: "submit-unable-to-reach-point-of-contact-sub-question-yes")]
//        public virtual IPageElement unableToReachYes { get; set; }

//        [Find(By: By.Id, Using: "submit-unable-to-reach-point-of-contact-sub-question-no")]
//        public virtual IPageElement unableToReachNo { get; set; }

//        [Find(By: By.Id, Using: "submit-cancelled")]
//        public virtual IPageElement askedToCancel { get; set; }

//        [Find(By: By.Id, Using: "submit-no-longer-eligible-sub-question")]
//        public virtual IPageElement nolongerEligibleQuestions { get; set; }

//        [Find(By: By.Id, Using: "submit-stopped-treatment-sub-question")]
//        public virtual IPageElement stoppedTreatmentQuestions { get; set; }

//        [Find(By: By.CssSelector, Using: "#submit-stopped-treatment-sub-question > span")]
//        public virtual IPageElement treatmentEndHeading { get; set; }

//        [Find(By: By.Id, Using: "treatmentEndDate-hint")]
//        public virtual IPageElement treatmentEndDatehint { get; set; }

//        [Find(By: By.Id, Using: "treatmentEndDate-day-input")]
//        public virtual IInputTextElement treatmentEndDateDay { get; set; }

//        [Find(By: By.Id, Using: "treatmentEndDate-month-input")]
//        public virtual IInputTextElement treatmentEndDateMonth { get; set; }

//        [Find(By: By.Id, Using: "treatmentEndDate-year-input")]
//        public virtual IInputTextElement treatmentEndDateYear { get; set; }

//        [Find(By: By.CssSelector, Using: "#submit-client-is-deceased-form > span")]
//        public virtual IPageElement ClientdeceasedHeading { get; set; }

//        [Find(By: By.Id, Using: "deathOfDeath-hint")]
//        public virtual IPageElement ClientdeceasedDatehint { get; set; }

//        [Find(By: By.Id, Using: "deathOfDeath-day-input")]
//        public virtual IPageElement ClientdeceasedDateDay { get; set; }

//        [Find(By: By.Id, Using: "deathOfDeath-month-input")]
//        public virtual IPageElement ClientdeceasedDateMonth { get; set; }

//        [Find(By: By.Id, Using: "deathOfDeath-year-input")]
//        public virtual IPageElement ClientdeceasedDateYear { get; set; }

//        [Find(By: By.Id, Using: "error-list")]
//        public virtual IPageElement ErrorSummaryList { get; set; }

//        [Find(By: By.Id, Using: "submit-stopped-treatment-sub-question-error-list")]
//        public virtual IPageElement StopTreatmentErrorList { get; set; }

//        [Find(By: By.Id, Using: "date-of-death-error-list")]
//        public virtual IPageElement DeathdateErrorList { get; set; }

//        [Find(By: By.Id, Using: "submit-deceased")]
//        public virtual IPageElement submitdeceased { get; set; }

//        public BSSDebtorEndMentalHealthBreathingSpaceDecisionPage(IDriver driver)
//        {
//            Driver = driver;
//        }
//    }
//}