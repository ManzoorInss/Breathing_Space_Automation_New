using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PartnershipTaxDetailsPage
    {
        private IWebDriver driver;
        public PartnershipTaxDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement TaxReferenceInput => driver.FindElement(By.Id("UTR"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next")); 
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
