using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class WorldPayPage
    {
        private IWebDriver driver;
        public WorldPayPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //Buttons and PageElements
        public IWebElement CardNumber => driver.FindElement(By.Id("cardNumber"));
        public IWebElement CardholderNumber => driver.FindElement(By.Id("cardholderName"));
        public IWebElement ExpiryMonth => driver.FindElement(By.Id("expiryMonth"));
        public IWebElement ExpiryYear => driver.FindElement(By.Id("expiryYear"));
        public IWebElement SecurityCode => driver.FindElement(By.Id("securityCode"));
        public IWebElement Cancel => driver.FindElement(By.Id("next"));
        public IWebElement MakePayment => driver.FindElement(By.Id("submitButton"));

    }
}
