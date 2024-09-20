using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PaymentAcknowledgementPage
    {
        private IWebDriver driver;
        public PaymentAcknowledgementPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //Buttons and PageElements
        public IWebElement ReturnToApplication => driver.FindElement(By.Id("next"));
        

    }
}
