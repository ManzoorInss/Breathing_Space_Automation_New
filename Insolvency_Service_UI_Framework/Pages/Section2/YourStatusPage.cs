using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class YourStatusPage
    {
        private IWebDriver driver;
        public YourStatusPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement Retired => driver.FindElement(By.Id("Status_0"));
        public IWebElement Student => driver.FindElement(By.Id("Status_1"));
        public IWebElement AFullTimeCarer => driver.FindElement(By.Id("Status_2"));
        public IWebElement CurrentlyNotWorking => driver.FindElement(By.Id("Status_3"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
