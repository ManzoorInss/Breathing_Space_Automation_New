using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class BankAccountDetailsPage
    {
        private IWebDriver driver;
        public BankAccountDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements

        public IWebElement AccountNumber => driver.FindElement(By.Id("AccountNumber"));
        public IWebElement CurrentBalance => driver.FindElement(By.Id("CurrentBalance"));
        public IWebElement MonthOpened => driver.FindElement(By.Id("DateOpened_Month"));
        public IWebElement YearOpened => driver.FindElement(By.Id("DateOpened_Year"));
        public IWebElement JointAccountYes => driver.FindElement(By.Id("JointAccount_0"));
        public IWebElement JointAccountNo => driver.FindElement(By.Id("JointAccount_1"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
