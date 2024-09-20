using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class DebtHistoryOverviewPage
    {
        private IWebDriver driver;
        public DebtHistoryOverviewPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements

        public IWebElement StartDebtHistory => driver.FindElement(By.Id("StartDebtHistory"));
        public IWebElement DebtReliefYes => driver.FindElement(By.Id("debtreliefoptionsusedanswer_true"));
        public IWebElement DebtReliefNo => driver.FindElement(By.Id("nodebtreliefoptiontoadd"));
        public IWebElement PreferentialPaymentsYes => driver.FindElement(By.Id("debtextrapaymentsmadeanswer_true"));
        public IWebElement PreferentialPaymentsNo => driver.FindElement(By.Id("nodebtextrapaymentsmadetoadd"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
