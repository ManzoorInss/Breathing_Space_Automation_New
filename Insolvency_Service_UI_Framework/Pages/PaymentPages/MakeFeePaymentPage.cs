using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class MakeFeePaymentPage
    {
        private IWebDriver driver;
        public MakeFeePaymentPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //Buttons and PageElements
        public IWebElement Amount => driver.FindElement(By.Id("Amount"));
        public IWebElement MakeACardPayment => driver.FindElement(By.Id("next"));

    }
}
