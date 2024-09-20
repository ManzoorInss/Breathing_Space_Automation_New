using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PersonalDetails2Page
    {
        private IWebDriver driver;
        public PersonalDetails2Page(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //Buttons and PageElements
        public IWebElement Gender_WomanOption => driver.FindElement(By.Id("Gender_0"));
        public IWebElement Gender_ManOption => driver.FindElement(By.Id("Gender_1"));
        public IWebElement Gender_NotToSayOption => driver.FindElement(By.Id("Gender_2"));
        public IWebElement NINumber_InputField => driver.FindElement(By.Id("NationalInsuranceNumber"));
        public IWebElement RelationShipStatus_SingleOption => driver.FindElement(By.Id("RelationshipStatus_0"));
        public IWebElement RelationShipStatus_MarriedOption => driver.FindElement(By.Id("RelationshipStatus_1"));
        public IWebElement RelationShipStatus_CoHabitingOption => driver.FindElement(By.Id("RelationshipStatus_2"));
        public IWebElement RelationShipStatus_DivorcedOption => driver.FindElement(By.Id("RelationshipStatus_3"));
        public IWebElement RelationShipStatus_WidowedOption => driver.FindElement(By.Id("RelationshipStatus_4"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));

        //Validations
        public IWebElement EnterYourGender => driver.FindElement(By.XPath("//a[normalize-space()='Please enter your gender']"));
        public IWebElement EnterYourNINumber => driver.FindElement(By.XPath("//a[normalize-space()='Please enter your national insurance number']"));
        public IWebElement EnterYourRelationShipStatus => driver.FindElement(By.XPath("//a[normalize-space()='Please enter your current relationship status.']"));

    }
}
