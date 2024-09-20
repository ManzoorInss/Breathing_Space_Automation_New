using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class BusinessAddressPage
    {
        private IWebDriver driver;
        public BusinessAddressPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement BusinessAddressInputField => driver.FindElement(By.Id("Address_1"));
        public IWebElement AddAddressButton => driver.FindElement(By.Id("add"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("ContinueNoFurtherTradingAddresses"));
    }
}
