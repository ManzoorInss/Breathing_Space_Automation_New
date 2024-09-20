using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AttachmentOfEarningsPage
    {
        private IWebDriver driver;
        public AttachmentOfEarningsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement DeductedFromIncome => driver.FindElement(By.Id("AmountTaken"));
        public IWebElement FrequencyOfDeduction => driver.FindElement(By.Id("HowOftenTaken"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
