using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class StocksSharesInvestmentsPage
    {
        private IWebDriver driver;
        public StocksSharesInvestmentsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement WhatStocksShares => driver.FindElement(By.Id("Description_0"));
        public IWebElement StocksSharesWorth => driver.FindElement(By.Id("Amount_0"));
        public IWebElement FirstDeleteStocksShares => driver.FindElement(By.Id("Delete_0"));
        public IWebElement SecondWhatStocksShares => driver.FindElement(By.Id("Description_1"));
        public IWebElement SecondStocksSharesWorth => driver.FindElement(By.Id("Amount_1"));
        public IWebElement SecondDeleteStocksShares => driver.FindElement(By.Id("Delete_1"));
        public IWebElement ThirdWhatStocksShares => driver.FindElement(By.Id("Description_2"));
        public IWebElement ThirdStocksSharesWorth => driver.FindElement(By.Id("Amount_2"));
        public IWebElement ThirdDeleteStocksShares => driver.FindElement(By.Id("Delete_2"));
        public IWebElement AddAnotherStocksShares => driver.FindElement(By.Id("add"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
