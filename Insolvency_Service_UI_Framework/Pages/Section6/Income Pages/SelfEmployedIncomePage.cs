using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class SelfEmployedIncomePage
    {
        private IWebDriver driver;
        public SelfEmployedIncomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements

        public IWebElement NetProfit => driver.FindElement(By.Id("Profit"));
        public IWebElement NetProfitFrequency => driver.FindElement(By.Id("Profit_Frequency"));
        public IWebElement NetProfitPerMonth => driver.FindElement(By.Id("//*[@id=\"Profit_Frequency\"]/option[1]"));
        public IWebElement NetProfitPerWeek => driver.FindElement(By.Id("//*[@id=\"Profit_Frequency\"]/option[2]"));
        public IWebElement NetProfitPerFortnight => driver.FindElement(By.Id("//*[@id=\"Profit_Frequency\"]/option[3]"));
        public IWebElement NetProfitPer4Weeks => driver.FindElement(By.Id("//*[@id=\"Profit_Frequency\"]/option[4]"));
        public IWebElement NetProfitPerQuarter => driver.FindElement(By.Id("//*[@id=\"Profit_Frequency\"]/option[5]"));
        public IWebElement NetProfitPerYear => driver.FindElement(By.Id("//*[@id=\"Profit_Frequency\"]/option[6]"));
        public IWebElement AccountStartMonth => driver.FindElement(By.Id("AccountingPeriodStart_Month"));
        public IWebElement AccountStartYear => driver.FindElement(By.Id("AccountingPeriodStart_Year"));
        public IWebElement AccountEndMonth => driver.FindElement(By.Id("AccountingPeriodEnd_Month"));
        public IWebElement AccountEndYear => driver.FindElement(By.Id("AccountingPeriodEnd_Year"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
