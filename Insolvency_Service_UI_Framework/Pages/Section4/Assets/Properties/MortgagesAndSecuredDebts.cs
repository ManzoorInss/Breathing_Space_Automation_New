using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class MortgagesAndSecuredDebtsPage
    {
        private IWebDriver driver;
        public MortgagesAndSecuredDebtsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement CreditorName => driver.FindElement(By.Id("CreditorName"));
        public IWebElement AddCreditor => driver.FindElement(By.Id("add"));
        public IWebElement ContinueNoMortgages => driver.FindElement(By.Id("next"));
        public IWebElement ContinueAddedAllMortgages => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
