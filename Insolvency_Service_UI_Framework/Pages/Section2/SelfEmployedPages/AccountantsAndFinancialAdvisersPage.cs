using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AccountantsAndFinancialAdvisersPage
    {
        private IWebDriver driver;
        public AccountantsAndFinancialAdvisersPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement AccountantName_InputField => driver.FindElement(By.Id("AccountantName"));
        public IWebElement AddAccountantButton => driver.FindElement(By.Id("next"));
        public IWebElement ContinueButton_NoAccountants => driver.FindElement(By.Id("noAccountants"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
