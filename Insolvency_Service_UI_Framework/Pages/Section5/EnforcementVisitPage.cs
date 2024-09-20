using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class EnforcementVisitPage
    {
        private IWebDriver driver;
        public EnforcementVisitPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement Visit_Month => driver.FindElement(By.Id("VisitDate_Month"));
        public IWebElement Visit_Year => driver.FindElement(By.Id("VisitDate_Year"));
        public IWebElement TakenControl_Yes => driver.FindElement(By.Id("ItemsSeizedOrSold_0"));
        public IWebElement TakenControl_No => driver.FindElement(By.Id("ItemsSeizedOrSold_1"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
