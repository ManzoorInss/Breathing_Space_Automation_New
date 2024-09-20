using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class VehicleDisposedPage
    {
        private IWebDriver driver;
        public VehicleDisposedPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement SoldMonth => driver.FindElement(By.Id("SoldOrDisposedDate_Month"));
        public IWebElement SoldYear => driver.FindElement(By.Id("SoldOrDisposedDate_Year"));
        public IWebElement Sold => driver.FindElement(By.Id("WhatHappened_0"));
        public IWebElement Scrapped => driver.FindElement(By.Id("WhatHappened_1"));
        public IWebElement Repossessed => driver.FindElement(By.Id("WhatHappened_2"));
        public IWebElement Returned => driver.FindElement(By.Id("WhatHappened_3"));
        public IWebElement Continue => driver.FindElement(By.Id("continue"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
