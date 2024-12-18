//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSMADebtorAccountDetailsPage
//    {
//        public IDriver Driver { get; }

//        public BSSMADebtorAccountDetailsPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Class, Using: "govuk-grid-column-one-half")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "home-navigation-home-link")]
//        public virtual IPageElement HomeLink { get; set; }

//        [Find(By: By.Id, Using: "new-client-account")]
//        public virtual IPageElement CreateBreathingSpaceLink { get; set; }

//        [Find(By: By.Id, Using: "search")]
//        public virtual IPageElement SearchForClientLink { get; set; }

//        [Find(By: By.Id, Using: "money-advisor-name")]
//        public virtual IPageElement MoneyAdvisorName { get; set; }

//        [Find(By: By.Id, Using: "money-advisor-member-name")]
//        public virtual IPageElement MoneyAdvisorMemberName { get; set; }

//        [Find(By: By.Id, Using: "sign-out")]
//        public virtual IPageElement SignOutLink { get; set; }

//        [Find(By: By.Id, Using: "account-header-status")]
//        public virtual IPageElement ActiveStatus { get; set; }

//        [Find(By: By.CssSelector, Using: "#account-header-status + strong")]
//        public virtual IPageElement BSType { get; set; }

//        [Find(By: By.Id, Using: "breathing-space-for-label")]
//        public virtual IPageElement BreathingSpaceForHeader { get; set; }

//        [Find(By: By.Id, Using: "account-header-name")]
//        public virtual IPageElement DebtorNameHeader { get; set; }

//        [Find(By: By.Id, Using: "account-time-difference")]
//        public virtual IPageElement BreathingSpaceDayNo { get; set; }

//        [Find(By: By.Id, Using: "account-header-start-and-end")]
//        public virtual IPageElement BSStartAndEndDate { get; set; }

//        [FindAll(By: By.Id, Using: "account-header-start-and-end")]
//        public virtual IPageElements InvisibleBSStartAndEndDate { get; set; }

//        [Find(By: By.Id, Using: "ma-add-debt")]
//        public virtual IButtonElement AddDebtButton { get; set; }

//        [FindAll(By: By.Id, Using: "ma-add-debt")]
//        public virtual IPageElements AddDebtBtn { get; set; }

//        [Find(By: By.Id, Using: "ma-end-breathing-space")]
//        public virtual IButtonElement EndBreathingSpaceButton { get; set; }

//        [Find(By: By.Id, Using: "tab_tasks")]
//        public virtual IButtonElement TasksTab { get; set; }

//        [FindAll(By: By.Id, Using: "tab_tasks")]
//        public virtual IPageElements InvisibleTasksTab { get; set; }

//        [Find(By: By.Id, Using: "inactive-account-debts-tab-heading")]
//        public virtual IPageElement DebtsTabAddNewDebtHeading { get; set; }

//        [Find(By: By.Id, Using: "tab_debts")]
//        public virtual IButtonElement DebtsTab { get; set; }

//        [Find(By: By.Id, Using: "ma-creditor-reported-msg-0")]
//        public virtual IButtonElement BannerDebt { get; set; }

//        [Find(By: By.Id, Using: "confirmation-banner")]
//        public virtual IButtonElement ConfirmationBanner { get; set; }

//        [Find(By: By.Id, Using: "account-review-confirmation-title")]
//        public virtual IButtonElement ConfirmationLabel { get; set; }

//        [Find(By: By.Id, Using: "account-review-confirmation")]
//        public virtual IButtonElement ConfirmationText { get; set; }

//        [Find(By: By.Id, Using: "tab_details")]
//        public virtual IButtonElement ClientDetailsTab { get; set; }

//        [Find(By: By.Id, Using: "ma-task-heading-client-eligibility-review-1")]
//        public virtual IPageElement ClientEligibilityHeading { get; set; }

//        [Find(By: By.Id, Using: "ma-task-debt-sold-heading-1")]
//        public virtual IPageElement SoldDebtHeading { get; set; }

//        [Find(By: By.Id, Using: "ma-task-action-debt-sold-1")]
//        public virtual IPageElement TransferDebtButton { get; set; }

//        [Find(By: By.Id, Using: "ma-task-todo-client-eligibility-review-1")]
//        public virtual IPageElement ClientEligibilityToDo { get; set; }

