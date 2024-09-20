using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PartnershipAddressesPage
    {
        private IWebDriver driver;
        public PartnershipAddressesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement AddressInput => driver.FindElement(By.Id("Address_1"));
        public IWebElement AddAddressButton => driver.FindElement(By.Id("add"));
        public IWebElement BackToEmploymentOverview => driver.FindElement(By.Id("backToOverview"));
    }
}
