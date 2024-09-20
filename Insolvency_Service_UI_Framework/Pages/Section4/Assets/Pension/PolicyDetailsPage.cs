using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PolicyDetailsPage
    {
        private IWebDriver driver;
        public PolicyDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement WorkplacePension => driver.FindElement(By.Id("PolicyType_0"));
        public IWebElement PersonalPension => driver.FindElement(By.Id("PolicyType_1"));
        public IWebElement SelfInvestedPension => driver.FindElement(By.Id("PolicyType_2"));
        public IWebElement Endowment => driver.FindElement(By.Id("PolicyType_3"));
        public IWebElement LifeInsurance => driver.FindElement(By.Id("PolicyType_4"));
        public IWebElement Other => driver.FindElement(By.Id("PolicyType_Other"));
        public IWebElement OtherSpecify => driver.FindElement(By.Id("PolicyType_OtherText"));
        public IWebElement PolicyReferenceNumber => driver.FindElement(By.Id("PolicyReferenceNo"));
        public IWebElement PolicyStart0_12Months => driver.FindElement(By.Id("CommencementDate_0"));
        public IWebElement PolicyStart1_2Years => driver.FindElement(By.Id("CommencementDate_1"));
        public IWebElement PolicyStart3_5Years => driver.FindElement(By.Id("CommencementDate_2"));
        public IWebElement PolicyStart6_10Years => driver.FindElement(By.Id("CommencementDate_3"));
        public IWebElement PolicyStartOver10Years => driver.FindElement(By.Id("CommencementDate_4"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
