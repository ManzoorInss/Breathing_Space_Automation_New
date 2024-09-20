using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class ContinueToSubmitPage
    {
        private IWebDriver driver;
        public ContinueToSubmitPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //Buttons and PageElements
        public IWebElement IncludedDebtsInOtherApplicationYes => driver.FindElement(By.Id("IncludedDebtsFromAnotherApplication_0"));
        public IWebElement IncludedDebtsInOtherApplicationNo => driver.FindElement(By.Id("IncludedDebtsFromAnotherApplication_1"));
        public IWebElement SpokenWithDebtAdvisorYes => driver.FindElement(By.Id("SpokenToDebtAdvisor_0"));
        public IWebElement SpokenWithDebtAdvisorNo => driver.FindElement(By.Id("SpokenToDebtAdvisor_1"));
        public IWebElement PARVYes => driver.FindElement(By.Id("AppliedForPAVOrder_0"));
        public IWebElement PARVNo => driver.FindElement(By.Id("AppliedForPAVOrder_1"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));
    }
}
