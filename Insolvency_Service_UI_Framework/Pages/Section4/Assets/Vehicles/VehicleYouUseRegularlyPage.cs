using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class VehicleYouUseRegularlyPage
    {
        private IWebDriver driver;
        public VehicleYouUseRegularlyPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement OwnerName => driver.FindElement(By.Id("OwnerName"));
        public IWebElement HusbandWifePartner => driver.FindElement(By.Id("RelationshipType_0"));
        public IWebElement Employer => driver.FindElement(By.Id("RelationshipType_1"));
        public IWebElement CompanyDirector => driver.FindElement(By.Id("RelationshipType_2"));
        public IWebElement Other => driver.FindElement(By.Id("RelationshipType_Other"));
        public IWebElement OtherSpecify => driver.FindElement(By.Id("RelationshipType_OtherText"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
