using System;
using OpenQA.Selenium;

namespace BSSTestAutomation.Pages
{
    public class BSSDebtorAccountSummaryPage
    {
        private readonly IWebDriver _driver;

        public BSSDebtorAccountSummaryPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements
        public IWebElement PageTitle => _driver.FindElement(By.Id("account-header-name"));
        public IWebElement SaveAndCloseRecord => _driver.FindElement(By.Id("debtor-summary-save"));
        public IWebElement SaveAndClose => _driver.FindElement(By.Id("debtor-details-save"));
        public IWebElement AddDebt => _driver.FindElement(By.Id("debtor-summary-add-debt"));
        public IWebElement ClientDetailsTab => _driver.FindElement(By.Id("tab_personal-details"));
        public IWebElement DebtsTab => _driver.FindElement(By.Id("tab_problem-debt"));
        public IWebElement DeleteDebtLink => _driver.FindElement(By.CssSelector("a[id^='debtor-summary-del-debt-']"));
        public IWebElement NotificationMethod => _driver.FindElement(By.Id("debtor-summary-notification-method-preference"));
        public IWebElement EmailAddress => _driver.FindElement(By.Id("debtor-summary-notification-method-email"));
        public IWebElement InactiveLabel => _driver.FindElement(By.Id("account-header-status"));
        public IWebElement AdddebtstoBreathingSpaceHeading => _driver.FindElement(By.Id("inactive-account-debts-tab-heading"));
        public IWebElement ClientDetailsHeading => _driver.FindElement(By.Id("ma-details-header"));
        public IWebElement PersonalDetailsLabel => _driver.FindElement(By.Id("debtor-personal-detail-heading"));
        public IWebElement NameLabel => _driver.FindElement(By.Id("debtor-personal-detail-name-heading"));
        public IWebElement FullName => _driver.FindElement(By.Id("debtor-confirm-name"));
        public IWebElement ChangeNameLink => _driver.FindElement(By.Id("debtor-confirm-change-name"));
        public IWebElement DateOfBirthLabel => _driver.FindElement(By.Id("debtor-personal-detail-dob-heading"));
        public IWebElement Dateofbirth => _driver.FindElement(By.Id("debtor-confirm-dob"));
        public IWebElement ChangeDobLink => _driver.FindElement(By.Id("debtor-confirm-change-dob"));
        public IWebElement AddPerviousNameLink => _driver.FindElement(By.Id("debtor-details-add-prev-name"));
        public IWebElement AddressesLabel => _driver.FindElement(By.Id("ma-details-addresses-header"));
        public IWebElement AddressLabel => _driver.FindElement(By.Id("debtor-details-address--header"));
        public IWebElement CurrentAddress => _driver.FindElement(By.CssSelector("#personal-details > div:nth-child(6) .govuk-summary-list__value"));
        public IWebElement ChangeAddressLink => _driver.FindElement(By.Id("debtor-summary-chng-curr-add"));
        public IWebElement HideAddressLink => _driver.FindElement(By.Id("debtor-summary-hide-curr-add"));
        public IWebElement AddressHiddenLabel => _driver.FindElement(By.Id("debtor-address-hide-lbl-0"));
        public IWebElement AddpreviousAddressLink => _driver.FindElement(By.Id("debtor-summary-add-prev-add"));
        public IWebElement MethodLabel => _driver.FindElement(By.Id("debtor-details-notification-method-header"));
        public IWebElement NotificationpreferenceHeading => _driver.FindElement(By.Id("debtor-summary-notification-method-preference"));
        public IWebElement ChangeNotificationPreferenceLink => _driver.FindElement(By.Id("debtor-details-notification-preference-chng")); 
        public IWebElement BusinessLabel => _driver.FindElement(By.Id("ma-details-business-header"));
        public IWebElement AddclientbusinessLink => _driver.FindElement(By.Id("debtor-summary-add-business"));
        public IWebElement DebtTypeLabel => _driver.FindElement(By.CssSelector("#problem-debt dt.govuk-summary-list__key"));
        public IWebElement DebtDetails => _driver.FindElement(By.CssSelector("#problem-debt dd.govuk-summary-list__value"));
        public IWebElement ChangeDebtLink => _driver.FindElement(By.Id("debtor-summary-chng-debt-1"));
        public IWebElement HiddenAddressBusiness => _driver.FindElement(By.Id("debtor-address-hide-lbl-2"));
        public IWebElement HiddenAddressCurrentAddressMsg => _driver.FindElement(By.Id("debtor-address-hide-msg-0"));
        public IWebElement ChangeBusinessAddressLink => _driver.FindElement(By.Id("debtor-summary-chng-business-address-1"));
        public IWebElement ChangeBusinessAddresslink2 => _driver.FindElement(By.Id("debtor-summary-chng-business-address-2"));
        public IWebElement DeleteBusinessAddressLink => _driver.FindElement(By.Id("debtor-summary-del-business-address-1"));
        public IWebElement DeleteBusinessAddresslink2 => _driver.FindElement(By.Id("debtor-summary-del-business-address-2"));
        public IWebElement UpdateAddressHiddenLink => _driver.FindElement(By.Id("debtor-summary-hide-curr-add"));
        public IWebElement BusinessAddresslink2 => _driver.FindElement(By.Id("debtor-summary-business-address-2"));
        public IWebElement DebtDeletedBanner => _driver.FindElement(By.Id("account-review-confirmation"));
        public IWebElement BSReference => _driver.FindElement(By.Id("reference-label"));
        public IWebElement DebtorSummaryPageSaveContiueBtn => _driver.FindElement(By.Id("debtor-confirm-details-btn"));

