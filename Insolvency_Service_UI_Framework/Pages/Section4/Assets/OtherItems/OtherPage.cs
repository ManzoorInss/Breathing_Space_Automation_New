using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class OtherPage
    {
        private IWebDriver driver;
        public OtherPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement WhatOther => driver.FindElement(By.Id("Description_0"));
        public IWebElement OtherWorth => driver.FindElement(By.Id("Amount_0"));
        public IWebElement FirstDeleteOther => driver.FindElement(By.Id("Delete_0"));
        public IWebElement SecondWhatOther => driver.FindElement(By.Id("Description_1"));
        public IWebElement SecondOtherWorth => driver.FindElement(By.Id("Amount_1"));
        public IWebElement SecondDeleteOther => driver.FindElement(By.Id("Delete_1"));
        public IWebElement ThirdWhatOther => driver.FindElement(By.Id("Description_2"));
        public IWebElement ThirdOtherWorth => driver.FindElement(By.Id("Amount_2"));
        public IWebElement ThirdDeleteOther => driver.FindElement(By.Id("Delete_2"));
        public IWebElement AddAnotherOther => driver.FindElement(By.Id("add"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
