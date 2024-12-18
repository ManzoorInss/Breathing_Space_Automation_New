//using BSSTestAutomation.Utils;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BSS_Automation_Framework.StepDefinitions
//{
//    public class BSSStepDefinations
//    {
//        private readonly IWebDriver _driver;

//        public BSSStepDefinations(IWebDriver driver)
//        {
//            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
//        }


//        [Given(@"I navigate to the Money Advisor Breathing Space Homepage as Money Advisor '([^']*)'")]
//        public void GivenINavigateToTheMoneyAdvisorBreathingSpaceHomepageAsMoneyAdvisor(string p0)
//        {
//            _driver.Navigate().GoToUrl(ConfigUtil.PortalBaseUrl);

//        }

//        [Given(@"I choose to create a Breathing Space")]
//        public void GivenIChooseToCreateABreathingSpace()
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I create new client with details")]
//        public void GivenICreateNewClientWithDetails(Table table)
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I click add previous Name '([^']*)'")]
//        public void GivenIClickAddPreviousName(string yes)
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I enter previous name")]
//        public void GivenIEnterPreviousName(Table table)
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I verify updated previous name")]
//        public void GivenIVerifyUpdatedPreviousName()
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I click save and continue on client name summary page")]
//        public void GivenIClickSaveAndContinueOnClientNameSummaryPage()
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I add client address")]
//        public void GivenIAddClientAddress(Table table)
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I confirm client address on debtor address page")]
//        public void GivenIConfirmClientAddressOnDebtorAddressPage()
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I set previousAddresses to")]
//        public void GivenISetPreviousAddressesTo(Table table)
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I select client receive confirmation by Email or Post or No Notification")]
//        public void GivenISelectClientReceiveConfirmationByEmailOrPostOrNoNotification()
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I set business to")]
//        public void GivenISetBusinessTo(Table table)
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I confirm client details on debtor confirm page")]
//        public void GivenIConfirmClientDetailsOnDebtorConfirmPage()
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I choose to add debt and submit debt with the details below")]
//        public void GivenIChooseToAddDebtAndSubmitDebtWithTheDetailsBelow(Table table)
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I submit the client into Breathing space")]
//        public void GivenISubmitTheClientIntoBreathingSpace()
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I select standard Breather space")]
//        public void GivenISelectStandardBreatherSpace()
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I agree declaration and submit to Breathing space")]
//        public void GivenIAgreeDeclarationAndSubmitToBreathingSpace()
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I verify client reference no")]
//        public void GivenIVerifyClientReferenceNo()
//        {
//            throw new PendingStepException();
//        }

//        [Given(@"I wait for debt status to become '([^']*)'")]
//        public void GivenIWaitForDebtStatusToBecome(string p0, Table table)
//        {
//            throw new PendingStepException();
//        }

//    }
//}