//        [Find(By: By.Id, Using: "ma-task-debt-sold-status-1")]
//        public virtual IPageElement SoldDebtToDo { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-proposed-new-creditor-name-0")]
//        public virtual IPageElement NewCreditor { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-debt-sold-tag-0")]
//        public virtual IPageElement DebtTabSoldDebtHeading { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-debt-sold-action-0")]
//        public virtual IPageElement TransferDebtLink { get; set; }

//        [Find(By: By.Id, Using: "ma-task-completed-client-eligible-after-review-1")]
//        public virtual IPageElement ClientEligibilityAfterReview { get; set; }

//        [Find(By: By.CssSelector, Using: "a[id^='ma-task-action-client-eligibility-review-']")]
//        public virtual IPageElement Reviewclienteligibilitybutton { get; set; }

//        [Find(By: By.Id, Using: "ma-task-heading-outcome-client-eligibility-review-1")]
//        public virtual IPageElement OutcomeHeading { get; set; }

//        [Find(By: By.CssSelector, Using: "#ma-task-heading-outcome-client-eligibility-review-1+P")]
//        public virtual IPageElement OutcomeValue { get; set; }

//        [Find(By: By.Id, Using: "ma-tasks-client-reviewed-view-details-action-1")]
//        public virtual IPageElement ClientreviewedLink { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-client-review-requested-tag-0")]
//        public virtual IPageElement DebttabclientreviewRequested { get; set; }

//        [Find(By: By.CssSelector, Using: "strong[id^='ma-debts-client-eligible-after-eligibility-review-tag-']")]
//        public virtual IPageElement DebttabclientreviewDone { get; set; }

//        [Find(By: By.CssSelector, Using: "a[id^='ma-debts-client-reviewed-view-details-action-']")]
//        public virtual IPageElement DebtTabClientreviewedLink { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-client-review-action-0")]
//        public virtual IPageElement Reviewtheclientlink { get; set; }

//        [Find(By: By.Id, Using: "account-review-confirmation-title")]
//        public virtual IPageElement BannerHeading { get; set; }

//        [Find(By: By.Id, Using: "account-review-confirmation")]
//        public virtual IPageElement BannerText { get; set; }

//        [Find(By: By.Id, Using: "ma-task-heading-1")]
//        public virtual IPageElement TaskHeading { get; set; }

//        [Find(By: By.CssSelector, Using: "#ma-task-heading-1 +p")]
//        public virtual IPageElement DebtType { get; set; }

//        [Find(By: By.CssSelector, Using: "#ma-task-debt-sold-heading-1 +P")]
//        public virtual IPageElement SoldDebtType { get; set; }

//        [Find(By: By.CssSelector, Using: ".app-task-list__item strong")]
//        public virtual IPageElement TaskDebtStatus { get; set; }

//        [Find(By: By.Id, Using: "debt-review-outcome-title")]
//        public virtual IPageElement DebtOutcomeHeading { get; set; }

//        [Find(By: By.Id, Using: "debt-review-outcome-msg")]
//        public virtual IPageElement DebtOutcomeValue { get; set; }

//        [Find(By: By.CssSelector, Using: "section#debts")]
//        public virtual IPageElement Debts { get; set; }

//        [Find(By: By.Id, Using: "debt-review-outcome-1")]
//        public virtual IPageElement ViewReviewDetailsLink { get; set; }

//        [Find(By: By.CssSelector, Using: "a[id ^= 'ma-task-action-debt-eligibility-review-']")]
//        public virtual IPageElement DebtReviewButton { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-required-msg-0")]
//        public virtual IPageElement DebtTabDebtHeading { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-action-0")]
//        public virtual IPageElement DebtTabDebtReviewLink { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-debt-type-0")]
//        public virtual IPageElement DebtTabDebtType { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-creditor-name-0")]
//        public virtual IPageElement DebtTabCreaditorName { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-debt-amount-0")]
//        public virtual IPageElement DebtTabAmount { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-ref-0")]
//        public virtual IPageElement DebtTabReference { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-date-0")]
//        public virtual IPageElement DebtTabreviewdate { get; set; }

