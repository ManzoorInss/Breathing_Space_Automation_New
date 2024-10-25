using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Bankruptcy_Automation_Framework.Pages;
using Bankruptcy_Automation_Framework.Utilities;
using OpenQA.Selenium;
using System;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Security;
using TechTalk.SpecFlow;

namespace Bankruptcy_Automation_Framework.StepDefinitions
{
    [Binding]
    public class EndToEndJourneyStepDefinitions
    {
        private IWebDriver driver;
        public string applicationNumber = string.Empty;
        HomePage homePage;
        CompletingYourApplicationPage completingYourApplicationPage;
        CreateYourAccountPage createYourAccountPage;
        SecurityQuestionsPage securityQuestionsPage;
        CheckYourEmailPage checkYourEmailPage;
        MailTrapPage mailTrapPage;
        SignIntoExistingApplicationPage signIntoExistingApplicationPage;
        ContinueToApplicationPage continueToApplicationPage;
        ApplicationOverviewPage applicationOverviewPage;
        AddPersonPage addPersonPage;
        PersonalDetailsPage personalDetailsPage;
        PersonalDetails2Page personalDetails2Page;
        OtherNameOrAliasPage otherNameOrAliasPage;
        ContactDetailsPage contactDetailsPage;
        ResidencyDetailsPage residencyDetailsPage;
        YourHouseholdPage yourHouseholdPage;
        AddressHistoryPage addressHistoryPage;
        DependantsDontLiveWithMePage dependantsDontLiveWithMePage;
        DependantDetailsPage dependantDetailsPage;
        PersonalDetailsSummaryPage personalDetailsSummaryPage;
        EmploymentSummaryPage employmentSummaryPage;
        YourStatusPage yourStatusPage;
        BankAccountsAndSavingsPage bankAccountsAndSavingsPage;
        AssetsPage assetsPage;
        OtherItemsPage otherItemsPage;
        SoldTransferredGiftedAssetsPage soldTransferredGiftedAssetsPage;
        MoneyYouOwePage moneyYouOwePage;
        CreditorsAddressPage creditorsAddressPage;
        AmountYouOwePage amountYouOwePage;
        ReasonForDebtPage reasonForDebtPage;
        ActionsTakenPage actionsTakenPage;
        MoneyYouOweSummaryPage moneyYouOweSummaryPage;
        IncomeAndExpensesPage incomeAndExpensesPage;
        LegalProceedingsPage legalProceedingsPage;
        DebtHistoryOverviewPage debtHistoryOverviewPage;
        DebtHistoryPage debtHistoryPage;
        MakeFeePaymentPage makeFeePaymentPage;
        WorldPayPage worldPayPage;
        PaymentAcknowledgementPage paymentAcknowledgementPage;
        ContinueToSubmitPage continueToSubmitPage;
        SubmitApplicationPage submitApplicationPage;
        ApplicationSubmittedPage applicationSubmittedPage;
        AdminLandingPage adminLandingPage;
        AdminLoginPage adminLoginPage;
        AdjudicatorLoginPage adjudicatorLoginPage;

