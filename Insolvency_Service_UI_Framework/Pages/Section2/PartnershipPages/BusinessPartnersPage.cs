using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class BusinessPartnersPage
    {
        private IWebDriver driver;
        public BusinessPartnersPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement FirstName => driver.FindElement(By.Id("FirstName"));
        public IWebElement LastName => driver.FindElement(By.Id("LastName"));
        public IWebElement AddPartnerButton => driver.FindElement(By.Id("next")); 
        public IWebElement BackToEmploymentOverview => driver.FindElement(By.Id("BackToOverview"));
    }
}