//        [Find(By: By.Id, Using: "tab_removed-debts")]
//        public virtual IPageElement RemovedDebtsTab { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-completed-msg-removed-debts-0")]
//        public virtual IPageElement RDTabDebtHeader { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-completed-msg-0")]
//        public virtual IPageElement DebtTabDebtHeader { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-debt-type-removed-debts-0")]
//        public virtual IPageElement RDTabDebtType { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-creditor-name-removed-debts-0")]
//        public virtual IPageElement RDTabDebtCreditor { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-debt-amount-removed-debts-0")]
//        public virtual IPageElement RDTabDebtAmount { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-ref-removed-debts-0")]
//        public virtual IPageElement RDTabDebtRef { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-review-date-removed-debts-0")]
//        public virtual IPageElement RDTabDebtEntered { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-removed-on-removed-debts-0")]
//        public virtual IPageElement RDTabDebtRemoved { get; set; }

//        [Find(By: By.Id, Using: "ma-remove-debt-review-detail-link-0")]
//        public virtual IPageElement ViewDetailsLink { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-view-review-detail-0")]
//        public virtual IPageElement DebtTabViewDetailsLink { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-header")]
//        public virtual IPageElement DebtTabDebtLabel { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-client-review-task-0")]
//        public virtual IPageElement ClientReview1 { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-debt-review-task-0")]
//        public virtual IPageElement DebtEligibilityTask { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-debt-review-task-1")]
//        public virtual IPageElement DebtEligibilityTask1 { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-client-review-task-1")]
//        public virtual IPageElement ClientReview2 { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-debt-update-details-0")]
//        public virtual IPageElement UpdateDebtDetailsLink { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-debt-remove-0")]
//        public virtual IPageElement RemoveDebtLink { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-debt-sold-action-0")]
//        public virtual IPageElement CreditorSoldDebt { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-sold-msg-0")]
//        public virtual IPageElement DebtTransferredBlueLabel { get; set; }

//        [Find(By: By.Id, Using: "ma-debts-report-creditor-0")]
//        public virtual IPageElement ReportCreditor { get; set; }

//        [Find(By: By.Id, Using: "ma-debt-sold-msg-0")]
//        public virtual IPageElement DebtTabSoldDebtMsg { get; set; }

//        //Ended breathing space

//        [Find(By: By.CssSelector, Using: "#content div.blue-border-panel.govuk-body-m")]
//        public virtual IPageElement EndBreathingspaceDetails { get; set; }

//        [Find(By: By.CssSelector, Using: "#account-time-difference strong")]
//        public virtual IPageElement BSRandayslabel { get; set; }

//        [Find(By: By.CssSelector, Using: "#account-header-name + span")]
//        public virtual IPageElement BSReference { get; set; }

//        [Find(By: By.Id, Using: "debtor-details-save")]
//        public virtual IPageElement SaveAndContinue { get; set; }

//        //Client details tab elements

//        [Find(By: By.Id, Using: "ma-details-header")]
//        public virtual IPageElement Clientdetailsheader { get; set; }

//        [Find(By: By.Id, Using: "debtor-personal-detail-heading")]
//        public virtual IPageElement PersonalDetailsheader { get; set; }

//        [Find(By: By.Id, Using: "debtor-personal-detail-name-heading")]
//        public virtual IPageElement DebtorNamelabel { get; set; }

//        [Find(By: By.Id, Using: "debtor-confirm-name")]
//        public virtual IPageElement DebtorName { get; set; }

//        [Find(By: By.Id, Using: "debtor-confirm-change-name")]
//        public virtual ILinkElement DebtorNameChangeLink { get; set; }

//        [Find(By: By.Id, Using: "debtor-confirm-dob")]
//        public virtual IPageElement Debtordob { get; set; }

//        [Find(By: By.Id, Using: "debtor-confirm-change-name")]
//        public virtual ILinkElement DebtordobChangeLink { get; set; }

//        [Find(By: By.Id, Using: "debtor-personal-detail-prev-name-heading-1")]
//        public virtual ILinkElement PreviousNameHeading { get; set; }

//        [Find(By: By.Id, Using: "debtor-personal-detail-prev-name-1")]
//        public virtual ILinkElement PreviousNameValue { get; set; }

//        [Find(By: By.Id, Using: "debtor-personal-detail-prev-name-chng-1")]
//        public virtual ILinkElement ChangePreviousname { get; set; }

//        [Find(By: By.Id, Using: "debtor-personal-detail-prev-name-del-1")]
//        public virtual ILinkElement DeletePreviousname { get; set; }

