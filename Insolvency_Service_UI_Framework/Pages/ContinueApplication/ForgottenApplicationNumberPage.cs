using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    internal class ForgottenApplicationNumberPage
    {
        private IWebDriver driver;
        public ForgottenApplicationNumberPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/h1"));

        //Page Elements

        public IWebElement FirstName => driver.FindElement(By.Id("FirstName"));
        public IWebElement LastName => driver.FindElement(By.Id("LastName"));
        public IWebElement EmailAddress => driver.FindElement(By.Id("Email"));

        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
