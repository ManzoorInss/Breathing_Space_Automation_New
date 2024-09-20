﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class FormerEmployeesClaimingMoneyPage
    {
        private IWebDriver driver;
        public FormerEmployeesClaimingMoneyPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement FirstName_InputField => driver.FindElement(By.Id("FirstName"));
        public IWebElement LastName_InputField => driver.FindElement(By.Id("LastName"));
        public IWebElement AddEmployeeButton => driver.FindElement(By.Id("next"));
        public IWebElement ContinueButton_NoFormerEmployees => driver.FindElement(By.Id("noFormerEmployees"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