//        [FindAll(By: By.Id, Using: "debtor-personal-detail-prev-name-del-1")]
//        public virtual IPageElements DeletePreviousnameRemoved { get; set; }

//        [Find(By: By.Id, Using: "debtor-details-add-prev-name")]
//        public virtual ILinkElement DebtorAddPreviousNameLink { get; set; }

//        [Find(By: By.Id, Using: "ma-details-addresses-header")]
//        public virtual ILinkElement AddressesHeading { get; set; }

//        [Find(By: By.Id, Using: "debtor-details-address--header")]
//        public virtual ILinkElement AddressLabel { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-curr-address1")]
//        public virtual IPageElement CurrentAddress1 { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-curr-address2")]
//        public virtual IPageElement CurrentAddress2 { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-curr-towncity")]
//        public virtual IPageElement TownCity { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-curr-county")]
//        public virtual IPageElement County { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-curr-postcode")]
//        public virtual IPageElement Postcode { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-hide-curr-add")]
//        public virtual ILinkElement HideDebtorCurrentAddressLink { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-chng-curr-add")]
//        public virtual ILinkElement ChangeDebtorCurrentAddressLink { get; set; }

//        [Find(By: By.Id, Using: "debtor-details-prev-add-header-1")]
//        public virtual ILinkElement PreviousAddressesLabel { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-prev-address1-1")]
//        public virtual IPageElement PreviousAddress1 { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-prev-address2-1")]
//        public virtual IPageElement PreviousAddress2 { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-prev-towncity-1")]
//        public virtual IPageElement PreviousTownCity { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-prev-county-1")]
//        public virtual IPageElement PreviousCounty { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-prev-postcode-1")]
//        public virtual IPageElement previousPostcode { get; set; }

//        [Find(By: By.Id, Using: "debtor-address-move-in-txt")]
//        public virtual IPageElement PreviousMoveIn { get; set; }

//        [Find(By: By.Id, Using: "debtor-address-move-out-txt")]
//        public virtual IPageElement previousMoveout { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-chng-prev-add-1")]
//        public virtual ILinkElement ChangeDebtorPreviousAddressLink { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-del-prev-add-1")]
//        public virtual ILinkElement DeleteDebtorPreviousAddressLink { get; set; }

//        [FindAll(By: By.Id, Using: "debtor-summary-del-prev-add-1")]
//        public virtual IPageElements DeleteDebtorPreviousAddressRemoved { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-add-prev-add")]
//        public virtual ILinkElement DebtorAddPreviousAddressLink { get; set; }

//        [Find(By: By.Id, Using: "debtor-details-notification-header")]
//        public virtual ILinkElement Notificationpref { get; set; }

//        [Find(By: By.Id, Using: "debtor-details-notification-method-header")]
//        public virtual IPageElement NotificationMethodlabel { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-notification-method-preference")]
//        public virtual IPageElement Debtornotificationmethod { get; set; }

//        [Find(By: By.Id, Using: "debtor-details-notification-preference-chng")]
//        public virtual ILinkElement ChangeDebtornotificationmethod { get; set; }

//        [Find(By: By.Id, Using: "debtor-details-notification-email-header")]
//        public virtual IPageElement NotificationEmailLabel { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-notification-method-email")]
//        public virtual IPageElement Debtornotificationemail { get; set; }

//        [Find(By: By.Id, Using: "debtor-details-notification-email-chng")]
//        public virtual ILinkElement ChangeDebtornotificationemail { get; set; }

//        [Find(By: By.Id, Using: "ma-details-business-header")]
//        public virtual IPageElement DebtorBusinessHeading { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-add-business")]
//        public virtual ILinkElement DebtorAddBusinessAddressLink { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-business-address-lbl-1")]
//        public virtual IPageElement DebtorBusinessName { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-business-address-1")]
//        public virtual IPageElement BusinessAddress { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-chng-business-address-1")]
//        public virtual ILinkElement ChangeBusinessAddressLink { get; set; }

//        [Find(By: By.Id, Using: "debtor-summary-del-business-address-1")]
//        public virtual ILinkElement DeleteBusinessAddressLink { get; set; }

//        [FindAll(By: By.Id, Using: "debtor-summary-del-business-address-1")]
//        public virtual IPageElements DeleteBusinessAddressLinkRemoved { get; set; }

//        //nonowning MoneyAdviser 

