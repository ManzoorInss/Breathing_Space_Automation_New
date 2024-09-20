using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class VehicleDisposalPage
    {
        private IWebDriver driver;
        public VehicleDisposalPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement ReceivedSale => driver.FindElement(By.Id("Amount"));
        public IWebElement Continue => driver.FindElement(By.Id("continue"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
