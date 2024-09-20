using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class YourPartnerShipsPage
    {
        private IWebDriver driver;
        public YourPartnerShipsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement PartnerShipNameInputField => driver.FindElement(By.Id("PartnershipName"));
        public IWebElement AddPartnerShipButton => driver.FindElement(By.Id("add")); 
        public IWebElement Continue_HaveNoPartnershipsButton => driver.FindElement(By.Id("noPartnerships"));
    }
}