        public EndToEndJourneyStepDefinitions(IWebDriver driver, HomePage homePage, CompletingYourApplicationPage completingYourApplicationPage, CreateYourAccountPage createYourAccountPage, SecurityQuestionsPage securityQuestionsPage, CheckYourEmailPage checkYourEmailPage, MailTrapPage mailTrapPage, SignIntoExistingApplicationPage signIntoExistingApplicationPage, ContinueToApplicationPage continueToApplicationPage, ApplicationOverviewPage applicationOverviewPage, PersonalDetailsPage personalDetailsPage, PersonalDetails2Page personalDetails2Page, OtherNameOrAliasPage otherNameOrAliasPage, ContactDetailsPage contactDetailsPage, ResidencyDetailsPage residencyDetailsPage, YourHouseholdPage yourHouseholdPage, AddressHistoryPage addressHistoryPage, DependantsDontLiveWithMePage dependantsDontLiveWithMePage, PersonalDetailsSummaryPage personalDetailsSummaryPage, EmploymentSummaryPage employmentSummaryPage, YourStatusPage yourStatusPage, BankAccountsAndSavingsPage bankAccountsAndSavingsPage, AssetsPage assetsPage, OtherItemsPage otherItemsPage, SoldTransferredGiftedAssetsPage soldTransferredGiftedAssetsPage, MoneyYouOwePage moneyYouOwePage, CreditorsAddressPage creditorsAddressPage, AmountYouOwePage amountYouOwePage, ReasonForDebtPage reasonForDebtPage, ActionsTakenPage actionsTakenPage, MoneyYouOweSummaryPage moneyYouOweSummaryPage, IncomeAndExpensesPage incomeAndExpensesPage, LegalProceedingsPage legalProceedingsPage, DebtHistoryOverviewPage debtHistoryOverviewPage, DebtHistoryPage debtHistoryPage, MakeFeePaymentPage makeFeePaymentPage, WorldPayPage worldPayPage, PaymentAcknowledgementPage paymentAcknowledgementPage, ContinueToSubmitPage continueToSubmitPage, SubmitApplicationPage submitApplicationPage, ApplicationSubmittedPage applicationSubmittedPage, AdminLandingPage adminLandingPage, AdminLoginPage adminLoginPage, AdjudicatorLoginPage adjudicatorLoginPage)

        {
            this.driver = driver;
            this.homePage = homePage;
            this.completingYourApplicationPage = completingYourApplicationPage;
            this.createYourAccountPage = createYourAccountPage;
            this.securityQuestionsPage = securityQuestionsPage;
            this.checkYourEmailPage = checkYourEmailPage;
            this.mailTrapPage = mailTrapPage;
            this.signIntoExistingApplicationPage = signIntoExistingApplicationPage;
            this.continueToApplicationPage = continueToApplicationPage;
            this.applicationOverviewPage = applicationOverviewPage;
            this.addPersonPage = addPersonPage;
            this.personalDetailsPage = personalDetailsPage;
            this.personalDetails2Page = personalDetails2Page;
            this.otherNameOrAliasPage = otherNameOrAliasPage;
            this.contactDetailsPage = contactDetailsPage;
            this.residencyDetailsPage = residencyDetailsPage;
            this.yourHouseholdPage = yourHouseholdPage;
            this.addressHistoryPage = addressHistoryPage;
            this.dependantsDontLiveWithMePage = dependantsDontLiveWithMePage;
            this.dependantDetailsPage = dependantDetailsPage; 
            this.personalDetailsSummaryPage = personalDetailsSummaryPage;
            this.employmentSummaryPage = employmentSummaryPage;
            this.yourStatusPage = yourStatusPage;
            this.bankAccountsAndSavingsPage = bankAccountsAndSavingsPage;
            this.assetsPage = assetsPage;
            this.otherItemsPage = otherItemsPage;
            this.soldTransferredGiftedAssetsPage = soldTransferredGiftedAssetsPage;
            this.moneyYouOwePage = moneyYouOwePage;
            this.creditorsAddressPage = creditorsAddressPage;
            this.amountYouOwePage = amountYouOwePage;
            this.reasonForDebtPage = reasonForDebtPage;
            this.actionsTakenPage = actionsTakenPage;
            this.moneyYouOweSummaryPage = moneyYouOweSummaryPage;
            this.incomeAndExpensesPage = incomeAndExpensesPage;
            this.legalProceedingsPage = legalProceedingsPage;
            this.debtHistoryOverviewPage = debtHistoryOverviewPage;
            this.debtHistoryPage = debtHistoryPage;
            this.makeFeePaymentPage = makeFeePaymentPage;
            this.worldPayPage = worldPayPage;
            this.paymentAcknowledgementPage = paymentAcknowledgementPage;
            this.continueToSubmitPage = continueToSubmitPage;
            this.submitApplicationPage = submitApplicationPage;
            this.applicationSubmittedPage = applicationSubmittedPage;
            this.adminLandingPage = adminLandingPage;
            this.adminLoginPage = adminLoginPage;
            this.adjudicatorLoginPage = adjudicatorLoginPage;
        }

