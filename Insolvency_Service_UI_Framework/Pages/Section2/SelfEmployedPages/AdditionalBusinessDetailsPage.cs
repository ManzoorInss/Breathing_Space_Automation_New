using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AdditionalBusinessDetailsPage
    {
        private IWebDriver driver;
        public AdditionalBusinessDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement VATNumberInputField => driver.FindElement(By.Id("'VATNumber"));
        public IWebElement UTRNumberInputField => driver.FindElement(By.Id("UTR"));
        public IWebElement BusinessRecordsLocation_HomeAddress => driver.FindElement(By.Id("RecordsLocation_0"));
        public IWebElement BusinessRecordsLocation_TradingAddress => driver.FindElement(By.Id("RecordsLocation_1"));
        public IWebElement BusinessRecordsLocation_CurrentAccountant => driver.FindElement(By.Id("RecordsLocation_2"));
        public IWebElement BusinessRecordsLocation_Online => driver.FindElement(By.Id("RecordsLocation_3"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
