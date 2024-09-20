using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class OtherIncomePage
    {
        private IWebDriver driver;
        public OtherIncomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements

        public IWebElement FirstIncomeWhereFrom => driver.FindElement(By.Id("OtherIncomes[0].Source"));
        public IWebElement FirstIncomeAmount => driver.FindElement(By.Id("OtherIncomes[0].Amount"));
        public IWebElement FirstIncomeFrequency => driver.FindElement(By.Id("OtherIncomes[0].AmountFrequency"));
        public IWebElement FirstIncomeMonth => driver.FindElement(By.Id("//*[@id=\"OtherIncomes[0].AmountFrequency\"]/option[1]"));
        public IWebElement FirstIncomeWeek => driver.FindElement(By.Id("//*[@id=\"OtherIncomes[0].AmountFrequency\"]/option[2]"));
        public IWebElement FirstIncomeFortnight => driver.FindElement(By.Id("//*[@id=\"OtherIncomes[0].AmountFrequency\"]/option[3]"));
        public IWebElement FirstIncome4Weeks => driver.FindElement(By.Id("//*[@id=\"OtherIncomes[0].AmountFrequency\"]/option[4]"));
        public IWebElement FirstIncomeQuarter => driver.FindElement(By.Id("//*[@id=\"OtherIncomes[0].AmountFrequency\"]/option[5]"));
        public IWebElement FirstIncomeYear => driver.FindElement(By.Id("//*[@id=\"OtherIncomes[0].AmountFrequency\"]/option[6]"));
        public IWebElement SecondIncomeWhereFrom => driver.FindElement(By.Id("OtherIncomes[1].Source"));
        public IWebElement SecondIncomeAmount => driver.FindElement(By.Id("OtherIncomes[1].Amount"));
        public IWebElement SecondIncomeFrequency => driver.FindElement(By.Id("OtherIncomes[1].AmountFrequency"));
        public IWebElement SecondIncomeMonth => driver.FindElement(By.Id("//*[@id=\"OtherIncomes[1].AmountFrequency\"]/option[1]"));
        public IWebElement SecondIncomeWeek => driver.FindElement(By.Id("//*[@id=\"OtherIncomes[1].AmountFrequency\"]/option[2]"));
        public IWebElement SecondIncomeFortnight => driver.FindElement(By.Id("//*[@id=\"OtherIncomes[1].AmountFrequency\"]/option[3]"));
        public IWebElement SecondIncome4Weeks => driver.FindElement(By.Id("//*[@id=\"OtherIncomes[1].AmountFrequency\"]/option[4]"));
        public IWebElement SecondIncomeQuarter => driver.FindElement(By.Id("//*[@id=\"OtherIncomes[1].AmountFrequency\"]/option[5]"));
        public IWebElement SecondIncomeYear => driver.FindElement(By.Id("//*[@id=\"OtherIncomes[1].AmountFrequency\"]/option[6]"));
        public IWebElement SecondIncomeDelete => driver.FindElement(By.Id("btn-delete-1"));
        public IWebElement AddAnotherIncome => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/table/tbody/tr[4]/td/label/button"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
