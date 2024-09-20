using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PersonalDetailsPage
    {
        private IWebDriver driver;
        public PersonalDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //Buttons and PageElements
        #region Title
        public IWebElement Title_MrOption => driver.FindElement(By.Id("Title_0"));
        public IWebElement Title_MrsOption => driver.FindElement(By.Id("Title_1"));
        public IWebElement Title_MissOption => driver.FindElement(By.Id("Title_2"));
        public IWebElement Title_MsOption => driver.FindElement(By.Id("Title_3"));
        public IWebElement Title_OtherOption => driver.FindElement(By.Id("Title_Other"));
        public IWebElement OtherOption_InputField => driver.FindElement(By.Id("Title_OtherText"));
        #endregion
        public IWebElement FirstName_InputField => driver.FindElement(By.Id("FirstName"));
        public IWebElement MiddleName_InputField => driver.FindElement(By.Id("MiddleNames"));
        public IWebElement LastName_InputField => driver.FindElement(By.Id("LastName"));
        public IWebElement DateOfBirth_DayField => driver.FindElement(By.Id("DateOfBirth_Day"));
        public IWebElement DateOfBirth_MonthField => driver.FindElement(By.Id("DateOfBirth_Month"));
        public IWebElement DateOfBirth_YearField => driver.FindElement(By.Id("DateOfBirth_Year"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));
    }
}
