using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class BankAccountsAndSavingsPage
    {
        private IWebDriver driver;
        public BankAccountsAndSavingsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements
        
        public IWebElement AccountSortCodeInput => driver.FindElement(By.Id("SortCode"));
        public IWebElement AddAccount => driver.FindElement(By.Id("add"));
        public IWebElement ContinueNoBankAccounts => driver.FindElement(By.Id("haventhadanybankaccounts"));
        public IWebElement ContinueAddAllAccounts => driver.FindElement(By.Id("addedallbankaccounts"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
