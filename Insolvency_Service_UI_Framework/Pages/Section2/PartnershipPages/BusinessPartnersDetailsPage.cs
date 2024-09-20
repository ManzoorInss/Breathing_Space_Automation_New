using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class BusinessPartnersDetailsPage
    {
        private IWebDriver driver;
        public BusinessPartnersDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement FirstName => driver.FindElement(By.Id("FirstName"));
        public IWebElement LastName => driver.FindElement(By.Id("LastName"));
        public IWebElement AddressLine1 => driver.FindElement(By.Id("PartnerAddress.Address_1"));
        public IWebElement AddressLine2 => driver.FindElement(By.Id("PartnerAddress.Address_2"));
        public IWebElement AddressLine3 => driver.FindElement(By.Id("PartnerAddress.Address_3"));
        public IWebElement TownCity => driver.FindElement(By.Id("PartnerAddress.TownCity"));
        public IWebElement County => driver.FindElement(By.Id("PartnerAddress.County"));
        public IWebElement PostalCode => driver.FindElement(By.Id("PartnerAddress.PostCode"));
        public IWebElement Country => driver.FindElement(By.Id("PartnerAddress.Country"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next")); 
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
