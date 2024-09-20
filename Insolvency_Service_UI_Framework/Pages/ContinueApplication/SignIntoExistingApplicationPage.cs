using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class SignIntoExistingApplicationPage
    {
        private IWebDriver driver;
        public SignIntoExistingApplicationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        public IWebElement ApplicationNumberInputField => driver.FindElement(By.Id("Urn"));
        public IWebElement ForgottenApplicationNumberLink => driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div/form/div[2]/div/p[2]/a"));    
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}