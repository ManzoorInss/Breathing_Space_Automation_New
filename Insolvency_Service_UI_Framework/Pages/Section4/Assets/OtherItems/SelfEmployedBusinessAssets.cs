using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class SelfEmployedBusinessAssetsPage
    {
        private IWebDriver driver;
        public SelfEmployedBusinessAssetsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement WhatAssets => driver.FindElement(By.Id("Description_0"));
        public IWebElement AssetsWorth => driver.FindElement(By.Id("Amount_0"));
        public IWebElement FirstDeleteAssets => driver.FindElement(By.Id("Delete_0"));
        public IWebElement SecondWhatAssets => driver.FindElement(By.Id("Description_1"));
        public IWebElement SecondAssetsWorth => driver.FindElement(By.Id("Amount_1"));
        public IWebElement SecondDeleteAssets => driver.FindElement(By.Id("Delete_1"));
        public IWebElement ThirdWhatAssets => driver.FindElement(By.Id("Description_2"));
        public IWebElement ThirdAssetsWorth => driver.FindElement(By.Id("Amount_2"));
        public IWebElement ThirdDeleteAssets => driver.FindElement(By.Id("Delete_2"));
        public IWebElement AddAnotherAssets => driver.FindElement(By.Id("add"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
