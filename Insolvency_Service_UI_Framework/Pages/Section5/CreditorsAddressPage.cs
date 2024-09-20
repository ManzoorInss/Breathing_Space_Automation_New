using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class CreditorsAddressPage
    {
        private IWebDriver driver;
        public CreditorsAddressPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement CreditorName => driver.FindElement(By.Id("SearchText"));
        public IWebElement SearchAddress => driver.FindElement(By.Id("SearchAddress"));
        public IWebElement AddressLine1 => driver.FindElement(By.Id("Address.Address_1"));
        public IWebElement AddressLine2 => driver.FindElement(By.Id("Address.Address_2"));
        public IWebElement AddressLine3 => driver.FindElement(By.Id("Address.Address_3"));
        public IWebElement TownCity => driver.FindElement(By.Id("Address.TownCity"));
        public IWebElement County => driver.FindElement(By.Id("Address.County"));
        public IWebElement PostalCode => driver.FindElement(By.Id("Address.PostCode"));
        public IWebElement Country => driver.FindElement(By.Id("Address.Country"));
        public IWebElement Continue => driver.FindElement(By.Id("Continue"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
