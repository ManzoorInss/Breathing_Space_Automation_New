using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class MoneyYouOwePage
    {
        private IWebDriver driver;
        public MoneyYouOwePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement CreditorName => driver.FindElement(By.Id("SearchText"));
        public IWebElement AddCreditor => driver.FindElement(By.Id("Search"));
        public IWebElement FirstDebtEdit => driver.FindElement(By.XPath("/html/body/main/div/div[2]/form/div/table/tbody/tr[1]/td[5]/span/input"));
        public IWebElement FirstDebtDelete => driver.FindElement(By.XPath("/html/body/main/div/div[2]/form/div/table/tbody/tr[1]/td[6]/span/input"));
        public IWebElement SecondDebtEdit => driver.FindElement(By.XPath("/html/body/main/div/div[2]/form/div/table/tbody/tr[2]/td[5]/span/input"));
        public IWebElement SecondDebtDelete => driver.FindElement(By.XPath("/html/body/main/div/div[2]/form/div/table/tbody/tr[2]/td[6]/span/input"));
        public IWebElement ContinueAddedAllCreditors => driver.FindElement(By.Id("continue"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
