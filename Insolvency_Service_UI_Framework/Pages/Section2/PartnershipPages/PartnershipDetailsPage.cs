using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PartnershipDetailsPage
    {
        private IWebDriver driver;
        public PartnershipDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement BusinessName_InputField => driver.FindElement(By.Id("BusinessName"));
        public IWebElement BusinessDebtsUnderDifferentName_YesOption => driver.FindElement(By.Id("otherNames_0"));
        public IWebElement BusinessDebtsUnderDifferentName_NoOption => driver.FindElement(By.Id("otherNames_1"));
        public IWebElement AddAnotherName => driver.FindElement(By.Id("AddAnother"));
        public IWebElement OtherName1 => driver.FindElement(By.Id("PartnershipBusinessnames_0__BusinessName"));
        public IWebElement OtherName2 => driver.FindElement(By.Id("PartnershipBusinessnames_1__BusinessName"));
        public IWebElement BusinessType_InputField => driver.FindElement(By.Id("BusinessType"));
        public IWebElement TradingStarted_MonthField => driver.FindElement(By.Id("TradingStartedDate_Month"));
        public IWebElement TradingStarted_YearField => driver.FindElement(By.Id("TradingStartedDate_Year"));
        public IWebElement TradingStopped_MonthField => driver.FindElement(By.Id("TradingStoppedDate_Month"));
        public IWebElement TradingStopped_YearField => driver.FindElement(By.Id("TradingStoppedDate_Year"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
