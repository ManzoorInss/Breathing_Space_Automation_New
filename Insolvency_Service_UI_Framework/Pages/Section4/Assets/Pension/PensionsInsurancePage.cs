using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PensionsInsurancePage
    {
        private IWebDriver driver;
        public PensionsInsurancePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement ProviderName => driver.FindElement(By.Id("ProviderName"));
        public IWebElement AddPolicyProvider => driver.FindElement(By.Id("add"));
        public IWebElement ContinueNoPolicy => driver.FindElement(By.Id("next"));
        public IWebElement ContinueAddedAllPolicies => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
