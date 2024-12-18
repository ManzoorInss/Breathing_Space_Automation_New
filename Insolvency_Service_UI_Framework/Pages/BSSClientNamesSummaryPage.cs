using System;
using NUnit.Framework;
using OpenQA.Selenium;
using BSS_Automation_Framework.Utilities;
using BSSTestAutomation.Pages;


namespace BSSTestAutomation.Pages
{
    public class BSSClientNamesSummaryPage
    {
        private IWebDriver _driver;
        private BSSClientAddPreviousNamePage _bSSClientAddPreviousNamePage;
        private BSSClientNameDetailsPage _bSSClientNameDetailsPage;

        public BSSClientNamesSummaryPage(IWebDriver driver, BSSClientAddPreviousNamePage bSSClientAddPreviousNamePage, BSSClientNameDetailsPage bSSClientNameDetailsPage)
        {
            _driver = driver;
            _bSSClientAddPreviousNamePage = bSSClientAddPreviousNamePage;
            _bSSClientNameDetailsPage = bSSClientNameDetailsPage;
        }

        // Page Elements 

        public IWebElement PageTitle1 => _driver.FindElement(By.ClassName("govuk-caption-xl"));
        public IWebElement PageTitle => _driver.FindElement(By.TagName("title"));
        public IWebElement ClientNameLabel => _driver.FindElement(By.Id("debtor-previous-name-item-heading"));
        public IWebElement BackLink => _driver.FindElement(By.Id("back-link"));
        public IWebElement NamesHeading => _driver.FindElement(By.ClassName("govuk-heading-xl"));
        public IWebElement NameHeading => _driver.FindElement(By.Id("debtor-previous-name-item-heading"));
        public IWebElement ClientName => _driver.FindElement(By.Id("client-name-summary-curr-name"));
        public IWebElement ChangeClientNameLink => _driver.FindElement(By.Id("client-name-summary-chng-curr-name"));
        public IWebElement AddPreviousNameHeading => _driver.FindElement(By.Id("client-names-add-name-msg"));
        public IWebElement HelperMessage1 => _driver.FindElement(By.Id("client-names-helper-msg-1"));
        public IWebElement HelperMessage2 => _driver.FindElement(By.Id("client-names-helper-msg-2"));
        public IWebElement AddPreviousNameBtn => _driver.FindElement(By.Id("client-names-add-prev-name"));
        public IWebElement PreviousNameLabel => _driver.FindElement(By.Id("debtor-previous-name-title-1"));
        public IWebElement PreviousNameValue => _driver.FindElement(By.Id("client-name-summary-prev-name-1"));
        public IWebElement ChangePreviousNameLink => _driver.FindElement(By.Id("client-name-summary-chng-prev-name-1"));
        public IWebElement DeletePreviousNameLink => _driver.FindElement(By.Id("client-name-summary-del-prev-name-1"));
        public IWebElement ChangeNameSaveAndContinueBtn => _driver.FindElement(By.Id("client-names-save-continue"));
        public IWebElement SaveAndContinueBtn => _driver.FindElement(By.Id("save-button"));

     // Methods

        public void AssertPageTitle(string expectedTitle)
        {
            string actualTitle = PageTitle1.Text.Trim();
            Assert.That(actualTitle.Equals(expectedTitle, StringComparison.OrdinalIgnoreCase),
                $"Page title does not match. Expected: {expectedTitle}, Actual: {actualTitle}");
        }

        public void SelectOptions_Change_Add_Delete(
      string changeClientName,
      string changePreviousName,
      string deletePreviousName,
      string addPreviousNames,
      string firstName,
      string middleName,
      string lastName,
      string birthDay,
      string birthMonth,
      string birthYear)
        {
            // Check if all fields are empty and directly click "Save and Continue"
            if (string.IsNullOrWhiteSpace(changeClientName) &&
                string.IsNullOrWhiteSpace(changePreviousName) &&
                string.IsNullOrWhiteSpace(deletePreviousName) &&
                string.IsNullOrWhiteSpace(addPreviousNames))
            {
                Console.WriteLine("All fields are empty. Clicking Save and Continue.");
                SaveAndContinueBtn.Click();
                return;
            }

            // update based on the table data
            if (!string.IsNullOrWhiteSpace(changeClientName) && changeClientName.Equals("changeCurrentName", StringComparison.OrdinalIgnoreCase))
            {
                ClientNameSummaryPage("change current name");
                _bSSClientNameDetailsPage.FillAllFields(firstName, middleName, lastName, birthDay, birthMonth, birthYear);
                SaveAndContinueBtn.Click();
            }

            if (!string.IsNullOrWhiteSpace(changePreviousName) && changePreviousName.Equals("changePreviousName", StringComparison.OrdinalIgnoreCase))
            {
                ClientNameSummaryPage("change previous name");
                _bSSClientAddPreviousNamePage.AddPreviousNameFillAllFields(firstName, middleName, lastName);
                SaveAndContinueBtn.Click();
            }

            if (!string.IsNullOrWhiteSpace(deletePreviousName) && deletePreviousName.Equals("deletePreviousName", StringComparison.OrdinalIgnoreCase))
            {
                ClientNameSummaryPage("delete previous name");
            }

            if (!string.IsNullOrWhiteSpace(addPreviousNames) && addPreviousNames.Equals("addPreviousNames", StringComparison.OrdinalIgnoreCase))
            {
                ClientNameSummaryPage("add previous name");
                _bSSClientAddPreviousNamePage.AddPreviousNameFillAllFields(firstName, middleName, lastName);
                SaveAndContinueBtn.Click();
            }
            ChangeNameSaveAndContinueBtn.Click();

        }

        public void ClientNameSummaryPage(string update)
        {
            switch (update.ToLower())
            {
                case "change current name":
                    ChangeClientNameLink.Click();
                    break;

                case "add previous name":
                    AddPreviousNameBtn.Click();
                    break;

                case "delete previous name":
                    DeletePreviousNameLink.Click();
                    break;

                case "change previous name":
                    ChangePreviousNameLink.Click();
                    break;

                default:
                    Console.WriteLine($"Invalid action: {update}");
                    break;
            }
        }


    }
}

