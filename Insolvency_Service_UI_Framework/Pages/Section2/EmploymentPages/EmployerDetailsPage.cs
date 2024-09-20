using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class EmployerDetailsPage
    {
        private IWebDriver driver;
        public EmployerDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        //PageElements
        public IWebElement EmployerName => driver.FindElement(By.Id("EmployerName"));
        public IWebElement AddressLine1 => driver.FindElement(By.Id("EmployerAddress.Address_1"));
        public IWebElement AddressLine2 => driver.FindElement(By.Id("EmployerAddress.Address_2"));
        public IWebElement AddressLine3 => driver.FindElement(By.Id("EmployerAddress.Address_3"));
        public IWebElement TownCity => driver.FindElement(By.Id("EmployerAddress.TownCity"));
        public IWebElement County => driver.FindElement(By.Id("EmployerAddress.County"));
        public IWebElement Postcode => driver.FindElement(By.Id("EmployerAddress.Postcode"));
        public IWebElement Country => driver.FindElement(By.Id("EmployerAddress.Country"));
        public IWebElement MonthStarted => driver.FindElement(By.Id("DateStarted_Month"));
        public IWebElement YearStarted => driver.FindElement(By.Id("DateStarted_Year"));
        public IWebElement MonthStopped => driver.FindElement(By.Id("DateStopped_Month"));
        public IWebElement YearStopped => driver.FindElement(By.Id("DateStopped_Year"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));


    }
}
