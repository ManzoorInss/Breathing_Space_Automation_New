using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class EmploymentHistoryPage
    {
        private IWebDriver driver;
        public EmploymentHistoryPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement EmployerNameInput => driver.FindElement(By.Id("EmployerName"));
        public IWebElement AddEmployerButton => driver.FindElement(By.Id("add"));
        public IWebElement ContinueNoEmployersButton => driver.FindElement(By.Id("next"));
        public IWebElement ContinueAllEmployersButton => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
