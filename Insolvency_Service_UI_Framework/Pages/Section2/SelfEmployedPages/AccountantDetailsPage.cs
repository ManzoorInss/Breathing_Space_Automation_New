using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AccountantDetailsPage
    {
        private IWebDriver driver;
        public AccountantDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement AccountantName_InputField => driver.FindElement(By.Id("AccountantName"));
        public IWebElement BuildingAndStreet_LineOneField => driver.FindElement(By.Id("AccountantAddress.Address_1"));
        public IWebElement BuildingAndStreet_LineTwoField => driver.FindElement(By.Id("AccountantAddress.Address_2"));
        public IWebElement BuildingAndStreet_LineThreeField => driver.FindElement(By.Id("AccountantAddress.Address_3"));
        public IWebElement TownOrCityField => driver.FindElement(By.Id("AccountantAddress.TownCity"));
        public IWebElement CountyField => driver.FindElement(By.Id("AccountantAddress.County"));
        public IWebElement PostcodeField => driver.FindElement(By.Id("AccountantAddress.Postcode"));
        public IWebElement CountryField => driver.FindElement(By.Id("AccountantAddress.Country"));
        public IWebElement AccountantStarted_MonthField => driver.FindElement(By.Id("DateStarted_Month"));
        public IWebElement AccountantStarted_YearField => driver.FindElement(By.Id("DateStarted_Year"));
        public IWebElement AccountantStopped_MonthField => driver.FindElement(By.Id("DateStopped_Month"));
        public IWebElement AccountantStopped_YearField => driver.FindElement(By.Id("DateStopped_Year"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