        [Given(@"I open the ODS BKT Homepage")]
        public void GivenIOpenTheODSBKTHomepage()
        {
            driver.Navigate().GoToUrl(ConfigUtil.PortalBaseUrl);
        }

        #region Account Creation
        #region Quick Route

        [When(@"I create a new account using the email '([^']*)'")]
        public void WhenICreateANewAccountUsingTheEmail(string p0)
        {
            homePage.CreateMyAccountButton.Click();
            completingYourApplicationPage.ContinueButton.Click();
            createYourAccountPage.FirstNameInputField.SendKeys("Happy");
            createYourAccountPage.LastNameInputField.SendKeys("Path");
            createYourAccountPage.DateofBirth_DayField.SendKeys("01");
            createYourAccountPage.DateofBirth_MonthField.SendKeys("01");
            createYourAccountPage.DateofBirth_YearField.SendKeys(DateTime.Now.AddYears(-40).Year.ToString());
            createYourAccountPage.EmailField.SendKeys(p0);
            createYourAccountPage.ConfirmEmailField.SendKeys(p0);
            createYourAccountPage.ContinueButton.Click();
            securityQuestionsPage.GrandmotherQuestion.Click();
            securityQuestionsPage.SecurityAnswer1InputField.SendKeys("Auto");
            securityQuestionsPage.FavouriteFilmQuestion.Click();
            securityQuestionsPage.SecurityAnswer2InputField.SendKeys("Auto");
            securityQuestionsPage.FavouriteNovelQuestion.Click();
            securityQuestionsPage.SecurityAnswer3InputField.SendKeys("Auto");
            securityQuestionsPage.ContinueButton.Click();
            checkYourEmailPage.ContinueButton.Click();
            string BKTWindow = driver.CurrentWindowHandle;
            driver.SwitchTo().NewWindow(WindowType.Tab);
            driver.Navigate().GoToUrl(ConfigUtil.MailTrapUrl);
            Thread.Sleep(2000);
            mailTrapPage.mailTrapUserEmail.SendKeys(ConfigUtil.MailTrapUsername);
            mailTrapPage.mailTrapNextButton.Click();
            Thread.Sleep(1000);
            mailTrapPage.mailTrapUserPassword.SendKeys(ConfigUtil.MailTrapPassword);
            mailTrapPage.mailTrapLogInButton.Click();
            Thread.Sleep(1000);
            mailTrapPage.mailTrapCookiesAgreement.Click();
            Thread.Sleep(1000);
            mailTrapPage.MailTrapEmailSearchBox.SendKeys(p0);
            Thread.Sleep(1000);
            mailTrapPage.mailTrapEmail.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(mailTrapPage.EmailIFrame);
            applicationNumber = mailTrapPage.ApplicationNumber.Text;
            driver.SwitchTo().Window(BKTWindow);
            signIntoExistingApplicationPage.ApplicationNumberInputField.SendKeys(applicationNumber);
            signIntoExistingApplicationPage.ContinueButton.Click();
            continueToApplicationPage.YourSecurityQuestionInputField.SendKeys("Auto");
            continueToApplicationPage.ContinueButton.Click();
        }

        #endregion
        #endregion

        #region Section 1 Personal Details

        #region Section 1 Quick Route

        [When(@"I confirm my personal details")]
        public void WhenIConfirmMyPersonalDetails()
        {
            applicationOverviewPage.PersonalDetails_StartButton.Click();
            personalDetailsPage.Title_MrOption.Click();
            personalDetailsPage.Continue.Click();
            personalDetails2Page.Gender_ManOption.Click();
            personalDetails2Page.NINumber_InputField.SendKeys("AA123456A");
            personalDetails2Page.RelationShipStatus_SingleOption.Click();
            personalDetails2Page.ContinueButton.Click();
            otherNameOrAliasPage.Continue_NoOtherNames.Click();
            contactDetailsPage.TelephoneField.SendKeys("01213337777");
            contactDetailsPage.BuildingAndStreet_LineOneField.SendKeys("1 Test Street");
            contactDetailsPage.TownOrCityField.SendKeys("Test Town");
            contactDetailsPage.PostcodeField.SendKeys("T35 7ER");
            contactDetailsPage.CountryField.SendKeys("United Kingdom");
            contactDetailsPage.Continue.Click();
            residencyDetailsPage.March.Click();
            residencyDetailsPage.Year.SendKeys("2000");
            residencyDetailsPage.OwntheProperty_YesOption.Click();
            residencyDetailsPage.ContinueButton.Click();
            yourHouseholdPage.Continue_Button.Click();
            addressHistoryPage.Continue_Button.Click();
            dependantsDontLiveWithMePage.Continue_Button.Click();
            personalDetailsSummaryPage.Continue_Button.Click();
        }


