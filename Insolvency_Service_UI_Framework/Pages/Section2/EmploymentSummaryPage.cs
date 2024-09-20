using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class EmploymentSummaryPage
    {
        private IWebDriver driver;
        public EmploymentSummaryPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement HasBeenDirector_YesButton => driver.FindElement(By.Id("HasBeenDirector_Yes"));
        public IWebElement HasBeenDirector_NoButton => driver.FindElement(By.Id("HasBeenDirector_No"));
        public IWebElement HasBeenSelfEmployed_YesButton => driver.FindElement(By.Id("HasBeenSelfEmployed_Yes"));
        public IWebElement HasBeenSelfEmployed_NoButton => driver.FindElement(By.Id("HasBeenSelfEmployed_No"));
        public IWebElement HasBeenPartner_YesButton => driver.FindElement(By.Id("HasBeenPartner_Yes"));
        public IWebElement HasBeenPartner_NoButton => driver.FindElement(By.Id("HasBeenPartner_No"));
        public IWebElement HasBeenEmployed_Yes => driver.FindElement(By.Id("HasBeenEmployed_Yes"));
        public IWebElement HasBeenEmployed_No => driver.FindElement(By.Id("HasBeenEmployed_No"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));

    }
}
