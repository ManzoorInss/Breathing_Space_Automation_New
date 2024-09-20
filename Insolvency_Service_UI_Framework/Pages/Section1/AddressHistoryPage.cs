using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AddressHistoryPage
    {
        private IWebDriver driver;
        public AddressHistoryPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement EditAddress => driver.FindElement(By.XPath("//*[@id=\"AddressHistory_Table\"]/tbody/tr/td[4]/span/a"));
        public IWebElement Continue_Button => driver.FindElement(By.Id("next"));

    }
}