//        [Find(By: By.Id, Using: "not-owning-organization-client-details-header")]
//        public virtual ILinkElement NonOwnclientdetailsheader { get; set; }

//        [Find(By: By.Id, Using: "not-owning-organization-client-details-client")]
//        public virtual ILinkElement NonOwnclientName { get; set; }

//        [Find(By: By.Id, Using: "not-owning-organization-client-details-date-of-birth")]
//        public virtual IPageElement NonOwnclientDob { get; set; }

//        [Find(By: By.Id, Using: "not-owning-organization-client-details-address")]
//        public virtual IPageElement NonOwnclientaddress { get; set; }

//        [FindAll(By: By.Id, Using: "not-owning-organization-client-details-address")]
//        public virtual IPageElements NonOwnclientaddressHidden { get; set; }

//        [Find(By: By.Id, Using: "not-owning-organization-client-details-business-name")]
//        public virtual IPageElement NonOwnclientBusinessName { get; set; }

//        [Find(By: By.Id, Using: "not-owning-organization-client-details-business-address")]
//        public virtual IPageElement NonOwnclientBusinessAddress { get; set; }

//        [FindAll(By: By.Id, Using: "not-owning-organization-client-details-business-address")]
//        public virtual IPageElements NonOwnclientBusinessAddressHidden { get; set; }

//        [Find(By: By.Id, Using: "not-owning-organization-ma-organisation-details-header")]
//        public virtual IPageElement NonOwnMAheading { get; set; }

//        [Find(By: By.Id, Using: "not-owning-organization-ma-organisation-details-name")]
//        public virtual IPageElement NonOwnMAName { get; set; }

//        [Find(By: By.Id, Using: "not-owning-organization-ma-organisation-details-email")]
//        public virtual IPageElement NonOwnMAemail { get; set; }

//        [Find(By: By.Id, Using: "not-owning-organization-ma-organisation-details-telephone")]
//        public virtual IPageElement NonOwnMATele { get; set; }

//        [Find(By: By.Id, Using: "not-owning-organization-transfer-header")]
//        public virtual IPageElement NonOwnTransferheading { get; set; }

//        [Find(By: By.Id, Using: "not-owning-organization-transfer-message")]
//        public virtual IPageElement NonOwnTransfermsg { get; set; }

//        [Find(By: By.Id, Using: "not-owning-organization-ask-for-a-transfer")]
//        public virtual IPageElement NonOwnTransferbtn { get; set; }

//        [Find(By: By.Id, Using: "account-review-confirmation-title")]
//        public virtual IPageElement ReviewConfirmationBannerHeading { get; set; }

//        [Find(By: By.Id, Using: "account-review-confirmation")]
//        public virtual IPageElement ReviewConfirmationBannerText { get; set; }

//        [Find(By: By.CssSelector, Using: "a[id ^='ma-task-action-debt-eligibility-review-']")]
//        public virtual IPageElement ReviewTheDebtButton { get; set; }

//        [Find(By: By.Id, Using: "not-owning-tasks-sent-to-money-adviser-heading")]
//        public virtual IPageElement NonOwningMAtransferHeading { get; set; }

//        [Find(By: By.Id, Using: "not-owning-tasks-sent-to-money-adviser-tag")]
//        public virtual IPageElement NonOwningMAtransferlable { get; set; }

//        [Find(By: By.Id, Using: "not-owning-tasks-sent-to-money-adviser-call-to-action")]
//        public virtual IPageElement NonOwningMAViewTransferlink { get; set; }

//        // Proposed debts ids

//        [Find(By: By.CssSelector, Using: "strong[id^='ma-task-proposed-debt-status-']")]
//        public virtual IPageElement ProposedDebtStatus { get; set; }

//        [Find(By: By.CssSelector, Using: "h3[id^='ma-task-proposed-debt-heading-']")]
//        public virtual IPageElement ProposedDebtHeading { get; set; }

//        [Find(By: By.CssSelector, Using: "p[id^='ma-task-proposed-debt-debt-type-']")]
//        public virtual IPageElement ProposedDebtType { get; set; }

//        [Find(By: By.CssSelector, Using: "a[id^='ma-task-review-proposed-debt-']")]
//        public virtual IPageElement ProposedDebtTaskBtn { get; set; }

//        [Find(By: By.CssSelector, Using: "h3[id^='ma-task-completed-accepted-proposed-debt-heading-']")]
//        public virtual IPageElement ProposedDebtCreditorName { get; set; }

