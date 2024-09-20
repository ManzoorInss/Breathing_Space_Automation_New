using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class CompensationLegalPage
    {
        private IWebDriver driver;
        public CompensationLegalPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement ClaimDescription => driver.FindElement(By.Id("Description_0"));
        public IWebElement ClaimWorth => driver.FindElement(By.Id("Amount_0"));
        public IWebElement FirstDeleteClaim => driver.FindElement(By.Id("Delete_0"));
        public IWebElement SecondClaimDescription => driver.FindElement(By.Id("Description_1"));
        public IWebElement SecondClaimWorth => driver.FindElement(By.Id("Amount_1"));
        public IWebElement SecondDeleteClaim => driver.FindElement(By.Id("Delete_1"));
        public IWebElement ThirdClaimDescription => driver.FindElement(By.Id("Description_2"));
        public IWebElement ThirdClaimWorth => driver.FindElement(By.Id("Amount_2"));
        public IWebElement ThirdDeleteClaim => driver.FindElement(By.Id("Delete_2"));
        public IWebElement AddAnotherClaim => driver.FindElement(By.Id("add"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