        #endregion

        #endregion

        #region Section 1.1 Personal Details with Alias Name

        #region Quick route

        [When(@"I confirm my personal details including alias")]
        public void WhenIConfirmMyPersonalDetailsIncludingAlias()
        {
            applicationOverviewPage.PersonalDetails_StartButton.Click();
            personalDetailsPage.Title_MrOption.Click();
            personalDetailsPage.Continue.Click();
            personalDetails2Page.Gender_ManOption.Click();
            personalDetails2Page.NINumber_InputField.SendKeys("AA123456A");
            personalDetails2Page.RelationShipStatus_SingleOption.Click();
            personalDetails2Page.ContinueButton.Click();
            otherNameOrAliasPage.FirstName_InputField.SendKeys("Previous");
            otherNameOrAliasPage.LastName_InputField.SendKeys("Name");
            otherNameOrAliasPage.AddNameButton.Click();
            otherNameOrAliasPage.Continue_AllNamesAdded.Click();
            contactDetailsPage.TelephoneField.SendKeys("01213337777");
            contactDetailsPage.BuildingAndStreet_LineOneField.SendKeys("1 Test Street");
            contactDetailsPage.TownOrCityField.SendKeys("Test Town");
            contactDetailsPage.PostcodeField.SendKeys("T35 7ER");
            contactDetailsPage.CountryField.SendKeys("United Kingdom");
            contactDetailsPage.Continue.Click();
            residencyDetailsPage.March.Click();
            residencyDetailsPage.Year.SendKeys("2000");
            residencyDetailsPage.OwntheProperty_YesOption.Click();
            residencyDetailsPage.ContinueButton.Click();
            yourHouseholdPage.Continue_Button.Click();
            addressHistoryPage.Continue_Button.Click();
            dependantsDontLiveWithMePage.Continue_Button.Click();
            personalDetailsSummaryPage.Continue_Button.Click();
        }

        #endregion

        #endregion

        #region Section 1.2 Personal details including anyone who lives with you

        #region quick route

        [When(@"I confirm my personal details including anyone who lives with you")]
        public void WhenIConfirmMyPersonalDetailsIncludingAnyoneWhoLivesWithYouAndFinanciallyDependant()
        {
            applicationOverviewPage.PersonalDetails_StartButton.Click();
            personalDetailsPage.Title_MrOption.Click();
            personalDetailsPage.Continue.Click();
            personalDetails2Page.Gender_ManOption.Click();
            personalDetails2Page.NINumber_InputField.SendKeys("AA123456A");
            personalDetails2Page.RelationShipStatus_SingleOption.Click();
            personalDetails2Page.ContinueButton.Click();
            otherNameOrAliasPage.Continue_AllNamesAdded.Click();
            contactDetailsPage.TelephoneField.SendKeys("01213337777");
            contactDetailsPage.BuildingAndStreet_LineOneField.SendKeys("1 Test Street");
            contactDetailsPage.TownOrCityField.SendKeys("Test Town");
            contactDetailsPage.PostcodeField.SendKeys("T35 7ER");
            contactDetailsPage.CountryField.SendKeys("United Kingdom");
            contactDetailsPage.Continue.Click();
            residencyDetailsPage.March.Click();
            residencyDetailsPage.Year.SendKeys("2000");
            residencyDetailsPage.OwntheProperty_YesOption.Click();
            residencyDetailsPage.ContinueButton.Click();
            yourHouseholdPage.FirstName_InputField.SendKeys("First");
            yourHouseholdPage.LastName_InputField.SendKeys("Name");
            yourHouseholdPage.AddPersonButton.Click();
            addPersonPage.AgeGroup_24_30.Click();
            addPersonPage.Relationship_HusbandWifePartnerOption.Click();
            addPersonPage.FinanciallyDependant_YesOption.Click();
            yourHouseholdPage.Continue_Button.Click();
            addressHistoryPage.Continue_Button.Click();
            dependantsDontLiveWithMePage.Continue_Button.Click();
            personalDetailsSummaryPage.Continue_Button.Click();
        }

