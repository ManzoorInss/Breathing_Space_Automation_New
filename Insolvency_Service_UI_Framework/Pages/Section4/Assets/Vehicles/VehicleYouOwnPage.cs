using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class VehicleYouOwnPage
    {
        private IWebDriver driver;
        public VehicleYouOwnPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement VehicleWorth => driver.FindElement(By.Id("Price"));
        public IWebElement WorkAndCommuting => driver.FindElement(By.Id("VehicleUses_0"));
        public IWebElement ChildrenToSchool => driver.FindElement(By.Id("VehicleUses_1"));
        public IWebElement CaringForRelative => driver.FindElement(By.Id("VehicleUses_2"));
        public IWebElement Socialising => driver.FindElement(By.Id("VehicleUses_3"));
        public IWebElement Other => driver.FindElement(By.Id("VehicleUses_Other"));
        public IWebElement OtherSpecify => driver.FindElement(By.Id("VehicleUses_OtherText"));
        public IWebElement Continue => driver.FindElement(By.Id("continue"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
