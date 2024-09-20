using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class ReasonForDebtPage
    {
        private IWebDriver driver;
        public ReasonForDebtPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement DebtRepaymentConsolidation => driver.FindElement(By.Id("ReasonsForDebt_0"));
        public IWebElement HouseholdBillsLivingExpenses => driver.FindElement(By.Id("ReasonsForDebt_1"));
        public IWebElement Holidays => driver.FindElement(By.Id("ReasonsForDebt_2"));
        public IWebElement HomeImprovements => driver.FindElement(By.Id("ReasonsForDebt_3"));
        public IWebElement PaymentsGiftsFamilyFriends => driver.FindElement(By.Id("ReasonsForDebt_4"));
        public IWebElement TradingExpenses => driver.FindElement(By.Id("ReasonsForDebt_5"));
        public IWebElement VehiclePurchase => driver.FindElement(By.Id("ReasonsForDebt_6"));
        public IWebElement Wedding => driver.FindElement(By.Id("ReasonsForDebt_7"));
        public IWebElement Gambling => driver.FindElement(By.Id("ReasonsForDebt_8"));
        public IWebElement Other => driver.FindElement(By.Id("ReasonsForDebt_Other"));
        public IWebElement OtherSpecify => driver.FindElement(By.Id("ReasonsForDebt_OtherText"));
        public IWebElement Continue => driver.FindElement(By.Id("Continue"));
        public IWebElement Back => driver.FindElement(By.Id("backtoamountyouowe"));

    }
}
