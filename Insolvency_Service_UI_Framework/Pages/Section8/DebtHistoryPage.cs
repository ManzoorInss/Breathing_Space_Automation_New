using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class DebtHistoryPage
    {
        private IWebDriver driver;
        public DebtHistoryPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements

        #region Date Realised
        public IWebElement RealisedJanuary => driver.FindElement(By.XPath("//*[@id=\"StartDate_Month\"]/option[2]"));
        public IWebElement RealisedFebruary => driver.FindElement(By.XPath("//*[@id=\"StartDate_Month\"]/option[3]"));
        public IWebElement RealisedMarch => driver.FindElement(By.XPath("//*[@id=\"StartDate_Month\"]/option[4]"));
        public IWebElement RealisedApril => driver.FindElement(By.XPath("//*[@id=\"StartDate_Month\"]/option[5]"));
        public IWebElement RealisedMay => driver.FindElement(By.XPath("//*[@id=\"StartDate_Month\"]/option[6]"));
        public IWebElement RealisedJune => driver.FindElement(By.XPath("//*[@id=\"StartDate_Month\"]/option[7]"));
        public IWebElement RealisedJuly => driver.FindElement(By.XPath("//*[@id=\"StartDate_Month\"]/option[8]"));
        public IWebElement RealisedAugust => driver.FindElement(By.XPath("//*[@id=\"StartDate_Month\"]/option[9]"));
        public IWebElement RealisedSeptember => driver.FindElement(By.XPath("//*[@id=\"StartDate_Month\"]/option[10]"));
        public IWebElement RealisedOctober => driver.FindElement(By.XPath("//*[@id=\"StartDate_Month\"]/option[11]"));
        public IWebElement RealisedNovember => driver.FindElement(By.XPath("//*[@id=\"StartDate_Month\"]/option[12]"));
        public IWebElement RealisedDecember => driver.FindElement(By.XPath("//*[@id=\"StartDate_Month\"]/option[13]"));
        public IWebElement RealisedYear => driver.FindElement(By.Id("StartDate_Year"));
        #endregion

        #region Personal
        public IWebElement RelationshipBreakdown => driver.FindElement(By.Id("ReasonsForPersonalDebt_0"));
        public IWebElement SpendingMoreThanEarned => driver.FindElement(By.Id("ReasonsForPersonalDebt_1"));
        public IWebElement IllnessAccident => driver.FindElement(By.Id("ReasonsForPersonalDebt_2"));
        public IWebElement RedundancyLostJob => driver.FindElement(By.Id("ReasonsForPersonalDebt_3"));
        public IWebElement ReducedEmployment => driver.FindElement(By.Id("ReasonsForPersonalDebt_4"));
        public IWebElement ReductionPersonalIncome => driver.FindElement(By.Id("ReasonsForPersonalDebt_5"));
        public IWebElement ReductionHouseholdIncome => driver.FindElement(By.Id("ReasonsForPersonalDebt_6"));
        public IWebElement Gambling => driver.FindElement(By.Id("ReasonsForPersonalDebt_7"));
        public IWebElement VictimFraud => driver.FindElement(By.Id("ReasonsForPersonalDebt_8"));
        public IWebElement DrugsAlcohol => driver.FindElement(By.Id("ReasonsForPersonalDebt_9"));
        public IWebElement PersonalOther => driver.FindElement(By.Id("ReasonsForPersonalDebt_Other"));
        public IWebElement PersonalOtherReason => driver.FindElement(By.Id("ReasonsForPersonalDebt_OtherText"));
        #endregion

        #region Business
        public IWebElement LossCustomersMarket => driver.FindElement(By.Id("ReasonsForBusinessDebt_0"));
        public IWebElement CustomersFailedToPay => driver.FindElement(By.Id("ReasonsForBusinessDebt_1"));
        public IWebElement LossFinancialBacking => driver.FindElement(By.Id("ReasonsForBusinessDebt_2"));
        public IWebElement FailedToDealWithTaxes => driver.FindElement(By.Id("ReasonsForBusinessDebt_3"));
        public IWebElement TooHighOverheads => driver.FindElement(By.Id("ReasonsForBusinessDebt_4"));
        public IWebElement VictimsBusinessFraud => driver.FindElement(By.Id("ReasonsForBusinessDebt_5"));
        public IWebElement BusinessOther => driver.FindElement(By.Id("ReasonsForBusinessDebt_Other"));
        public IWebElement BusinessOtherReason => driver.FindElement(By.Id("ReasonsForBusinessDebt_OtherText"));
        #endregion

        public IWebElement GamblingDebts => driver.FindElement(By.Id("GamblingAmount"));
        public IWebElement Continue => driver.FindElement(By.Id("Continue"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
