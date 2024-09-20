using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AssetsPage
    {
        private IWebDriver driver;
        public AssetsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement Properties_Yes => driver.FindElement(By.Id("PropertyYes"));
        public IWebElement Properties_No => driver.FindElement(By.Id("PropertyNo"));
        public IWebElement Vehicles_Yes => driver.FindElement(By.Id("VehicleYes"));
        public IWebElement Vehicles_No => driver.FindElement(By.Id("VehicleNo"));
        public IWebElement PensionInsurance_Yes => driver.FindElement(By.Id("InsuranceYes"));
        public IWebElement PensionInsurance_No => driver.FindElement(By.Id("InsuranceNo"));
        public IWebElement OtherItems_Start => driver.FindElement(By.Id("OtherAssetsStart"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
