using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class VehicleFinancePage
    {
        private IWebDriver driver;
        public VehicleFinancePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement FinanceCompany => driver.FindElement(By.Id("SearchText"));
        public IWebElement AddFinanceCompany => driver.FindElement(By.Id("Search"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
