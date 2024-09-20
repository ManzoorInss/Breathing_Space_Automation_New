using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class YourSelfEmployedBusinnessesPage
    {
        private IWebDriver driver;
        public YourSelfEmployedBusinnessesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //PageElements
        public IWebElement BusinessName_InputField => driver.FindElement(By.Id("BusinessName"));
        public IWebElement AddBusinessButton => driver.FindElement(By.Id("add"));
        public IWebElement Continue_NotBeenSlefEmployedButton => driver.FindElement(By.Id("next"));
        public IWebElement Continue_AddedAllSelfEmploymentsButton => driver.FindElement(By.Id("next"));

    }
}
