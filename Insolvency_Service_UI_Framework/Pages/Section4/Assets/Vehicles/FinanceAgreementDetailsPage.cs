using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class FinanceAgreementDetailsPage
    {
        private IWebDriver driver;
        public FinanceAgreementDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement StillOweForVehicle => driver.FindElement(By.Id("Amount"));
        public IWebElement AccountReferenceNumber => driver.FindElement(By.Id("ReferenceNumber"));
        public IWebElement FinanceAgreementStartedMonth => driver.FindElement(By.Id("AgreementStartedDate_Month"));
        public IWebElement FinanceAgreementStartedYear => driver.FindElement(By.Id("AgreementStartedDate_Year"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
