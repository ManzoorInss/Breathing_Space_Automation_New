using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AdminLoginPage
    {
        private IWebDriver driver;
        public AdminLoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("/html/body/main/div/div[2]/h1"));

        // Buttons and Elements
        
        public IWebElement Username => driver.FindElement(By.Id("UserName"));
        public IWebElement Password => driver.FindElement(By.Id("Password"));
        public IWebElement Login => driver.FindElement(By.Id("Continue"));
    }
}
