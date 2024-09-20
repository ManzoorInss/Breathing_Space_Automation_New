using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class SalaryWagesPage
    {
        private IWebDriver driver;
        public SalaryWagesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements
        #region First Net Income
        public IWebElement FirstNetIncome => driver.FindElement(By.Id("OtherWages[0].NetIncome"));
        public IWebElement FirstNetIncomeFrequency => driver.FindElement(By.Id("OtherWages[0].NetIncome_Frequency"));
        public IWebElement FirstNetIncomePerMonth => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].NetIncome_Frequency\"]/option[1]"));
        public IWebElement FirstNetIncomePerWeek => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].NetIncome_Frequency\"]/option[2]"));
        public IWebElement FirstNetIncomePerFortnight => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].NetIncome_Frequency\"]/option[3]"));
        public IWebElement FirstNetIncomePer4Weeks => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].NetIncome_Frequency\"]/option[4]"));
        public IWebElement FirstNetIncomePerQuarter => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].NetIncome_Frequency\"]/option[5]"));
        public IWebElement FirstNetIncomePerYear => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].NetIncome_Frequency\"]/option[6]"));
        #endregion

        #region Second Net Income
        public IWebElement SecondNetIncome => driver.FindElement(By.Id("OtherWages[1].NetIncome"));
        public IWebElement SecondNetIncomeFrequency => driver.FindElement(By.Id("OtherWages[1].NetIncome_Frequency"));
        public IWebElement SecondNetIncomePerMonth => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].NetIncome_Frequency\"]/option[1]"));
        public IWebElement SecondNetIncomePerWeek => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].NetIncome_Frequency\"]/option[2]"));
        public IWebElement SecondNetIncomePerFortnight => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].NetIncome_Frequency\"]/option[3]"));
        public IWebElement SecondNetIncomePer4Weeks => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].NetIncome_Frequency\"]/option[4]"));
        public IWebElement SecondNetIncomePerQuarter => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].NetIncome_Frequency\"]/option[5]"));
        public IWebElement SecondNetIncomePerYear => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].NetIncome_Frequency\"]/option[6]"));
        #endregion

        #region First Income Tax
        public IWebElement FirstIncomeTax => driver.FindElement(By.Id("OtherWages[0].IncomeTax"));
        public IWebElement FirstIncomeTaxFrequency => driver.FindElement(By.Id("OtherWages[0].IncomeTax_Frequency"));
        public IWebElement FirstIncomeTaxPerMonth => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].IncomeTax_Frequency\"]/option[1]"));
        public IWebElement FirstIncomeTaxPerWeek => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].IncomeTax_Frequency\"]/option[2]"));
        public IWebElement FirstIncomeTaxPerFortnight => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].IncomeTax_Frequency\"]/option[3]"));
        public IWebElement FirstIncomeTaxPer4Weeks => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].IncomeTax_Frequency\"]/option[4]"));
        public IWebElement FirstIncomeTaxPerQuarter => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].IncomeTax_Frequency\"]/option[5]"));
        public IWebElement FirstIncomeTaxPerYear => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].IncomeTax_Frequency\"]/option[6]"));
        #endregion

        #region Second Income Tax
        public IWebElement SecondIncomeTax => driver.FindElement(By.Id("OtherWages[1].IncomeTax"));
        public IWebElement SecondIncomeTaxFrequency => driver.FindElement(By.Id("OtherWages[1].IncomeTax_Frequency"));
        public IWebElement SecondIncomeTaxPerMonth => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].IncomeTax_Frequency\"]/option[1]"));
        public IWebElement SecondIncomeTaxPerWeek => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].IncomeTax_Frequency\"]/option[2]"));
        public IWebElement SecondIncomeTaxPerFortnight => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].IncomeTax_Frequency\"]/option[3]"));
        public IWebElement SecondIncomeTaxPer4Weeks => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].IncomeTax_Frequency\"]/option[4]"));
        public IWebElement SecondIncomeTaxPerQuarter => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].IncomeTax_Frequency\"]/option[5]"));
        public IWebElement SecondIncomeTaxPerYear => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].IncomeTax_Frequency\"]/option[6]"));
        #endregion

        #region First Overtime
        public IWebElement FirstOvertime => driver.FindElement(By.Id("OtherWages[0].OverTime"));
        public IWebElement FirstOvertimeFrequency => driver.FindElement(By.Id("OtherWages[0].OverTime_Frequency"));
        public IWebElement FirstOvertimePerMonth => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].OverTime_Frequency\"]/option[1]"));
        public IWebElement FirstOvertimePerWeek => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].OverTime_Frequency\"]/option[2]"));
        public IWebElement FirstOvertimePerFortnight => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].OverTime_Frequency\"]/option[3]"));
        public IWebElement FirstOvertimePer4Weeks => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].OverTime_Frequency\"]/option[4]"));
        public IWebElement FirstOvertimePerQuarter => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].OverTime_Frequency\"]/option[5]"));
        public IWebElement FirstOvertimePerYear => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].OverTime_Frequency\"]/option[6]"));
        #endregion

        #region Second Overtime
        public IWebElement SecondOvertime => driver.FindElement(By.Id("OtherWages[1].OverTime"));
        public IWebElement SecondOvertimeFrequency => driver.FindElement(By.Id("OtherWages[1].OverTime_Frequency"));
        public IWebElement SecondOvertimePerMonth => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].OverTime_Frequency\"]/option[1]"));
        public IWebElement SecondOvertimePerWeek => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].OverTime_Frequency\"]/option[2]"));
        public IWebElement SecondOvertimePerFortnight => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].OverTime_Frequency\"]/option[3]"));
        public IWebElement SecondOvertimePer4Weeks => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].OverTime_Frequency\"]/option[4]"));
        public IWebElement SecondOvertimePerQuarter => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].OverTime_Frequency\"]/option[5]"));
        public IWebElement SecondOvertimePerYear => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].OverTime_Frequency\"]/option[6]"));
        #endregion

        #region First Bonuses
        public IWebElement FirstBonuses => driver.FindElement(By.Id("OtherWages[0].Bonus"));
        public IWebElement FirstBonusesFrequency => driver.FindElement(By.Id("OtherWages[0].Bonus_Frequency"));
        public IWebElement FirstBonusesPerMonth => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].Bonus_Frequency\"]/option[1]"));
        public IWebElement FirstBonusesPerWeek => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].Bonus_Frequency\"]/option[2]"));
        public IWebElement FirstBonusesPerFortnight => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].Bonus_Frequency\"]/option[3]"));
        public IWebElement FirstBonusesPer4Weeks => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].Bonus_Frequency\"]/option[4]"));
        public IWebElement FirstBonusesPerQuarter => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].Bonus_Frequency\"]/option[5]"));
        public IWebElement FirstBonusesPerYear => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].Bonus_Frequency\"]/option[6]"));
        #endregion

        #region Second Bonuses
        public IWebElement SecondBonuses => driver.FindElement(By.Id("OtherWages[1].Bonus"));
        public IWebElement SecondBonusesFrequency => driver.FindElement(By.Id("OtherWages[1].Bonus_Frequency"));
        public IWebElement SecondBonusesPerMonth => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].Bonus_Frequency\"]/option[1]"));
        public IWebElement SecondBonusesPerWeek => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].Bonus_Frequency\"]/option[2]"));
        public IWebElement SecondBonusesPerFortnight => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].Bonus_Frequency\"]/option[3]"));
        public IWebElement SecondBonusesPer4Weeks => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].Bonus_Frequency\"]/option[4]"));
        public IWebElement SecondBonusesPerQuarter => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].Bonus_Frequency\"]/option[5]"));
        public IWebElement SecondBonusesPerYear => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].Bonus_Frequency\"]/option[6]"));
        #endregion

        #region First Other Payments
        public IWebElement FirstOtherPayments => driver.FindElement(By.Id("OtherWages[0].OtherPayments"));
        public IWebElement FirstOtherPaymentsFrequency => driver.FindElement(By.Id("OtherWages[0].OtherPayments_Frequency"));
        public IWebElement FirstOtherPaymentsPerMonth => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].OtherPayments_Frequency\"]/option[1]"));
        public IWebElement FirstOtherPaymentsPerWeek => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].OtherPayments_Frequency\"]/option[2]"));
        public IWebElement FirstOtherPaymentsPerFortnight => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].OtherPayments_Frequency\"]/option[3]"));
        public IWebElement FirstOtherPaymentsPer4Weeks => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].OtherPayments_Frequency\"]/option[4]"));
        public IWebElement FirstOtherPaymentsPerQuarter => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].OtherPayments_Frequency\"]/option[5]"));
        public IWebElement FirstOtherPaymentsPerYear => driver.FindElement(By.Id("//*[@id=\"OtherWages[0].OtherPayments_Frequency\"]/option[6]"));
        #endregion

        #region Second Other Payments
        public IWebElement SecondOtherPayments => driver.FindElement(By.Id("OtherWages[1].OtherPayments"));
        public IWebElement SecondOtherPaymentsFrequency => driver.FindElement(By.Id("OtherWages[1].OtherPayments_Frequency"));
        public IWebElement SecondOtherPaymentsPerMonth => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].OtherPayments_Frequency\"]/option[1]"));
        public IWebElement SecondOtherPaymentsPerWeek => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].OtherPayments_Frequency\"]/option[2]"));
        public IWebElement SecondOtherPaymentsPerFortnight => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].OtherPayments_Frequency\"]/option[3]"));
        public IWebElement SecondOtherPaymentsPer4Weeks => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].OtherPayments_Frequency\"]/option[4]"));
        public IWebElement SecondOtherPaymentsPerQuarter => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].OtherPayments_Frequency\"]/option[5]"));
        public IWebElement SecondOtherPaymentsPerYear => driver.FindElement(By.Id("//*[@id=\"OtherWages[1].OtherPayments_Frequency\"]/option[6]"));

        #endregion

        #region Create and Delete Additional Employments
        public IWebElement DeleteSecondEmployment => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/table/tbody/tr[6]/td[2]/span/input"));
        public IWebElement AddAnotherEmployment => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/table/tbody/tr[6]/td/label/button"));
        #endregion

        #region Navigation Buttons
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));
        #endregion

    }
}
