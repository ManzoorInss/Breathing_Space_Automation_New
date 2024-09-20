using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class ApplicationOverviewPage
    {
        private IWebDriver driver;
        public ApplicationOverviewPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //Buttons and PageElements
        public IWebElement PersonalDetails_StartButton => driver.FindElement(By.Id("section_id_Personal_details"));
        public IWebElement Employment_StartButton => driver.FindElement(By.Id("section_id_Employment"));
        public IWebElement BankAccountsAndSavings_StartButton => driver.FindElement(By.Id("section_id_Bank_accounts_and_savings"));
        public IWebElement Assets_StartButton => driver.FindElement(By.Id("section_id_Assets"));
        public IWebElement MoneyYouOwe_StartButton => driver.FindElement(By.Id("section_id_Money_you_owe"));
        public IWebElement IncomeAndExpenses_StartButton => driver.FindElement(By.Id("section_id_Income_and_expenses"));
        public IWebElement LegalProceedings_StartButton => driver.FindElement(By.Id("section_id_Legal_proceedings"));
        public IWebElement DebtHistory_StartButton => driver.FindElement(By.Id("section_id_Debt_history"));
        public IWebElement PaymentAmountLink => driver.FindElement(By.XPath("//span[@class='payment-amount']"));
        public IWebElement FindAboutPaymentLink => driver.FindElement(By.XPath("//a[normalize-space()='Find out about paying the fee']"));
        public IWebElement MakeAPayment => driver.FindElement(By.XPath("//*[@id=\"feebox\"]/a[3]"));
        public IWebElement SaveAndLogoutLink => driver.FindElement(By.XPath("//a[@class='banner-logout']"));
        public IWebElement ChangeYourSecurityQuestionsLink => driver.FindElement(By.XPath("//a[@id='change']"));
        public IWebElement ViewPrintableCopyLink => driver.FindElement(By.XPath("//a[@id='view']"));
        public IWebElement DiscardApplicationLink => driver.FindElement(By.XPath("//p//a[@id='discard']"));
        public IWebElement SumbitApplication => driver.FindElement(By.Id("next"));



    }
}
