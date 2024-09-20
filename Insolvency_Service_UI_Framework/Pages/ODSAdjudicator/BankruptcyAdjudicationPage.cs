using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class BankruptcyAdjudicationPage
    {
        private IWebDriver driver;
        public BankruptcyAdjudicationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("/html/body/main/div/div[2]/h1"));

        #region Headings
        public IWebElement PersonalDetails => driver.FindElement(By.Id("//*[@id=\"myTab\"]/li[1]/a"));
        public IWebElement Refs => driver.FindElement(By.XPath("//*[@id=\"myTab\"]/li[2]/a"));
        public IWebElement Scoring => driver.FindElement(By.XPath("//*[@id=\"tab1\"]"));
        public IWebElement Credit => driver.FindElement(By.XPath("//*[@id=\"creditCheck\"]"));
        public IWebElement OrderPreview => driver.FindElement(By.XPath("//*[@id=\"myTab\"]/li[5]/a"));
        public IWebElement Notes => driver.FindElement(By.XPath("//*[@id=\"tab3\"]"));
        public IWebElement Documents => driver.FindElement(By.XPath("//*[@id=\"myTab\"]/li[7]/a"));
        public IWebElement ActionsLog => driver.FindElement(By.XPath("//*[@id=\"myTab\"]/li[8]/a"));
        #endregion

        #region Personal Details Subheadings
        public IWebElement Names => driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[2]/div[1]/div[2]/div/div[1]/div/div/div[1]/ul/li[1]/a"));
        public IWebElement Employment => driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[2]/div[1]/div[2]/div/div[1]/div/div/div[1]/ul/li[2]/a"));
        public IWebElement Assets => driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[2]/div[1]/div[2]/div/div[1]/div/div/div[1]/ul/li[3]/a"));
        public IWebElement UnsecuredLiabilities => driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[2]/div[1]/div[2]/div/div[1]/div/div/div[1]/ul/li[4]/a"));
        public IWebElement LegalProceedings => driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[2]/div[1]/div[2]/div/div[1]/div/div/div[1]/ul/li[5]/a"));
        #endregion

    }
}