        #endregion

        #endregion

        #region Section 1.3 Personal details Including Dependants Who dont live with you
        #region Quick route

        [When(@"I confirm my personal details including dependants who dont live with you")]
        public void WhenIConfirmMyPersonalDetailsIncludingDependantsWhoDontLiveWithYou()
        {
            applicationOverviewPage.PersonalDetails_StartButton.Click();
            personalDetailsPage.Title_MrOption.Click();
            personalDetailsPage.Continue.Click();
            personalDetails2Page.Gender_ManOption.Click();
            personalDetails2Page.NINumber_InputField.SendKeys("AA123456A");
            personalDetails2Page.RelationShipStatus_SingleOption.Click();
            personalDetails2Page.ContinueButton.Click();
            otherNameOrAliasPage.Continue_NoOtherNames.Click();
            contactDetailsPage.TelephoneField.SendKeys("01213337777");
            contactDetailsPage.BuildingAndStreet_LineOneField.SendKeys("1 Test Street");
            contactDetailsPage.TownOrCityField.SendKeys("Test Town");
            contactDetailsPage.PostcodeField.SendKeys("T35 7ER");
            contactDetailsPage.CountryField.SendKeys("United Kingdom");
            contactDetailsPage.Continue.Click();
            residencyDetailsPage.March.Click();
            residencyDetailsPage.Year.SendKeys("2000");
            residencyDetailsPage.OwntheProperty_YesOption.Click();
            residencyDetailsPage.ContinueButton.Click();
            yourHouseholdPage.Continue_Button.Click();
            addressHistoryPage.Continue_Button.Click();
            dependantsDontLiveWithMePage.FirstName_InputField.SendKeys("Dependant");
            dependantsDontLiveWithMePage.LastName_InputField.SendKeys("One");
            dependantsDontLiveWithMePage.AddPersonButton.Click();
            dependantDetailsPage.AgeInputField.SendKeys("15");
            dependantDetailsPage.BuildingAndStreet_LineOneField.SendKeys("2 Test Street");
            dependantDetailsPage.TownOrCityField.SendKeys("Test Town");
            dependantDetailsPage.PostcodeField.SendKeys("T35 7ER");
            dependantDetailsPage.CountryField.SendKeys("United Kingdom");
            dependantDetailsPage.Relationship_ChildOption.Click();
            dependantDetailsPage.ContinueButton.Click();
            personalDetailsSummaryPage.Continue_Button.Click();
        }

        #endregion
        #endregion

        #region Section 1.4 Personal Details with AliasName Including anyone who lives with you
        #region Quick route