        // Methods
        public void Update(string update, string notificationType = null)
        {
            switch (update.ToLower())
            {
                case "changename":
                    ChangeName();
                    break;
                case "changedateofbirth":
                    ChangeDateOfBirth();
                    break;
                case "addpreviousname":
                    AddPreviousName();
                    break;
                case "changeaddress":
                    ChangeAddress();
                    break;
                case "hideaddress":
                    HideAddress();
                    break;
                case "addpreviousaddress":
                    AddPreviousAddress();
                    break;
                case "changenotification":
                    ChangeNotificationPreference(notificationType);
                    break;
                case "addbusinessaddress":
                    AddBusinessAddress();
                    break;
                case "changebusinessaddress":
                    ChangeBusinessAddress();
                    break;
                case "deletebusinessaddress":
                    DeleteBusinessAddress();
                    break;
                default:
                    throw new ArgumentException($"Invalid update: {update}");
            }
        }
        public void ChangeName()
        {
            //ClientDetailsHeading.Displayed.Should.Be(true);
            ChangeNameLink.Click();
            Console.WriteLine("Navigated to Change Name page.");
        }

        public void ChangeDateOfBirth()
        {
            ChangeDobLink.Click();
            Console.WriteLine("Navigated to Change Date of Birth page.");
        }

        public void AddPreviousName()
        {
            AddPerviousNameLink.Click();
            Console.WriteLine("Navigated to Add Previous Name page.");
        }

        public void ChangeAddress()
        {
            ChangeAddressLink.Click();
            Console.WriteLine("Navigated to Change Address page.");
        }

        public void HideAddress()
        {
            HideAddressLink.Click();
            Console.WriteLine("Navigated to Hide Address page.");
        }

        public void AddPreviousAddress()
        {
            AddpreviousAddressLink.Click();
            Console.WriteLine("Navigated to Add Previous Address page.");
        }

        public void ChangeNotificationPreference(string notificationType)
        {
            if (string.IsNullOrWhiteSpace(notificationType))
            {
                throw new ArgumentException("Notification type is required to change preference.");
            }

            ChangeNotificationPreferenceLink.Click();
            Console.WriteLine($"Navigated to Change Notification Preference page. Setting preference to {notificationType}.");
        }


        public void AddBusinessAddress()
        {
            AddclientbusinessLink.Click();
            Console.WriteLine("Navigated to Add Business Address page.");
        }

        public void ChangeBusinessAddress()
        {
            ChangeBusinessAddressLink.Click();
            Console.WriteLine("Navigated to Change Business Address page.");
        }

        public void DeleteBusinessAddress()
        {
            DeleteBusinessAddressLink.Click();
            Console.WriteLine("Navigated to Delete Business Address page.");
        }

        public void ValidatePageTitle(string expectedTitle)
        {
            string actualTitle = PageTitle.Text.Trim();
            if (!actualTitle.Equals(expectedTitle, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Page title mismatch. Expected: {expectedTitle}, Actual: {actualTitle}");
            }
            Console.WriteLine($"Page title validated successfully: {actualTitle}");
        }
    }
}

