using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class BankDetailsPage
    {
        private IWebDriver driver;
        public BankDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements

        public IWebElement BankName => driver.FindElement(By.Id("BankName"));
        public IWebElement BankSortCode => driver.FindElement(By.Id("SortCode"));
        public IWebElement AddressLine1 => driver.FindElement(By.Id("AddressLine1"));
        public IWebElement AddressLine2 => driver.FindElement(By.Id("AddressLine2"));
        public IWebElement AddressLine3 => driver.FindElement(By.Id("AddressLine3"));
        public IWebElement TownCity => driver.FindElement(By.Id("TownCity"));
        public IWebElement County => driver.FindElement(By.Id("County"));
        public IWebElement PostalCode => driver.FindElement(By.Id("PostalCode"));
        public IWebElement Country => driver.FindElement(By.Id("Country"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
