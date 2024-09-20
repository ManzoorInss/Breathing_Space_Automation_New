using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class MoneyOwedPage
    {
        private IWebDriver driver;
        public MoneyOwedPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement ReasonOwedMoney => driver.FindElement(By.Id("Reason_0"));
        public IWebElement WhoOwesMoney => driver.FindElement(By.Id("WhoOwesYou_0"));
        public IWebElement HowMuchOwed => driver.FindElement(By.Id("Amount_0"));
        public IWebElement FirstDeleteOwedMoney => driver.FindElement(By.Id("Delete_0"));
        public IWebElement SecondReasonOwedMoney => driver.FindElement(By.Id("Reason_1"));
        public IWebElement SecondWhoOwesMoney => driver.FindElement(By.Id("WhoOwesYou_1"));
        public IWebElement SecondHowMuchOwed => driver.FindElement(By.Id("Amount_1"));
        public IWebElement SecondDeleteOwedMoney => driver.FindElement(By.Id("Delete_1"));
        public IWebElement ThirdReasonOwedMoney => driver.FindElement(By.Id("Reason_2"));
        public IWebElement ThirdWhoOwesMoney => driver.FindElement(By.Id("WhoOwesYou_2"));
        public IWebElement ThirdHowMuchOwed => driver.FindElement(By.Id("Amount_2"));
        public IWebElement ThirdDeleteOwedMoney => driver.FindElement(By.Id("Delete_2"));
        public IWebElement AddAnotherOwedMoney => driver.FindElement(By.Id("add"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
