using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class VehiclesDetailsPage
    {
        private IWebDriver driver;
        public VehiclesDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement Make => driver.FindElement(By.Id("Make"));
        public IWebElement Model => driver.FindElement(By.Id("Model"));
        public IWebElement RegistrationNumber => driver.FindElement(By.Id("RegistrationNumber"));
        public IWebElement Car => driver.FindElement(By.Id("VehicleType_0"));
        public IWebElement Van => driver.FindElement(By.Id("VehicleType_1"));
        public IWebElement Motorcycle => driver.FindElement(By.Id("VehicleType_2"));
        public IWebElement Other => driver.FindElement(By.Id("VehicleType_Other"));
        public IWebElement OtherSpecify => driver.FindElement(By.Id("VehicleType_OtherText"));
        public IWebElement CurrentlyOwn => driver.FindElement(By.Id("NatureOfInterestInVehicle_0"));
        public IWebElement SoldDisposed => driver.FindElement(By.Id("NatureOfInterestInVehicle_1"));
        public IWebElement DoNotOwnButUse => driver.FindElement(By.Id("NatureOfInterestInVehicle_2"));
        public IWebElement Motability => driver.FindElement(By.Id("NatureOfInterestInVehicle_3"));
        public IWebElement Continue => driver.FindElement(By.Id("continue"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
