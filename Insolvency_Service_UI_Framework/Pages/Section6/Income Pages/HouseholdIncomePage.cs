using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class HouseholdIncomePage
    {
        private IWebDriver driver;
        public HouseholdIncomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements

        public IWebElement AmountHouseholdReceives => driver.FindElement(By.Id("HouseholdPersonContribution"));
        public IWebElement AmountHouseholdReceivesFrequency => driver.FindElement(By.Id("HouseholdPersonContribution_Frequency"));
        public IWebElement AmountHouseholdReceivesPerMonth => driver.FindElement(By.Id("//*[@id=\"HouseholdPersonContribution_Frequency\"]/option[1]"));
        public IWebElement AmountHouseholdReceivesPerWeek => driver.FindElement(By.Id("//*[@id=\"HouseholdPersonContribution_Frequency\"]/option[2]"));
        public IWebElement AmountHouseholdReceivesPerFortnight => driver.FindElement(By.Id("//*[@id=\"HouseholdPersonContribution_Frequency\"]/option[3]"));
        public IWebElement AmountHouseholdReceivesPer4Weeks => driver.FindElement(By.Id("//*[@id=\"HouseholdPersonContribution_Frequency\"]/option[4]"));
        public IWebElement AmountHouseholdReceivesPerQuarter => driver.FindElement(By.Id("//*[@id=\"HouseholdPersonContribution_Frequency\"]/option[5]"));
        public IWebElement AmountHouseholdReceivesPerYear => driver.FindElement(By.Id("//*[@id=\"HouseholdPersonContribution_Frequency\"]/option[6]"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
