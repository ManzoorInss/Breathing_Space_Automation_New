﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class InsolvencyPractitionerPage
    {
        private IWebDriver driver;
        public InsolvencyPractitionerPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //PageElements
        public IWebElement FirstName_InputField => driver.FindElement(By.Id("FirstName"));
        public IWebElement LastName_InputField => driver.FindElement(By.Id("LastName"));
        public IWebElement BuildingAndStreet_LineOneField => driver.FindElement(By.Id("Address.Address_1"));
        public IWebElement BuildingAndStreet_LineTwoField => driver.FindElement(By.Id("Address.Address_2"));
        public IWebElement BuildingAndStreet_LineThreeField => driver.FindElement(By.Id("Address.Address_3"));
        public IWebElement TownOrCityField => driver.FindElement(By.Id("Address.TownCity"));
        public IWebElement CountyField => driver.FindElement(By.Id("Address.County"));
        public IWebElement PostcodeField => driver.FindElement(By.Id("Address.Postcode"));
        public IWebElement CountryField => driver.FindElement(By.Id("Address.Country"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
