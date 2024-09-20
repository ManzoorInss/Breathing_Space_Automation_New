using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class BenefitsTaxCreditsPage
    {
        private IWebDriver driver;
        public BenefitsTaxCreditsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements
        #region Buttons and Elements

        #region Child Tax Credit Inputs
        public IWebElement ChildTaxCredit => driver.FindElement(By.Id("ChildTaxCredit"));
        public IWebElement ChildTaxCreditFrequency => driver.FindElement(By.Id("ChildTaxCredit_Frequency"));
        public IWebElement ChildTaxPerMonth => driver.FindElement(By.XPath("//*[@id=\"ChildTaxCredit_Frequency\"]/option[1]"));
        public IWebElement ChildTaxPerWeek => driver.FindElement(By.XPath("//*[@id=\"ChildTaxCredit_Frequency\"]/option[2]"));
        public IWebElement ChildTaxPerFortnight => driver.FindElement(By.XPath("//*[@id=\"ChildTaxCredit_Frequency\"]/option[3]"));
        public IWebElement ChildTaxPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"ChildTaxCredit_Frequency\"]/option[4]"));
        public IWebElement ChildTaxPerQuarter => driver.FindElement(By.XPath("//*[@id=\"ChildTaxCredit_Frequency\"]/option[5]"));
        public IWebElement ChildTaxPerYear => driver.FindElement(By.XPath("//*[@id=\"ChildTaxCredit_Frequency\"]/option[6]"));
        #endregion

        #region Child Benefit Inputs
        public IWebElement ChildBenefit => driver.FindElement(By.Id("ChildBenefit"));
        public IWebElement ChildBenefitFrequency => driver.FindElement(By.Id("ChildBenefit_Frequency"));
        public IWebElement ChildBenefitPerMonth => driver.FindElement(By.XPath("//*[@id=\"ChildBenefit_Frequency\"]/option[1]"));
        public IWebElement ChildBenefitPerWeek => driver.FindElement(By.XPath("//*[@id=\"ChildBenefit_Frequency\"]/option[2]"));
        public IWebElement ChildBenefitPerFortnight => driver.FindElement(By.XPath("//*[@id=\"ChildBenefit_Frequency\"]/option[3]"));
        public IWebElement ChildBenefitPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"ChildBenefit_Frequency\"]/option[4]"));
        public IWebElement ChildBenefitPerQuarter => driver.FindElement(By.XPath("//*[@id=\"ChildBenefit_Frequency\"]/option[5]"));
        public IWebElement ChildBenefitPerYear => driver.FindElement(By.XPath("//*[@id=\"ChildBenefit_Frequency\"]/option[6]"));
        #endregion

        #region Maintenance Child Support Inputs
        public IWebElement MaintenanceChildSupport => driver.FindElement(By.Id("ChildSupport"));
        public IWebElement MaintenanceChildSupportFrequency => driver.FindElement(By.Id("ChildSupport_Frequency"));
        public IWebElement MaintenanceChildSupportPerMonth => driver.FindElement(By.XPath("//*[@id=\"ChildSupport_Frequency\"]/option[1]"));
        public IWebElement MaintenanceChildSupportPerWeek => driver.FindElement(By.XPath("//*[@id=\"ChildSupport_Frequency\"]/option[2]"));
        public IWebElement MaintenanceChildSupportPerFortnight => driver.FindElement(By.XPath("//*[@id=\"ChildSupport_Frequency\"]/option[3]"));
        public IWebElement MaintenanceChildSupportPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"ChildSupport_Frequency\"]/option[4]"));
        public IWebElement MaintenanceChildSupportPerQuarter => driver.FindElement(By.XPath("//*[@id=\"ChildSupport_Frequency\"]/option[5]"));
        public IWebElement MaintenanceChildSupportPerYear => driver.FindElement(By.XPath("//*[@id=\"ChildSupport_Frequency\"]/option[6]"));

        #endregion

        #region Universal Credit Inputs
        public IWebElement UniversalCredit => driver.FindElement(By.Id("Universal_Credit"));
        public IWebElement UniversalCreditFrequency => driver.FindElement(By.Id("Universal_Credit_Frequency"));
        public IWebElement UniversalCreditPerMonth => driver.FindElement(By.XPath("//*[@id=\"Universal_Credit_Frequency\"]/option[1]"));
        public IWebElement UniversalCreditPerWeek => driver.FindElement(By.XPath("//*[@id=\"Universal_Credit_Frequency\"]/option[2]"));
        public IWebElement UniversalCreditPerFortnight => driver.FindElement(By.XPath("//*[@id=\"Universal_Credit_Frequency\"]/option[3]"));
        public IWebElement UniversalCreditPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Universal_Credit_Frequency\"]/option[4]"));
        public IWebElement UniversalCreditPerQuarter => driver.FindElement(By.XPath("//*[@id=\"Universal_Credit_Frequency\"]/option[5]"));
        public IWebElement UniversalCreditPerYear => driver.FindElement(By.XPath("//*[@id=\"Universal_Credit_Frequency\"]/option[6]"));
        #endregion

        #region Job Seekers Allowance
        public IWebElement JobSeekersAllowance => driver.FindElement(By.Id("JobSeekers"));
        public IWebElement JobSeekersAllowanceFrequency => driver.FindElement(By.Id("JobSeekers_Frequency"));
        public IWebElement JobSeekersAllowancePerMonth => driver.FindElement(By.XPath("//*[@id=\"JobSeekers_Frequency\"]/option[1]"));
        public IWebElement JobSeekersAllowancePerWeek => driver.FindElement(By.XPath("//*[@id=\"JobSeekers_Frequency\"]/option[2]"));
        public IWebElement JobSeekersAllowancePerFortnight => driver.FindElement(By.XPath("//*[@id=\"JobSeekers_Frequency\"]/option[3]"));
        public IWebElement JobSeekersAllowancePer4Weeks => driver.FindElement(By.XPath("//*[@id=\"JobSeekers_Frequency\"]/option[4]"));
        public IWebElement JobSeekersAllowancePerQuarter => driver.FindElement(By.XPath("//*[@id=\"JobSeekers_Frequency\"]/option[5]"));
        public IWebElement JobSeekersAllowancePerYear => driver.FindElement(By.XPath("//*[@id=\"JobSeekers_Frequency\"]/option[6]"));
        #endregion

        #region Income Support
        public IWebElement IncomeSupport => driver.FindElement(By.Id("Income_Support"));
        public IWebElement IncomeSupportFrequency => driver.FindElement(By.Id("Income_Support_Frequency"));
        public IWebElement IncomeSupportPerMonth => driver.FindElement(By.XPath("//*[@id=\"Income_Support_Frequency\"]/option[1]"));
        public IWebElement IncomeSupportPerWeek => driver.FindElement(By.XPath("//*[@id=\"Income_Support_Frequency\"]/option[2]"));
        public IWebElement IncomeSupportPerFortnight => driver.FindElement(By.XPath("//*[@id=\"Income_Support_Frequency\"]/option[3]"));
        public IWebElement IncomeSupportPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Income_Support_Frequency\"]/option[4]"));
        public IWebElement IncomeSupportPerQuarter => driver.FindElement(By.XPath("//*[@id=\"Income_Support_Frequency\"]/option[5]"));
        public IWebElement IncomeSupportPerYear => driver.FindElement(By.XPath("//*[@id=\"Income_Support_Frequency\"]/option[6]"));
        #endregion

        #region Working Tax Credit
        public IWebElement WorkingTaxCredit => driver.FindElement(By.Id("Working_Tax_Credit"));
        public IWebElement WorkingTaxCreditFrequency => driver.FindElement(By.Id("Working_Tax_Credit_Frequency"));
        public IWebElement WorkingTaxCreditPerMonth => driver.FindElement(By.XPath("//*[@id=\"Working_Tax_Credit_Frequency\"]/option[1]"));
        public IWebElement WorkingTaxCreditPerWeek => driver.FindElement(By.XPath("//*[@id=\"Working_Tax_Credit_Frequency\"]/option[2]"));
        public IWebElement WorkingTaxCreditPerFortnight => driver.FindElement(By.XPath("//*[@id=\"Working_Tax_Credit_Frequency\"]/option[3]"));
        public IWebElement WorkingTaxCreditPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Working_Tax_Credit_Frequency\"]/option[4]"));
        public IWebElement WorkingTaxCreditPerQuarter => driver.FindElement(By.XPath("//*[@id=\"Working_Tax_Credit_Frequency\"]/option[5]"));
        public IWebElement WorkingTaxCreditPerYear => driver.FindElement(By.XPath("//*[@id=\"Working_Tax_Credit_Frequency\"]/option[6]"));
        #endregion

        #region ESA or SSP
        public IWebElement ESAorSSP => driver.FindElement(By.Id("Sick_Pay"));
        public IWebElement ESAorSSPFrequency => driver.FindElement(By.Id("Sick_Pay_Frequency"));
        public IWebElement ESAorSSPPerMonth => driver.FindElement(By.XPath("//*[@id=\"Sick_Pay_Frequency\"]/option[1]"));
        public IWebElement ESAorSSPPerWeek => driver.FindElement(By.XPath("//*[@id=\"Sick_Pay_Frequency\"]/option[2]"));
        public IWebElement ESAorSSPPerFortnight => driver.FindElement(By.XPath("//*[@id=\"Sick_Pay_Frequency\"]/option[3]"));
        public IWebElement ESAorSSPPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Sick_Pay_Frequency\"]/option[4]"));
        public IWebElement ESAorSSPPerQuarter => driver.FindElement(By.XPath("//*[@id=\"Sick_Pay_Frequency\"]/option[5]"));
        public IWebElement ESAorSSPPerYear => driver.FindElement(By.XPath("//*[@id=\"Sick_Pay_Frequency\"]/option[6]"));
        #endregion

        #region DLA or PIP
        public IWebElement DLAorPIP => driver.FindElement(By.Id("Disability"));
        public IWebElement DLAorPIPFrequency => driver.FindElement(By.Id("Disability_Frequency"));
        public IWebElement DLAorPIPPerMonth => driver.FindElement(By.XPath("//*[@id=\"Disability_Frequency\"]/option[1]"));
        public IWebElement DLAorPIPPerWeek => driver.FindElement(By.XPath("//*[@id=\"Disability_Frequency\"]/option[2]"));
        public IWebElement DLAorPIPPerFortnight => driver.FindElement(By.XPath("//*[@id=\"Disability_Frequency\"]/option[3]"));
        public IWebElement DLAorPIPPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Disability_Frequency\"]/option[4]"));
        public IWebElement DLAorPIPPerQuarter => driver.FindElement(By.XPath("//*[@id=\"Disability_Frequency\"]/option[5]"));
        public IWebElement DLAorPIPPerYear => driver.FindElement(By.XPath("//*[@id=\"Disability_Frequency\"]/option[6]"));
        #endregion

        #region Carers Allowance
        public IWebElement CarersAllowance => driver.FindElement(By.Id("Carers_Allowance"));
        public IWebElement CarersAllowanceFrequency => driver.FindElement(By.Id("Carers_Allowance_Frequency"));
        public IWebElement CarersAllowancePerMonth => driver.FindElement(By.XPath("//*[@id=\"Carers_Allowance_Frequency\"]/option[1]"));
        public IWebElement CarersAllowancePerWeek => driver.FindElement(By.XPath("//*[@id=\"Carers_Allowance_Frequency\"]/option[2]"));
        public IWebElement CarersAllowancePerFortnight => driver.FindElement(By.XPath("//*[@id=\"Carers_Allowance_Frequency\"]/option[3]"));
        public IWebElement CarersAllowancePer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Carers_Allowance_Frequency\"]/option[4]"));
        public IWebElement CarersAllowancePerQuarter => driver.FindElement(By.XPath("//*[@id=\"Carers_Allowance_Frequency\"]/option[5]"));
        public IWebElement CarersAllowancePerYear => driver.FindElement(By.XPath("//*[@id=\"Carers_Allowance_Frequency\"]/option[6]"));
        #endregion

        #region Housing Benefit
        public IWebElement HousingBenefit => driver.FindElement(By.Id("Housing_Benefit"));
        public IWebElement HousingBenefitFrequency => driver.FindElement(By.Id("Housing_Benefit_Frequency"));
        public IWebElement HousingBenefitPerMonth => driver.FindElement(By.XPath("//*[@id=\"Housing_Benefit_Frequency\"]/option[1]"));
        public IWebElement HousingBenefitPerWeek => driver.FindElement(By.XPath("//*[@id=\"Housing_Benefit_Frequency\"]/option[2]"));
        public IWebElement HousingBenefitPerFortnight => driver.FindElement(By.XPath("//*[@id=\"Housing_Benefit_Frequency\"]/option[3]"));
        public IWebElement HousingBenefitPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Housing_Benefit_Frequency\"]/option[4]"));
        public IWebElement HousingBenefitPerQuarter => driver.FindElement(By.XPath("//*[@id=\"Housing_Benefit_Frequency\"]/option[5]"));
        public IWebElement HousingBenefitPerYear => driver.FindElement(By.XPath("//*[@id=\"Housing_Benefit_Frequency\"]/option[6]"));
        #endregion

        #region Council Tax Reduction
        public IWebElement CouncilTaxReduction => driver.FindElement(By.Id("Council_Tax_Support"));
        public IWebElement CouncilTaxReductionFrequency => driver.FindElement(By.Id("Council_Tax_Support_Frequency"));
        public IWebElement CouncilTaxReductionPerMonth => driver.FindElement(By.XPath("//*[@id=\"Council_Tax_Support_Frequency\"]/option[1]"));
        public IWebElement CouncilTaxReductionPerWeek => driver.FindElement(By.XPath("//*[@id=\"Council_Tax_Support_Frequency\"]/option[2]"));
        public IWebElement CouncilTaxReductionPerFortnight => driver.FindElement(By.XPath("//*[@id=\"Council_Tax_Support_Frequency\"]/option[3]"));
        public IWebElement CouncilTaxReductionPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Council_Tax_Support_Frequency\"]/option[4]"));
        public IWebElement CouncilTaxReductionPerQuarter => driver.FindElement(By.XPath("//*[@id=\"Council_Tax_Support_Frequency\"]/option[5]"));
        public IWebElement CouncilTaxReductionPerYear => driver.FindElement(By.XPath("//*[@id=\"Council_Tax_Support_Frequency\"]/option[6]"));
        #endregion

        #region Other Benefit
        public IWebElement NameOfBenefit => driver.FindElement(By.Id("Other_Text"));
        public IWebElement BenefitAmount => driver.FindElement(By.Id("Other_Value"));
        public IWebElement BenefitAmountFrequency => driver.FindElement(By.Id("Other_Value_Frequency"));
        public IWebElement BenefitAmountPerMonth => driver.FindElement(By.XPath("//*[@id=\"Other_Value_Frequency\"]/option[1]"));
        public IWebElement BenefitAmountPerWeek => driver.FindElement(By.XPath("//*[@id=\"Other_Value_Frequency\"]/option[2]"));
        public IWebElement BenefitAmountPerFortnight => driver.FindElement(By.XPath("//*[@id=\"Other_Value_Frequency\"]/option[3]"));
        public IWebElement BenefitAmountPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Other_Value_Frequency\"]/option[4]"));
        public IWebElement BenefitAmountPerQuarter => driver.FindElement(By.XPath("//*[@id=\"Other_Value_Frequency\"]/option[5]"));
        public IWebElement BenefitAmountPerYear => driver.FindElement(By.XPath("//*[@id=\"Other_Value_Frequency\"]/option[6]"));
        #endregion

        #region Navigation Button
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));
        #endregion
        #endregion

    }
}
