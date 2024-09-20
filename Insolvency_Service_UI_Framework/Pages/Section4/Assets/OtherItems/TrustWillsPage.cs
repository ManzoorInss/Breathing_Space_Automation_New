using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class TrustWillsPage
    {
        private IWebDriver driver;
        public TrustWillsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement WhatWill => driver.FindElement(By.Id("Description_0"));
        public IWebElement WillWorth => driver.FindElement(By.Id("Amount_0"));
        public IWebElement FirstDeleteWill => driver.FindElement(By.Id("Delete_0"));
        public IWebElement SecondWhatWill => driver.FindElement(By.Id("Description_1"));
        public IWebElement SecondWillWorth => driver.FindElement(By.Id("Amount_1"));
        public IWebElement SecondDeleteWill => driver.FindElement(By.Id("Delete_1"));
        public IWebElement ThirdWhatWill => driver.FindElement(By.Id("Description_2"));
        public IWebElement ThirdWillWorth => driver.FindElement(By.Id("Amount_2"));
        public IWebElement ThirdDeleteWill => driver.FindElement(By.Id("Delete_2"));
        public IWebElement AddAnotherWill => driver.FindElement(By.Id("add"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
