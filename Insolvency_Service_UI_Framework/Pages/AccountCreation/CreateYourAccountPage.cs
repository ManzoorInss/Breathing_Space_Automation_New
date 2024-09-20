using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class CreateYourAccountPage
    {
        private IWebDriver driver;
        public CreateYourAccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements
        public IWebElement FirstNameInputField => driver.FindElement(By.Id("FirstName"));
        public IWebElement MiddleNameInputField => driver.FindElement(By.Id("MiddleNames"));
        public IWebElement LastNameInputField => driver.FindElement(By.Id("LastName"));
        public IWebElement DateofBirth_DayField => driver.FindElement(By.Id("DateOfBirth_Day"));
        public IWebElement DateofBirth_MonthField => driver.FindElement(By.Id("DateOfBirth_Month"));
        public IWebElement DateofBirth_YearField => driver.FindElement(By.Id("DateOfBirth_Year")); 
        public IWebElement EmailField => driver.FindElement(By.Id("Email"));
        public IWebElement ConfirmEmailField => driver.FindElement(By.Id("ConfirmEmail"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));

    }
}