        [When(@"I confirm my personal details with AliasName Including anyone who lives with you")]
        public void WhenIConfirmMyPersonalDetailsWithAliasNameIncludingAnyoneWhoLivesWithYou()
        {
            applicationOverviewPage.PersonalDetails_StartButton.Click();
            personalDetailsPage.Title_MrOption.Click();
            personalDetailsPage.Continue.Click();
            personalDetails2Page.Gender_ManOption.Click();
            personalDetails2Page.NINumber_InputField.SendKeys("AA123456A");
            personalDetails2Page.RelationShipStatus_SingleOption.Click();
            personalDetails2Page.ContinueButton.Click();
            otherNameOrAliasPage.FirstName_InputField.SendKeys("Previous");
            otherNameOrAliasPage.LastName_InputField.SendKeys("Name");
            otherNameOrAliasPage.AddNameButton.Click();
            otherNameOrAliasPage.Continue_AllNamesAdded.Click();
            contactDetailsPage.TelephoneField.SendKeys("01213337777");
            contactDetailsPage.BuildingAndStreet_LineOneField.SendKeys("1 Test Street");
            contactDetailsPage.TownOrCityField.SendKeys("Test Town");
            contactDetailsPage.PostcodeField.SendKeys("T35 7ER");
            contactDetailsPage.CountryField.SendKeys("United Kingdom");
            contactDetailsPage.Continue.Click();
            residencyDetailsPage.March.Click();
            residencyDetailsPage.Year.SendKeys("2000");
            residencyDetailsPage.OwntheProperty_YesOption.Click();
            residencyDetailsPage.ContinueButton.Click();
            yourHouseholdPage.FirstName_InputField.SendKeys("First");
            yourHouseholdPage.LastName_InputField.SendKeys("Name");
            yourHouseholdPage.AddPersonButton.Click();
            addPersonPage.AgeGroup_24_30.Click();
            addPersonPage.Relationship_HusbandWifePartnerOption.Click();
            addPersonPage.FinanciallyDependant_YesOption.Click();
            yourHouseholdPage.Continue_Button.Click();
            addressHistoryPage.Continue_Button.Click();
            dependantDetailsPage.ContinueButton.Click();
            personalDetailsSummaryPage.Continue_Button.Click();
        }

        #endregion
        #endregion

        #region Section 1.5 Personal details with With AliasName, Anyone Who Lives With You, Dependants Who Dont Live With you

        #region Quick route
        [When(@"I confirm my personal details with AliasName, Anyone Who Lives With You, Dependants Who Dont Live With you")]
        public void WhenIConfirmMyPersonalDetailsWithAliasNameAnyoneWhoLivesWithYouDependantsWhoDontLiveWithYou()
        {
            applicationOverviewPage.PersonalDetails_StartButton.Click();
            personalDetailsPage.Title_MrOption.Click();
            personalDetailsPage.Continue.Click();
            personalDetails2Page.Gender_ManOption.Click();
            personalDetails2Page.NINumber_InputField.SendKeys("AA123456A");
            personalDetails2Page.RelationShipStatus_SingleOption.Click();
            personalDetails2Page.ContinueButton.Click();
            otherNameOrAliasPage.FirstName_InputField.SendKeys("Previous");
            otherNameOrAliasPage.LastName_InputField.SendKeys("Name");
            otherNameOrAliasPage.AddNameButton.Click();
            otherNameOrAliasPage.Continue_AllNamesAdded.Click();
            contactDetailsPage.TelephoneField.SendKeys("01213337777");
            contactDetailsPage.BuildingAndStreet_LineOneField.SendKeys("1 Test Street");
            contactDetailsPage.TownOrCityField.SendKeys("Test Town");
            contactDetailsPage.PostcodeField.SendKeys("T35 7ER");
            contactDetailsPage.CountryField.SendKeys("United Kingdom");
            contactDetailsPage.Continue.Click();
            residencyDetailsPage.March.Click();
            residencyDetailsPage.Year.SendKeys("2000");
            residencyDetailsPage.OwntheProperty_YesOption.Click();
            residencyDetailsPage.ContinueButton.Click();
            yourHouseholdPage.FirstName_InputField.SendKeys("First");
            yourHouseholdPage.LastName_InputField.SendKeys("Name");
            yourHouseholdPage.AddPersonButton.Click();
            addPersonPage.AgeGroup_24_30.Click();
            addPersonPage.Relationship_HusbandWifePartnerOption.Click();
            addPersonPage.FinanciallyDependant_YesOption.Click();
            yourHouseholdPage.Continue_Button.Click();
            addressHistoryPage.Continue_Button.Click();
            dependantsDontLiveWithMePage.FirstName_InputField.SendKeys("Dependant");
            dependantsDontLiveWithMePage.LastName_InputField.SendKeys("One");
            dependantsDontLiveWithMePage.AddPersonButton.Click();
            dependantDetailsPage.AgeInputField.SendKeys("15");
            dependantDetailsPage.BuildingAndStreet_LineOneField.SendKeys("2 Test Street");
            dependantDetailsPage.TownOrCityField.SendKeys("Test Town");
            dependantDetailsPage.PostcodeField.SendKeys("T35 7ER");
            dependantDetailsPage.CountryField.SendKeys("United Kingdom");
            dependantDetailsPage.Relationship_ChildOption.Click();
            dependantDetailsPage.ContinueButton.Click();
            personalDetailsSummaryPage.Continue_Button.Click();
        }



