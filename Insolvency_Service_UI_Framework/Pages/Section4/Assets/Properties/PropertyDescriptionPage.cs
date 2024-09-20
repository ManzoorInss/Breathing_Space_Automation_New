using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PropertyDescription2Page
    {
        private IWebDriver driver;
        public PropertyDescription2Page(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement SharedOwnershipYes => driver.FindElement(By.Id("SharedOwnership_0"));
        public IWebElement SharedOwnershipNo => driver.FindElement(By.Id("SharedOwnership_1"));
        public IWebElement SharedOwnershipDontKnow => driver.FindElement(By.Id("SharedOwnership_2"));
        public IWebElement Worth => driver.FindElement(By.Id("Worth"));
        public IWebElement PurchaseMonth => driver.FindElement(By.Id("PurchaseOrFinanceStartedDate_Month"));
        public IWebElement PurchaseYear => driver.FindElement(By.Id("PurchaseOrFinanceStartedDate_Year"));
        public IWebElement SoleOwner => driver.FindElement(By.Id("NatureOfInterest_0"));
        public IWebElement JointOwner => driver.FindElement(By.Id("NatureOfInterest_1"));
        public IWebElement BeneficialInterestOnly => driver.FindElement(By.Id("NatureOfInterest_2"));
        public IWebElement Other => driver.FindElement(By.Id("NatureOfInterest_Other"));
        public IWebElement OtherSpecify => driver.FindElement(By.Id("NatureOfInterest_OtherText"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
