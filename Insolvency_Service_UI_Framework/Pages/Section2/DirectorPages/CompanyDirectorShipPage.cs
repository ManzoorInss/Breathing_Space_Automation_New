using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class CompanyDirectorShipPage
    {
        private IWebDriver driver;
        public CompanyDirectorShipPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement LimitedCompanyName_InputField => driver.FindElement(By.Id("LimitedCompanyName"));
        public IWebElement AddDirectorshipButton => driver.FindElement(By.Id("add"));
        public IWebElement Edit => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[1]/table/tbody/tr/td[5]/span/a"));
        public IWebElement Delete => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[1]/table/tbody/tr/td[6]/span/input"));
        public IWebElement Continue_HaveNoneoneButton => driver.FindElement(By.Id("continuehavenone"));
        public IWebElement Continue_AddedAllButton => driver.FindElement(By.Id("continueaddedall"));
    }
}
