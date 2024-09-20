using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class BusinessDetailsPage
    {
        private IWebDriver driver;
        public BusinessDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //PageElements
        public IWebElement BusinessName_InputField => driver.FindElement(By.Id("BusinessName"));
        public IWebElement BusinessDebtsUnderDifferentName_YesOption => driver.FindElement(By.Id("DisplayOtherBusinessNames_0"));
        public IWebElement BusinessDebtsUnderDifferentName_NoOption => driver.FindElement(By.Id("DisplayOtherBusinessNames_1"));
        public IWebElement OtherBusinessName1 => driver.FindElement(By.Id("SelfEmployedBusinessnames[0].BusinessName"));
        public IWebElement OtherBusinessName2 => driver.FindElement(By.Id("SelfEmployedBusinessnames[1].BusinessName"));
        public IWebElement AddAnotherBusinessName => driver.FindElement(By.Id("AddOtherBusinessName"));
        public IWebElement DeleteBusinessName1 => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div[1]/form/div[3]/fieldset/table/tbody/tr[2]/td[2]/div/input"));
        public IWebElement DeleteBusinessName2 => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div[1]/form/div[3]/fieldset/table/tbody/tr[3]/td[2]/div/input"));
        public IWebElement BusinessType_InputField => driver.FindElement(By.Id("BusinessType"));
        public IWebElement TradingStarted_MonthField => driver.FindElement(By.Id("TradingStartedDate_Month"));
        public IWebElement TradingStarted_YearField => driver.FindElement(By.Id("TradingStartedDate_Year"));
        public IWebElement TradingStopped_MonthField => driver.FindElement(By.Id("TradingStoppedDate_Month"));
        public IWebElement TradingStopped_YearField => driver.FindElement(By.Id("TradingStoppedDate_Year"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
