using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class ContinueToApplicationPage
    {
        private IWebDriver driver;
        public ContinueToApplicationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        public IWebElement YourSecurityQuestionInputField => driver.FindElement(By.Id("SecurityAnswer"));
        public IWebElement ForgottenApplicationDetailsLink => driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div/form/div[1]/a"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));

    }
}

