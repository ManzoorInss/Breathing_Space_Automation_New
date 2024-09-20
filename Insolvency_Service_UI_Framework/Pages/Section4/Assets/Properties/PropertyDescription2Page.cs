using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PropertyDescriptionPage
    {
        private IWebDriver driver;
        public PropertyDescriptionPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement DetachedHouse => driver.FindElement(By.Id("PropertyType_0"));
        public IWebElement SemiDetachedHouse => driver.FindElement(By.Id("PropertyType_1"));
        public IWebElement TerracedHouse => driver.FindElement(By.Id("PropertyType_2"));
        public IWebElement FlatMaisonette => driver.FindElement(By.Id("PropertyType_3"));
        public IWebElement Other => driver.FindElement(By.Id("PropertyType_4"));
        public IWebElement OtherSpecify => driver.FindElement(By.Id("PropertyType_OtherText"));

        public IWebElement PostalCode => driver.FindElement(By.Id("PostalCode"));
        public IWebElement AddProperty => driver.FindElement(By.Id("add"));
        public IWebElement ContinueNoProperties => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
