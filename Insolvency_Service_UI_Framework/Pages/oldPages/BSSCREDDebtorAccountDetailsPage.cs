//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSCREDDebtorAccountDetailsPage
//    {
//        public IDriver Driver { get; }

//        public BSSCREDDebtorAccountDetailsPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "home-navigation-home-link")]
//        public virtual IPageElement HomeLink { get; set; }

//        [Find(By: By.Id, Using: "search-account")]
//        public virtual IPageElement SearchAccountLink { get; set; }

//        [Find(By: By.Id, Using: "govuk-header-link-sign-out")]
//        public virtual IPageElement SignOutLink { get; set; }

//        [Find(By: By.Id, Using: "creditor-name")]
//        public virtual IPageElement CreditorName { get; set; }

//        [Find(By: By.Id, Using: "creditor-member-name")]
//        public virtual IPageElement CreditorMemberName { get; set; }

//        [Find(By: By.Id, Using: "account-header-status")]
//        public virtual IPageElement ActiveLabel { get; set; }

//        [Find(By: By.Id, Using: "home-navigation-organisation-name")]
//        public virtual IPageElement CreditorOrgName { get; set; }

//        [Find(By: By.Id, Using: "home-navigation-user-name")]
//        public virtual IPageElement CreditorUserName { get; set; }

//        [Find(By: By.Id, Using: "sign-out")]
//        public virtual IPageElement HomePageSignOut { get; set; }

//        [Find(By: By.Id, Using: "account-time-difference")]
//        public virtual IPageElement DayNumber { get; set; }

//        [Find(By: By.Id, Using: "account-header-start-and-end")]
//        public virtual IPageElement StartAndEndDate { get; set; }

//        [Find(By: By.Class, Using: "app-task-list")]
//        public virtual IPageElement Debts { get; set; }

//        [FindAll(By: By.CssSelector, Using: ".app-task-list .app-task-list__item")]
//        public virtual IPageElements Debtcount { get; set; }
        

//        [Find(By: By.Id, Using: "account-header-name")]
//        public virtual IPageElement DebtorAccountName { get; set; }

//        [Find(By: By.Id, Using: "breathing-space-for-label")]
//        public virtual IPageElement BreathingSpaceTitle { get; set; }

//        [Find(By: By.Id, Using: "breathing-space-for-label")]
//        public virtual IPageElement AccountNameRemoved { get; set; }

//        [Find(By: By.Class, Using: "govuk-body-l")]
//        public virtual IPageElement EnteredClientIntoBreathingSpace { get; set; }

//        [Find(By: By.Id, Using: "ma-org-name-lead")]
//        public virtual IButtonElement MoneyAdviceOrganisationHeader { get; set; }

//        [Find(By: By.Id, Using: "creditor-ma-details-telephone")]
//        public virtual IPageElement MATelephone { get; set; }

//        [Find(By: By.Id, Using: "account-header-start-and-end")]
//        public virtual IPageElement StartsLabel { get; set; }

//        [Find(By: By.Id, Using: "creditor-ma-details-email")]
//        public virtual IPageElement MAEmail { get; set; }

//        [Find(By: By.Id, Using: "creditor-ma-details-name")]
//        public virtual IPageElement MAName { get; set; }

//        [Find(By: By.Id, Using: "creditor-tasks")]
//        public virtual IButtonElement TasksHeader { get; set; }

//        [Find(By: By.CssSelector, Using: ".govuk-heading-s:nth-of-type(1)")]
//        public virtual IPageElement ChooseAnOptionHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-stop-action-0")]
//        public virtual IButtonElement RecoveryStoppedButton { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-request-review-0")]
//        public virtual IButtonElement RequestDebtReviewButton { get; set; }

//        [Find(By: By.Id, Using: "creditor-other-actions")]
//        public virtual IPageElement OtherActionsHeader { get; set; }

//        [Find(By: By.Id, Using: "creditor-client-details")]
//        public virtual IPageElement ClientDetailsHeader { get; set; }

//        [Find(By: By.Id, Using: "creditor-ma-details-header")]
//        public virtual IPageElement MoneyAdviceOrganisationDetailsHeading { get; set; }

//        [Find(By: By.Id, Using: "add-debt")]
//        public virtual IButtonElement AddDebtsButton { get; set; }

//        [FindAll(By: By.Id, Using: "request-debtor-review")]
//        public virtual IPageElements RequestClientReviewButtoncheck { get; set; }

//        [Find(By: By.Id, Using: "request-debtor-review")]
//        public virtual IButtonElement RequestClientReviewButton { get; set; }
        
//        [Find(By: By.Id, Using: "creditor-debtor-name")]
//        public virtual IPageElement debtorname { get; set; }

//        [Find(By: By.Id, Using: "creditor-debtor-dob")]
//        public virtual IPageElement debtordob { get; set; }
        
//        [Find(By: By.Id, Using: "creditor-debtor-current-address")]
//        public virtual IPageElement debtorcurrentaddress { get; set; }

//        [Find(By: By.Id, Using: "creditor-debtor-business-name-1")]
//        public virtual IPageElement debtorbusinessname { get; set; }

//        [Find(By: By.Id, Using: "creditor-debtor-business-address-1")]
//        public virtual IPageElement debtorbusinessaddress1 { get; set; }

