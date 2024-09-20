using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class IncomeAndExpensesPage
    {
        private IWebDriver driver;
        public IncomeAndExpensesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements

        public IWebElement SelfEmployedIncome => driver.FindElement(By.Id("section_id_Self_employed_income"));
        public IWebElement SalaryWages => driver.FindElement(By.Id("section_id_Salary_or_wages"));
        public IWebElement BenefitsTaxCredits => driver.FindElement(By.Id("section_id_Benefits_and_tax_credits"));
        public IWebElement Pensions => driver.FindElement(By.Id("section_id_Pensions"));
        public IWebElement OtherIncome => driver.FindElement(By.Id("section_id_Other_income"));
        public IWebElement HouseholdIncome => driver.FindElement(By.Id("section_id_Household_income"));
        public IWebElement HomeUtilities => driver.FindElement(By.Id("section_id_Home_and_utilities"));
        public IWebElement PensionInsuranceHealthcare => driver.FindElement(By.Id("section_id_Pension,_insurance_and_health_care"));
        public IWebElement FoodHousekeeping => driver.FindElement(By.Id("section_id_Food_and_housekeeping"));
        public IWebElement TransportTravel => driver.FindElement(By.Id("section_id_Transport_and_travel"));
        public IWebElement ChildcareMaintenance => driver.FindElement(By.Id("section_id_Childcare_and_maintenance"));
        public IWebElement PersonalLeisure => driver.FindElement(By.Id("section_id_Personal_and_leisure"));
        public IWebElement SavingsFinesOtherExpenses => driver.FindElement(By.Id("section_id_Regular_savings,_fines_and_other_expenses"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
