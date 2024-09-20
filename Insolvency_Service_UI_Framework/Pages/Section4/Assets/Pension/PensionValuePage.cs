using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PensionValuePage
    {
        private IWebDriver driver;
        public PensionValuePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement ReceivingPaymentsYes => driver.FindElement(By.Id("CurrentlyReceivingPaymentOptions_0"));
        public IWebElement ReceivingPaymentsNo => driver.FindElement(By.Id("CurrentlyReceivingPaymentOptions_1"));
        public IWebElement PensionWorth => driver.FindElement(By.Id("CurrentWorth"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
