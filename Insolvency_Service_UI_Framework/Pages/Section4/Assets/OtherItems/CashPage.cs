﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class CashPage
    {
        private IWebDriver driver;
        public CashPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement HowMuchCash => driver.FindElement(By.Id("Amount"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}