//        [Find(By: By.CssSelector, Using: "strong[id^='ma-task-completed-accepted-proposed-debt-']")]
//        public virtual IPageElement ProposedOutcomeDebtHeading { get; set; }

//        [Find(By: By.CssSelector, Using: "strong[id^='ma-task-completed-rejected-proposed-debt-']")]
//        public virtual IPageElement ProposedDebtRejectedHeading { get; set; }

//        [Find(By: By.CssSelector, Using: "h3[id^='ma-task-completed-rejected-proposed-debt-heading-']")]
//        public virtual IPageElement ProposedDebtRejectedTitle { get; set; }

//        [Find(By: By.CssSelector, Using: "p[id^='ma-task-completed-accepted-proposed-debt-debt-type-']")]
//        public virtual IPageElement ProposedOutcomeDebtType { get; set; }

//        [Find(By: By.CssSelector, Using: "p[id^='ma-task-completed-rejected-proposed-debt-debt-type-']")]
//        public virtual IPageElement ProposedDebtRejectedDebtType { get; set; }

//        [Find(By: By.CssSelector, Using: "h3[id^='ma-task-completed-accepted-proposed-debt-outcome-heading-']")]
//        public virtual IPageElement ProposedDebtoutcomeHeading { get; set; }

//        [Find(By: By.CssSelector, Using: "p[id^='ma-task-completed-rejected-proposed-debt-outcome-description-']")]
//        public virtual IPageElement ProposedDebtoutcomeHeadingReason { get; set; }

//        [Find(By: By.CssSelector, Using: "p[id^='ma-task-completed-accepted-proposed-debt-outcome-description-']")]
//        public virtual IPageElement ProposeddebtAdded { get; set; }

//        [Find(By: By.CssSelector, Using: "a[id^='ma-task-completed-accepted-proposed-debt-action-']")]
//        public virtual IPageElement ProposedDebtAcceptedLink { get; set; }

//        [Find(By: By.CssSelector, Using: "a[id^='ma-task-completed-rejected-proposed-debt-action-']")]
//        public virtual IPageElement ProposedDebtRejectedLink { get; set; }

//        [FindAll(By: By.CssSelector, Using: "section#debts div.govuk-grid-row")]
//        public virtual IPageElements debtsCount { get; set; }

//        [Find(By: By.Id, Using: "ma-task-review-transfer-debtor-heading")]
//        public virtual IPageElement TransferDebtorHeading { get; set; }

//        [Find(By: By.Id, Using: "ma-task-todo-debtor-transfer")]
//        public virtual IPageElement TransferDebtorTodo { get; set; }

//        [Find(By: By.Id, Using: "ma-task-review-transfer-debtor-call-to-action")]
//        public virtual IPageElement TransferDebtorActionBtn { get; set; }

//        [Find(By: By.Id, Using: "ma-task-heading-debtor-transfer")]
//        public virtual IPageElement MoneyAdviserTransferHeading { get; set; }

//        [Find(By: By.Id, Using: "ma-task-todo-debtor-transfer")]
//        public virtual IPageElement MoneyAdviserTransferTodo { get; set; }

//        [Find(By: By.Id, Using: "ma-task-completed-debtor-transfer")]
//        public virtual IPageElement MoneyAdviserTransferComplete { get; set; }

//        [Find(By: By.Id, Using: "ma-task-completed-debtor-transfer-link")]
//        public virtual IPageElement ViewTransferLink{ get; set; }

//        [Find(By: By.Id, Using: "ma-task-action-debtor-transfer")]
//        public virtual IPageElement MoneyAdviserTransferActionBtn { get; set; }

//        [Find(By: By.CssSelector, Using: "a[id ^= 'ma-debts-client-reviewed-view-details-action-']")]
//        public virtual IPageElement DebtTabeReviewClientDetailsLink { get; set; }

//        [Find(By: By.CssSelector, Using: "a[id ^= 'ma-debt-view-review-detail-']")]
//        public virtual IPageElement DebtTabeViewReviewDetailsLink { get; set; }

//        [Find(By: By.CssSelector, Using: "a[id ^= 'ma-remove-debt-removal-reason-link-']")]
//        public virtual IPageElement DebtTabeReasonDebtRemovedLink { get; set; }
//    }
//}