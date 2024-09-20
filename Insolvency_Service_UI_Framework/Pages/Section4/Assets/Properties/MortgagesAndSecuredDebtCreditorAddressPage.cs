using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class MortgagesAndSecuredDebtCreditorAddressPage
    {
        private IWebDriver driver;
        public MortgagesAndSecuredDebtCreditorAddressPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement CreditorName => driver.FindElement(By.Id("CreditorName"));
        public IWebElement AddressLine1 => driver.FindElement(By.Id("CreditorAddress.Address_1"));
        public IWebElement AddressLine2 => driver.FindElement(By.Id("CreditorAddress.Address_2"));
        public IWebElement AddressLine3 => driver.FindElement(By.Id("CreditorAddress.Address_3"));
        public IWebElement TownCity => driver.FindElement(By.Id("CreditorAddress.TownCity"));
        public IWebElement County => driver.FindElement(By.Id("CreditorAddress.County"));
        public IWebElement PostalCode => driver.FindElement(By.Id("CreditorAddress.PostCode"));
        public IWebElement Country => driver.FindElement(By.Id("CreditorAddress.Country"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
