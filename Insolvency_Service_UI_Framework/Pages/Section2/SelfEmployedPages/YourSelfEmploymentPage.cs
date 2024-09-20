using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class YourSelfEmploymentPage
    {
        private IWebDriver driver;
        public YourSelfEmploymentPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));  
        public IWebElement Edit_BusinessName => driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/a[1]"));
        public IWebElement Edit_TradedAs => driver.FindElement(By.XPath("//tbody/tr[2]/td[3]/a[1]"));
        public IWebElement Edit_StartedTrading => driver.FindElement(By.XPath("//tbody/tr[3]/td[3]/a[1]"));
        public IWebElement Edit_StoppedTrading => driver.FindElement(By.XPath("//tbody/tr[4]/td[3]/a[1]"));
        public IWebElement Edit_UTR => driver.FindElement(By.XPath("//tbody/tr[5]/td[3]/a[1]"));
        public IWebElement Edit_BusineessAddresses => driver.FindElement(By.XPath("//tbody/tr[6]/td[3]/a[1]"));
        public IWebElement Edit_NumberofCurrentEmployees => driver.FindElement(By.XPath("//tbody/tr[7]/td[3]/a[1]"));
        public IWebElement Edit_NoOfFormerEmployees => driver.FindElement(By.XPath("//tbody/tr[8]/td[3]/a[1]"));
        public IWebElement Edit_LocationofAccoutningRecords => driver.FindElement(By.XPath("//tbody/tr[9]/td[3]/a[1]"));
        public IWebElement Edit_NoofAccountants => driver.FindElement(By.XPath("//tbody/tr[10]/td[3]/a[1]"));
        public IWebElement Continue_Button => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
