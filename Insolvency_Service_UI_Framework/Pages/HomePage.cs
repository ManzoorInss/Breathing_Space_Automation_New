using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements
        
        public IWebElement CreateMyAccountButton => driver.FindElement(By.Id("next"));
        public IWebElement Documents => driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/form/div/div[2]/p/a"));
        public IWebElement ReturnToExistingApplicationLink => driver.FindElement(By.XPath("//a[normalize-space()='Return to an existing application']"));

    }
}
