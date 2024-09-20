using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class ItemsPossessionsPage
    {
        private IWebDriver driver;
        public ItemsPossessionsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement WhatItem => driver.FindElement(By.Id("Description_0"));
        public IWebElement ItemWorth => driver.FindElement(By.Id("Amount_0"));
        public IWebElement FirstDeleteItem => driver.FindElement(By.Id("Delete_0"));
        public IWebElement SecondWhatItem => driver.FindElement(By.Id("Description_1"));
        public IWebElement SecondItemWorth => driver.FindElement(By.Id("Amount_1"));
        public IWebElement SecondDeleteItem => driver.FindElement(By.Id("Delete_1"));
        public IWebElement ThirdWhatItem => driver.FindElement(By.Id("Description_2"));
        public IWebElement ThirdItemWorth => driver.FindElement(By.Id("Amount_2"));
        public IWebElement ThirdDeleteItem => driver.FindElement(By.Id("Delete_2"));
        public IWebElement AddAnotherItem => driver.FindElement(By.Id("add"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
