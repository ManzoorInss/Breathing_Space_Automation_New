using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class VehiclesPage
    {
        private IWebDriver driver;
        public VehiclesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement Make => driver.FindElement(By.Id("Make"));
        public IWebElement Model => driver.FindElement(By.Id("Model"));
        public IWebElement FirstVehicleEdit => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[1]/div/table/tbody/tr/td[6]/span/input"));
        public IWebElement FirstVehicleDelete => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[1]/div/table/tbody/tr/td[7]/span/input"));
        public IWebElement AddVehicle => driver.FindElement(By.Id("add"));
        public IWebElement ContinueNoVehicles => driver.FindElement(By.Id("continue"));
        public IWebElement ContinueAddedAllVehicles => driver.FindElement(By.Id("continue"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