        #endregion
        #endregion

        #region Section 2 Employment

        #region Quick Route

        [When(@"I confirm my employment details")]
        public void WhenIConfirmMyEmploymentDetails()
        {
            applicationOverviewPage.Employment_StartButton.Click();
            employmentSummaryPage.HasBeenDirector_NoButton.Click();
            employmentSummaryPage.HasBeenSelfEmployed_NoButton.Click();
            employmentSummaryPage.HasBeenPartner_NoButton.Click();
            employmentSummaryPage.HasBeenEmployed_No.Click();
            employmentSummaryPage.Continue.Click();
            yourStatusPage.CurrentlyNotWorking.Click();
            yourStatusPage.Continue.Click();
        }


        #endregion

        #endregion

        #region Section 3 Bank Accounts And Savings

        #region Quick Route

        [When(@"I confirm I had no bank accounts and savings")]
        public void WhenIConfirmIHadNoBankAccountsAndSavings()
        {
            applicationOverviewPage.BankAccountsAndSavings_StartButton.Click();
            bankAccountsAndSavingsPage.ContinueNoBankAccounts.Click();
        }


        #endregion

        #endregion

        #region Section 4 Assets

        #region Quick Route

        [When(@"I confirm I have no assets")]
        public void WhenIConfirmIHaveNoAssets()
        {
            applicationOverviewPage.Assets_StartButton.Click();
            assetsPage.Properties_No.Click();
            assetsPage.Vehicles_No.Click();
            assetsPage.PensionInsurance_No.Click();
            assetsPage.OtherItems_Start.Click();
            otherItemsPage.Cash_No.Click();
            otherItemsPage.ItemsPossessions_None.Click();
            otherItemsPage.CompensationsLegal_None.Click();
            otherItemsPage.WillsTrust_None.Click();
            otherItemsPage.StocksShares_None.Click();
            otherItemsPage.SelfEmployedBusinessAssets_None.Click();
            otherItemsPage.MoneyOwed_None.Click();
            otherItemsPage.Other_None.Click();
            otherItemsPage.Continue.Click();
            assetsPage.Continue.Click();
            soldTransferredGiftedAssetsPage.SoldProperties_No.Click();
            soldTransferredGiftedAssetsPage.SoldPensionInsurance_No.Click();
            soldTransferredGiftedAssetsPage.SoldAssets_No.Click();
            soldTransferredGiftedAssetsPage.Continue.Click();
        }


        #endregion

        #endregion

        #region Section 5 Money You Owe

        #region Quick Route

        [When(@"I confirm the money I owe")]
        public void WhenIConfirmTheMoneyIOwe()
        {
            applicationOverviewPage.MoneyYouOwe_StartButton.Click();
            moneyYouOwePage.CreditorName.SendKeys("Smoke Test");
            moneyYouOwePage.AddCreditor.Click();
            creditorsAddressPage.AddressLine1.SendKeys("107 Test Avenue");
            creditorsAddressPage.TownCity.SendKeys("Test Town");
            creditorsAddressPage.PostalCode.SendKeys("T37 5ER");
            creditorsAddressPage.Country.SendKeys("United Kingdom");
            creditorsAddressPage.PageHeading.Click();
            creditorsAddressPage.Continue.Click();
            amountYouOwePage.Amount.SendKeys("10000");
            amountYouOwePage.Utilities.Click();
            amountYouOwePage.DebtStarted_1_2Years.Click();
            amountYouOwePage.Continue.Click();
            moneyYouOwePage.ContinueAddedAllCreditors.Click();
            actionsTakenPage.Continue.Click();
            moneyYouOweSummaryPage.Continue.Click();
        }


        #endregion
        #endregion

        #region Section 6 Income and Expenses

