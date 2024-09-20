using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class BeneficiaryDetailsPage
    {
        private IWebDriver driver;
        public BeneficiaryDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement FirstName => driver.FindElement(By.Id("FirstName"));
        public IWebElement LastName => driver.FindElement(By.Id("LastName"));
        public IWebElement HusbandWifePartner => driver.FindElement(By.Id("Relationship_0"));
        public IWebElement Child => driver.FindElement(By.Id("Relationship_1"));
        public IWebElement Other => driver.FindElement(By.Id("Relationship_Other"));
        public IWebElement OtherSpecify => driver.FindElement(By.Id("Relationship_OtherText"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