//        [Find(By: By.CssSelector, Using: "h2#creditor-ma-details+ul")]
//        public virtual IPageElement MoneyadvicerDetails { get; set; }

//        [Find(By: By.Id, Using: "creditor-debtor-previous-address-1")]
//        public virtual IPageElement debtorpreviousaddress1 { get; set; }

//        [Find(By: By.Id, Using: "creditor-debtor-previous-address-move-in@i")]
//        public virtual IPageElement debtorpreviousaddressMoveIn { get; set; }

//        [Find(By: By.Id, Using: "creditor-debtor-previous-address-move-out@i")]
//        public virtual IPageElement debtorpreviousaddressMoveOut { get; set; }

//        [Find(By: By.Id, Using: "debt-task-header-0")]
//        public virtual IPageElement TasksInsideHeader { get; set; }

//        [Find(By: By.Id, Using: "debt-task-tag-0")]
//        public virtual IPageElement TaskTodo { get; set; }

//        [Find(By: By.Id, Using: "debt-task-subheader-0")]
//        public virtual IPageElement OutcomeHeader { get; set; }

//        [Find(By: By.CssSelector, Using: "#debt-task-subheader-0 +p")]
//        public virtual IPageElement OutcomeText { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-request-review-0")]
//        public virtual IPageElement debtRequestReview { get; set; }

//        [FindAll(By: By.Id, Using: "debt-task-debt-request-review-0")]
//        public virtual IPageElements debtRequestReviewCheck { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-type-0")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-amount-0")]
//        public virtual IPageElement DebtAmount { get; set; }

//        [Find(By: By.Id, Using: "debt-view-details-0")]
//        public virtual IPageElement ViewReviewDetailsButton { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-nin-0")]
//        public virtual IPageElement Debtnin { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-ref-0")]
//        public virtual IPageElement DebtReference{ get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-createdon-0")]
//        public virtual IPageElement DebtCreatedon { get; set; }

//        [Find(By: By.Id, Using: "debt-task-breathingspace-end-0")]
//        public virtual IPageElement DebtbreathingspaceEnd { get; set; }

//        [Find(By: By.Id, Using: "home-navigation-home-link")]
//        public virtual IPageElement HomePageNavHomeLink { get; set; }

//        [Find(By: By.Id, Using: "sold-debt-view-details-0")]
//        public virtual IPageElement ViewReviewDetailsLink { get; set; }

//        [Find(By: By.Id, Using: "debt-view-details-0")]
//        public virtual IPageElement ViewReviewDetailsLinkDebtEligibility { get; set; }        

//        [Find(By: By.Id, Using: "debt-task-debt-stop-action-0")]
//        public virtual IPageElement DebtStopAction { get; set; }

//        [Find(By: By.Id, Using: "sold-debt-view-details-0")]
//        public virtual IPageElement DebtViewDetailsLink { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-sold-0")]
//        public virtual IPageElement DebtSold { get; set; }

//        [FindAll(By: By.Id, Using: "debt-task-debt-sold-0")]
//        public virtual IPageElements DebtSoldButton { get; set; }

//        [Find(By: By.Id, Using: "account-review-confirmation-title")]
//        public virtual IPageElement ConfirmationBanner { get; set; }

//        [Find(By: By.Id, Using: "account-review-confirmation")]
//        public virtual IPageElement ConfirmationBannerText { get; set; }

//        [Find(By: By.Id, Using: "ma-name")]
//        public virtual IPageElement MAOrganisationName { get; set; }

//        [Find(By: By.Id, Using: "creditor-org")]
//        public virtual IPageElement HomePageCreditorOrg { get; set; }

//        [Find(By: By.Id, Using: "debt-task-tag-1")]
//        public virtual IPageElement TaskTag1 { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-type-1")]
//        public virtual IPageElement DebtType1 { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-amount-1")]
//        public virtual IPageElement DebtAmount1 { get; set; }

//        [Find(By: By.Id, Using: "debt-task-debt-ref-1")]
//        public virtual IPageElement Debtref1 { get; set; }

//        [Find(By: By.CssSelector, Using: "a[id^='view-proposed-debt-details-']")]
//        public virtual IPageElement ViewProposedDebtLink { get; set; }

//        [Find(By: By.Id, Using: "view-proposed-debt-details-0")]
//        public virtual IPageElement ClickViewProposedDebtDetailsLink { get; set; }

//        [Find(By: By.Id, Using: "view-proposed-debt-details-heading")]
//        public virtual IPageElement DebtDetailsHeading { get; set; }

//        [Find(By: By.Id, Using: "view-proposed-debt-details-subheading")]
//        public virtual IPageElement DebtDetailsSubHeading { get; set; }

//        [Find(By: By.Id, Using: "ma-org")]
//        public virtual IPageElement MAOrg { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-call-to-action")]
//        public virtual IPageElement ClientEligibilityReviewButton { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-header")]
//        public virtual IPageElement ClientEligibilityReviewHeader { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-status")]
//        public virtual IPageElement ClientEligibilityReviewStatus { get; set; }

//        [Find(By: By.Id, Using: "client-eligibility-review-outcome")]
//        public virtual IPageElement ClientEligibilityReviewOutcome { get; set; }

//    }
//}