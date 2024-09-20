using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AdminLandingPage
    {
        private IWebDriver driver;
        public AdminLandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//*[@id=\"main-message\"]/h1"));

        // Buttons and Elements
        
        public IWebElement Details => driver.FindElement(By.Id("details-button"));
        public IWebElement ProceedLink => driver.FindElement(By.Id("proceed-link"));
    }
}