        #region Quick Route
        [When(@"I confirm I have no income and expenses")]
        public void WhenIConfirmIHaveNoIncomeAndExpenses()
        {
            applicationOverviewPage.IncomeAndExpenses_StartButton.Click();
            incomeAndExpensesPage.Continue.Click();
        }
        #endregion

        #endregion

        #region Section 7 Legal Proceedings

        #region Quick Route
        [When(@"I confirm I have no legal proceedings")]
        public void WhenIConfirmIHaveNoLegalProceedings()
        {
            applicationOverviewPage.LegalProceedings_StartButton.Click();
            legalProceedingsPage.SeparatedNo.Click();
            legalProceedingsPage.OngoingLegalNo.Click();
            legalProceedingsPage.Continue.Click();
        }
        #endregion

        #endregion

        #region Section 8 Debt History

        #region Quick Route

        [When(@"I confirm my debt history")]
        public void WhenIConfirmMyDebtHistory()
        {
            applicationOverviewPage.DebtHistory_StartButton.Click();
            debtHistoryOverviewPage.StartDebtHistory.Click();
            debtHistoryPage.RealisedJanuary.Click();
            debtHistoryPage.RealisedYear.SendKeys(DateTime.Now.Year.ToString());
            debtHistoryPage.RelationshipBreakdown.Click();
            debtHistoryPage.Continue.Click();
            debtHistoryOverviewPage.DebtReliefNo.Click();
            debtHistoryOverviewPage.PreferentialPaymentsNo.Click();
            debtHistoryOverviewPage.Continue.Click();
        }


        #endregion

        #endregion

        #region Payment

        #region Quick Route

        [When(@"I pay my fee")]
        public void WhenIPayMyFee()
        {
            applicationOverviewPage.MakeAPayment.Click();
            makeFeePaymentPage.Amount.SendKeys("680");
            makeFeePaymentPage.MakeACardPayment.Click();
            worldPayPage.CardNumber.SendKeys(ConfigUtil.PaymentCardNumber);
            worldPayPage.ExpiryMonth.SendKeys("07");
            worldPayPage.ExpiryYear.SendKeys("28");
            worldPayPage.SecurityCode.SendKeys(ConfigUtil.PaymentSecurityNumber);
            worldPayPage.MakePayment.Click();
            Thread.Sleep(2000);
            paymentAcknowledgementPage.ReturnToApplication.Click();
        }

        #endregion
        #endregion

        #region Submit Application

        #region Quick Route

        [When(@"I submit my application")]
        public void WhenISubmitMyApplication()
        {
            applicationOverviewPage.SumbitApplication.Click();
            continueToSubmitPage.IncludedDebtsInOtherApplicationNo.Click();
            continueToSubmitPage.SpokenWithDebtAdvisorYes.Click();
            continueToSubmitPage.PARVNo.Click();
            continueToSubmitPage.Continue.Click();
            submitApplicationPage.SubmitMyApplication.Click();
        }

        [Then(@"the application is submitted")]
        public void ThenTheApplicationIsSubmitted()
        {
            applicationSubmittedPage.ApplicationSubmitted.Text.Should().Be("Your application has been submitted");
        }


        #endregion

        #endregion

        #region ODS Adjudicator

        [When(@"I log into ODS Adjudicator")]
        public void WhenILogIntoODSAdjudicator()
        {
            driver.Navigate().GoToUrl(ConfigUtil.ODSAdjudicatorUrl);
            adjudicatorLoginPage.Username.SendKeys(ConfigUtil.ODSAdjudicatorUsername);
            adjudicatorLoginPage.Password.SendKeys(ConfigUtil.ODSAdjudicatorPassword);
            adjudicatorLoginPage.Login.Click();
        }

        #endregion

        #region ODS Admin

        [When(@"I log into ODS Admin")]
        public void WhenILogIntoODSAdmin()
        {
            driver.Navigate().GoToUrl(ConfigUtil.ODSAdminUrl);
            adminLoginPage.Username.SendKeys(ConfigUtil.ODSAdminUsername);
            adminLoginPage.Password.SendKeys(ConfigUtil.ODSAdminPassword);
            adminLoginPage.Login.Click();
        }


        #endregion

    }
}
