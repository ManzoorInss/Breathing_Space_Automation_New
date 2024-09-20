using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class OtherNameOrAliasPage
    {
        private IWebDriver driver;
        public OtherNameOrAliasPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        //Buttons and PageElements
        public IWebElement FirstName_InputField => driver.FindElement(By.Id("FirstName"));
        public IWebElement LastName_InputField => driver.FindElement(By.Id("LastName"));
        public IWebElement AddNameButton => driver.FindElement(By.Id("add"));
        public IWebElement Continue_NoOtherNames => driver.FindElement(By.Id("NoOtherNames"));
        public IWebElement Continue_AllNamesAdded => driver.FindElement(By.Id("NoOtherNames"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
