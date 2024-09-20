using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class MoneyYouOweSummaryPage
    {
        private IWebDriver driver;
        public MoneyYouOweSummaryPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement CreditorsEdit => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[1]/table/tbody/tr/td[3]/a"));
        public IWebElement FirstEnforcementEdit => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[2]/table/tbody/tr/td[4]/span/input"));
        public IWebElement FirstEnforcementDelete => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[2]/table/tbody/tr/td[5]/span/input"));
        public IWebElement FirstAttachmentOfEarningsEdit => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[3]/table/tbody/tr/td[4]/span/input"));
        public IWebElement FIrstAttachmentOfEarningsDelete => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[3]/table/tbody/tr/td[5]/span/input"));
        public IWebElement ContinueAddedAllCreditors => driver.FindElement(By.Id("next"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
