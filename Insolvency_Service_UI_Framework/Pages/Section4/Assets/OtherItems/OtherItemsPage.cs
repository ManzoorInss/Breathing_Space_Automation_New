using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class OtherItemsPage
    {
        private IWebDriver driver;
        public OtherItemsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement Cash_StartButton => driver.FindElement(By.Id("StartCash"));
        public IWebElement Cash_No => driver.FindElement(By.Id("SkipCash"));
        public IWebElement Cash_Edit => driver.FindElement(By.Id("EditCash"));
        public IWebElement ItemsPossessions_StartButton => driver.FindElement(By.Id("StartOtherItems"));
        public IWebElement ItemsPossessions_None => driver.FindElement(By.Id("SkipOtherItems"));
        public IWebElement ItemsPossessions_Edit => driver.FindElement(By.Id("EditOtherItems"));
        public IWebElement CompensationsLegal_StartButton => driver.FindElement(By.Id("StartCompensations"));
        public IWebElement CompensationsLegal_None => driver.FindElement(By.Id("SkipCompensations"));
        public IWebElement CompensationsLegal_Edit => driver.FindElement(By.Id("EditCompensations"));
        public IWebElement WillsTrusts_StartButton => driver.FindElement(By.Id("StartWills"));
        public IWebElement WillsTrust_None => driver.FindElement(By.Id("SkipWills"));
        public IWebElement WillsTrust_Edit => driver.FindElement(By.Id("EditWills"));
        public IWebElement StocksShares_StartButton => driver.FindElement(By.Id("StartStocks"));
        public IWebElement StocksShares_None => driver.FindElement(By.Id("SkipStocks"));
        public IWebElement StocksShares_Edit => driver.FindElement(By.Id("EditStocks"));
        public IWebElement SelfEmployedBusinessAssets_StartButton => driver.FindElement(By.Id("StartSelfEmployed"));
        public IWebElement SelfEmployedBusinessAssets_None => driver.FindElement(By.Id("SkipSelfEmployed"));
        public IWebElement SelfEmployedBusinessAssets_Edit => driver.FindElement(By.Id("EditSelfEmployed"));
        public IWebElement MoneyOwed_StartButton => driver.FindElement(By.Id("StartMoneyOwed"));
        public IWebElement MoneyOwed_None => driver.FindElement(By.Id("SkipMoneyOwed"));
        public IWebElement MoneyOwed_Edit => driver.FindElement(By.Id("EditMoneyOwed"));
        public IWebElement Other_StartButton => driver.FindElement(By.Id("StartOther"));
        public IWebElement Other_None => driver.FindElement(By.Id("SkipOther"));
        public IWebElement Other_Edit => driver.FindElement(By.Id("EditOther"));
        public IWebElement Continue => driver.FindElement(By.Id("Continue"));
        public IWebElement Back => driver.FindElement(By.Id("back"));
        public IWebElement BackToApplicationOverview => driver.FindElement(By.Id("back_to_overview"));

    }
}
