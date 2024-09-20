using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AmountYouOwePage
    {
        private IWebDriver driver;
        public AmountYouOwePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement Amount => driver.FindElement(By.Id("Amount"));
        public IWebElement AccountReferenceNumber => driver.FindElement(By.Id("Reference"));
        public IWebElement CreditCardStoreCard => driver.FindElement(By.Id("DebtType_0"));
        public IWebElement PersonalLoanUnsecured => driver.FindElement(By.Id("DebtType_1"));
        public IWebElement RentArrears => driver.FindElement(By.Id("DebtType_2"));
        public IWebElement Utilities => driver.FindElement(By.Id("DebtType_3"));
        public IWebElement TelephoneMobilePhone => driver.FindElement(By.Id("DebtType_4"));
        public IWebElement Other => driver.FindElement(By.Id("DebtType_Other"));
        public IWebElement OtherSpecify => driver.FindElement(By.Id("DebtType_OtherText"));
        public IWebElement DebtStarted_0_6Months => driver.FindElement(By.Id("ApproxDebtStartedDateRange_0"));
        public IWebElement DebtStarted_7_12Months => driver.FindElement(By.Id("ApproxDebtStartedDateRange_1"));
        public IWebElement DebtStarted_1_2Years => driver.FindElement(By.Id("ApproxDebtStartedDateRange_2"));
        public IWebElement DebtStarted_3_5Years => driver.FindElement(By.Id("ApproxDebtStartedDateRange_3"));
        public IWebElement DebtStarted_6_10Years => driver.FindElement(By.Id("ApproxDebtStartedDateRange_4"));
        public IWebElement DebtStartedOver10Years => driver.FindElement(By.Id("ApproxDebtStartedDateRange_5"));
        public IWebElement Continue => driver.FindElement(By.Id("continue"));
        public IWebElement Back => driver.FindElement(By.Id("backtoedit"));

    }
}
