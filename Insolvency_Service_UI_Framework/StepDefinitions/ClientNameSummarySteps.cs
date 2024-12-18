using BSSTestAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BSSTestAutomation.StepDefinitions
{
    [Binding]
    public class BSSClientNamesSummarySteps
    {
        private IWebDriver _driver;
        private BSSClientNamesSummaryPage _clientNamesSummaryPage;
        private BSSClientAddPreviousNamePage _bSSClientAddPreviousNamePage;
        private BSSClientNameDetailsPage _bSSClientDetailsPage;

        public BSSClientNamesSummarySteps(IWebDriver driver, BSSClientNamesSummaryPage bSSClientNamesSummaryPage, BSSClientAddPreviousNamePage bSSClientAddPreviousNamePage, BSSClientNameDetailsPage bSSClientNameDetailsPage)
        {
            _driver = driver;
            _clientNamesSummaryPage = bSSClientNamesSummaryPage;
            _bSSClientAddPreviousNamePage = bSSClientAddPreviousNamePage;
            _bSSClientDetailsPage = bSSClientNameDetailsPage;
        }

        [When(@"I enter the client name details")]
        public void WhenIEnterTheClientNameDetails(Table table)
        {
            foreach (var row in table.Rows)
            {
                //_clientNamesSummaryPage.AssertPageTitle("Client names");
                _clientNamesSummaryPage.SelectOptions_Change_Add_Delete(
                    row["ChangeClientName"],
                    row["ChangePreviousName"],
                    row["DeletePreviosName"],
                    row["AddPreviousNames"],
                    row["FirstName"],
                    row["MiddleName"],
                    row["LastName"],
                    row["BirthDay"],
                    row["BirthMonth"],
                    row["BirthYear"]
                );
            }
        }

    }
}
