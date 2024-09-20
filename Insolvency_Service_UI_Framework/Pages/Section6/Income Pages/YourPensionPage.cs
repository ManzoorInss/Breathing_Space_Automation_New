using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class YourPensionPage
    {
        private IWebDriver driver;
        public YourPensionPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements
        #region First Pension
        public IWebElement FirstPensionProvider => driver.FindElement(By.Id("OtherPensions_0__Type"));
        public IWebElement FirstPensionAmount => driver.FindElement(By.Id("OtherPensions_0__Value"));
        public IWebElement FirstPensionFrequency => driver.FindElement(By.Id("OtherPensions_0__Frequency"));
        public IWebElement FirstPensionPerMonth => driver.FindElement(By.XPath("//*[@id=\"OtherPensions_0__Frequency\"]/option[1]"));
        public IWebElement FirstPensionPerWeek => driver.FindElement(By.XPath("//*[@id=\"OtherPensions_0__Frequency\"]/option[2]"));
        public IWebElement FirstPensionPerFortnight => driver.FindElement(By.XPath("//*[@id=\"OtherPensions_0__Frequency\"]/option[3]"));
        public IWebElement FirstPensionPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"OtherPensions_0__Frequency\"]/option[4]"));
        public IWebElement FirstPensionPerQuarter => driver.FindElement(By.XPath("//*[@id=\"OtherPensions_0__Frequency\"]/option[5]"));
        public IWebElement FirstPensionPerYear => driver.FindElement(By.XPath("//*[@id=\"OtherPensions_0__Frequency\"]/option[6]"));
        #endregion

        #region Second Pension
        public IWebElement SecondPensionProvider => driver.FindElement(By.Id("OtherPensions_1__Type"));
        public IWebElement SecondPensionAmount => driver.FindElement(By.Id("OtherPensions_1__Value"));
        public IWebElement SecondPensionFrequency => driver.FindElement(By.Id("OtherPensions_1__Frequency"));
        public IWebElement SecondPensionPerMonth => driver.FindElement(By.XPath("//*[@id=\"OtherPensions_0__Frequency\"]/option[1]"));
        public IWebElement SecondPensionPerWeek => driver.FindElement(By.XPath("//*[@id=\"OtherPensions_0__Frequency\"]/option[2]"));
        public IWebElement SecondPensionPerFortnight => driver.FindElement(By.XPath("//*[@id=\"OtherPensions_0__Frequency\"]/option[3]"));
        public IWebElement SecondPensionPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"OtherPensions_0__Frequency\"]/option[4]"));
        public IWebElement SecondPensionPerQuarter => driver.FindElement(By.XPath("//*[@id=\"OtherPensions_0__Frequency\"]/option[5]"));
        public IWebElement SecondPensionPerYear => driver.FindElement(By.XPath("//*[@id=\"OtherPensions_0__Frequency\"]/option[6]"));
        #endregion

        #region Additional Pensions
        public IWebElement AddAnotherPension => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/table/tbody/tr[4]/td[1]/button"));
        #endregion

        #region State Pension
        public IWebElement StatePension => driver.FindElement(By.Id("State"));
        public IWebElement StatePensionFrequency => driver.FindElement(By.Id("State_Frequency"));
        public IWebElement StatePensionPerMonth => driver.FindElement(By.XPath("//*[@id=\"State_Frequency\"]/option[1]"));
        public IWebElement StatePensionPerWeek => driver.FindElement(By.XPath("//*[@id=\"State_Frequency\"]/option[2]"));
        public IWebElement StatePensionPerFortnight => driver.FindElement(By.XPath("//*[@id=\"State_Frequency\"]/option[3]"));
        public IWebElement StatePensionPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"State_Frequency\"]/option[4]"));
        public IWebElement StatePensionPerQuarter => driver.FindElement(By.XPath("//*[@id=\"State_Frequency\"]/option[5]"));
        public IWebElement StatePensionPerYear => driver.FindElement(By.XPath("//*[@id=\"State_Frequency\"]/option[6]"));

        #endregion

        #region Pension Credit
        public IWebElement PensionCredit => driver.FindElement(By.Id("PensionCredit"));
        public IWebElement PensionCreditFrequency => driver.FindElement(By.Id("PensionCredit_Frequency"));
        public IWebElement PensionCreditPerMonth => driver.FindElement(By.Id("//*[@id=\"PensionCredit_Frequency\"]/option[1]"));
        public IWebElement PensionCreditPerWeek => driver.FindElement(By.Id("//*[@id=\"PensionCredit_Frequency\"]/option[2]"));
        public IWebElement PensionCreditPerFortnight => driver.FindElement(By.Id("//*[@id=\"PensionCredit_Frequency\"]/option[3]"));
        public IWebElement PensionCreditPer4Weeks => driver.FindElement(By.Id("//*[@id=\"PensionCredit_Frequency\"]/option[4]"));
        public IWebElement PensionCreditPerQuarter => driver.FindElement(By.Id("//*[@id=\"PensionCredit_Frequency\"]/option[5]"));
        public IWebElement PensionCreditPerYear => driver.FindElement(By.Id("//*[@id=\"PensionCredit_Frequency\"]/option[6]"));


        #endregion

        #region Transitions
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));
        #endregion
    }
}
