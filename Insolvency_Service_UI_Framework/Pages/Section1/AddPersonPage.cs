using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AddPersonPage
    {
        private IWebDriver driver;
        public AddPersonPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        //Page Elements

        public IWebElement FirstName_InputField => driver.FindElement(By.Id("FirstName"));
        public IWebElement LastName_InputField => driver.FindElement(By.Id("LastName"));

        #region AgeGroup
        public IWebElement AgeGroup_0_3 => driver.FindElement(By.Id("AgeGroup_0"));
        public IWebElement AgeGroup_4_11 => driver.FindElement(By.Id("AgeGroup_1"));
        public IWebElement AgeGroup_12_18 => driver.FindElement(By.Id("AgeGroup_2"));
        public IWebElement AgeGroup_19_23 => driver.FindElement(By.Id("AgeGroup_3"));
        public IWebElement AgeGroup_24_30 => driver.FindElement(By.Id("AgeGroup_4"));
        public IWebElement AgeGroup_31_50 => driver.FindElement(By.Id("AgeGroup_5"));
        public IWebElement AgeGroup_51_64 => driver.FindElement(By.Id("AgeGroup_6"));
        public IWebElement AgeGroup_65_Over => driver.FindElement(By.Id("AgeGroup_7"));
        #endregion
        public IWebElement Relationship_HusbandWifePartnerOption => driver.FindElement(By.Id("Relationship_0"));
        public IWebElement Relationship_ChildOption => driver.FindElement(By.Id("Relationship_1"));
        public IWebElement Relationship_OtherOption => driver.FindElement(By.Id("Relationship_Other"));
        public IWebElement OtherOption_InputField => driver.FindElement(By.Id("Relationship_OtherText"));
        public IWebElement FinanciallyDependant_YesOption => driver.FindElement(By.Id("FinanciallyDependentOption_0"));
        public IWebElement FinanciallyDependant_NoOption => driver.FindElement(By.Id("FinanciallyDependentOption_1"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
