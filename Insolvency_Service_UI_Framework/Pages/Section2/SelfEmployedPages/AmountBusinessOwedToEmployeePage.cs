using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AmountBusinessOwedToEmployeePage
    {
        private IWebDriver driver;
        public AmountBusinessOwedToEmployeePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement AmountOwed_InputField => driver.FindElement(By.Id("Amount"));
        public IWebElement ClaimReasonForAmountOwed_InputField => driver.FindElement(By.Id("Reason"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
