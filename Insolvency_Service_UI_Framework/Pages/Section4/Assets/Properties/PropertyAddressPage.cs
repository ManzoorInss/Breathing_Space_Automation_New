using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PropertiesPage
    {
        private IWebDriver driver;
        public PropertiesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement FirstLine => driver.FindElement(By.Id("FirstLine"));
        public IWebElement PostalCode => driver.FindElement(By.Id("PostalCode"));
        public IWebElement AddProperty => driver.FindElement(By.Id("add"));
        public IWebElement ContinueNoProperties => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
