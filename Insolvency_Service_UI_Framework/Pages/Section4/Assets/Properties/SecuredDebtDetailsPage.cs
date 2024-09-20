using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class SecuredDebtDetailsPage
    {
        private IWebDriver driver;
        public SecuredDebtDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement Mortgage => driver.FindElement(By.Id("DebtType_0"));
        public IWebElement SecuredLoan => driver.FindElement(By.Id("DebtType_1"));
        public IWebElement Charge => driver.FindElement(By.Id("DebtType_2"));
        public IWebElement ReferenceNumber => driver.FindElement(By.Id("ReferenceNumber"));
        public IWebElement DebtStartedMonth => driver.FindElement(By.Id("DebtStartDate_Month"));
        public IWebElement DebtStartedYear => driver.FindElement(By.Id("DebtStartDate_Year"));
        public IWebElement CreditorOwe => driver.FindElement(By.Id("AmountOwe"));
        public IWebElement JointDebtYes => driver.FindElement(By.Id("IsJointDebt_0"));
        public IWebElement JointDebtNo => driver.FindElement(By.Id("IsJointDebt_1"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
