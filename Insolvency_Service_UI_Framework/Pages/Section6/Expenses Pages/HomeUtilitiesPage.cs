using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class HomeUtilitiesPage
    {
        private IWebDriver driver;
        public HomeUtilitiesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements

        #region Rent
        public IWebElement Rent => driver.FindElement(By.Id("Rent"));
        public IWebElement RentFrequency => driver.FindElement(By.Id("Rent_Frequency"));
        public IWebElement RentPerMonth => driver.FindElement(By.XPath("//*[@id=\"Rent_Frequency\"]/option[1]"));
        public IWebElement RentPerWeek => driver.FindElement(By.XPath("//*[@id=\"Rent_Frequency\"]/option[2]"));
        public IWebElement RentPerFortnight => driver.FindElement(By.XPath("//*[@id=\"Rent_Frequency\"]/option[3]"));
        public IWebElement RentPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Rent_Frequency\"]/option[4]"));
        public IWebElement RentPerQuarter => driver.FindElement(By.XPath("//*[@id=\"Rent_Frequency\"]/option[5]"));
        public IWebElement RentPerYear => driver.FindElement(By.XPath("//*[@id=\"Rent_Frequency\"]/option[6]"));
        #endregion

        #region Mortgage
        public IWebElement Mortgage => driver.FindElement(By.Id("Mortgage"));
        public IWebElement MortgageFrequency => driver.FindElement(By.Id("Mortgage_Frequency"));
        public IWebElement MortgagePerMonth => driver.FindElement(By.XPath("//*[@id=\"Mortgage_Frequency\"]/option[1]"));
        public IWebElement MortgagePerWeek => driver.FindElement(By.XPath("//*[@id=\"Mortgage_Frequency\"]/option[2]"));
        public IWebElement MortgagePerFortnight => driver.FindElement(By.XPath("//*[@id=\"Mortgage_Frequency\"]/option[3]"));
        public IWebElement MortgagePer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Mortgage_Frequency\"]/option[4]"));
        public IWebElement MortgagePerQuarter => driver.FindElement(By.XPath("//*[@id=\"Mortgage_Frequency\"]/option[5]"));
        public IWebElement MortgagePerYear => driver.FindElement(By.XPath("//*[@id=\"Mortgage_Frequency\"]/option[6]"));
        #endregion

        #region Secured Loans
        public IWebElement SecuredLoans => driver.FindElement(By.Id("SecuredLoans"));
        public IWebElement SecuredLoansFrequency => driver.FindElement(By.Id("SecuredLoans_Frequency"));
        public IWebElement SecuredLoansPerMonth => driver.FindElement(By.XPath("//*[@id=\"SecuredLoans_Frequency\"]/option[1]"));
        public IWebElement SecuredLoansPerWeek => driver.FindElement(By.XPath("//*[@id=\"SecuredLoans_Frequency\"]/option[2]"));
        public IWebElement SecuredLoansPerFortnight => driver.FindElement(By.XPath("//*[@id=\"SecuredLoans_Frequency\"]/option[3]"));
        public IWebElement SecuredLoansPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"SecuredLoans_Frequency\"]/option[4]"));
        public IWebElement SecuredLoansPerQuarter => driver.FindElement(By.XPath("//*[@id=\"SecuredLoans_Frequency\"]/option[5]"));
        public IWebElement SecuredLoansPerYear => driver.FindElement(By.XPath("//*[@id=\"SecuredLoans_Frequency\"]/option[6]"));
        #endregion

        #region Ground Rent
        public IWebElement GroundRent => driver.FindElement(By.Id("GroundRentServiceCharges"));
        public IWebElement GroundRentFrequency => driver.FindElement(By.Id("GroundRentServiceCharges_Frequency"));
        public IWebElement GroundRentPerMonth => driver.FindElement(By.XPath("//*[@id=\"GroundRentServiceCharges_Frequency\"]/option[1]"));
        public IWebElement GroundRentPerWeek => driver.FindElement(By.XPath("//*[@id=\"GroundRentServiceCharges_Frequency\"]/option[2]"));
        public IWebElement GroundRentPerFortnight => driver.FindElement(By.XPath("//*[@id=\"GroundRentServiceCharges_Frequency\"]/option[3]"));
        public IWebElement GroundRentPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"GroundRentServiceCharges_Frequency\"]/option[4]"));
        public IWebElement GroundRentPerQuarter => driver.FindElement(By.XPath("//*[@id=\"GroundRentServiceCharges_Frequency\"]/option[5]"));
        public IWebElement GroundRentPerYear => driver.FindElement(By.XPath("//*[@id=\"GroundRentServiceCharges_Frequency\"]/option[6]"));
        #endregion

        #region Building Contents Insurance
        public IWebElement BuildingContentsInsurance => driver.FindElement(By.Id("BuildingContentInsurance"));
        public IWebElement BuildingContentsInsuranceFrequency => driver.FindElement(By.Id("BuildingContentInsurance_Frequency"));
        public IWebElement BuildingContentsInsurancePerMonth => driver.FindElement(By.XPath("//*[@id=\"BuildingContentInsurance_Frequency\"]/option[1]"));
        public IWebElement BuildingContentsInsurancePerWeek => driver.FindElement(By.XPath("//*[@id=\"BuildingContentInsurance_Frequency\"]/option[2]"));
        public IWebElement BuildingContentsInsuranceFortnight => driver.FindElement(By.XPath("//*[@id=\"BuildingContentInsurance_Frequency\"]/option[3]"));
        public IWebElement BuildingContentsInsurancePer4Weeks => driver.FindElement(By.XPath("//*[@id=\"BuildingContentInsurance_Frequency\"]/option[4]"));
        public IWebElement BuildingContentsInsurancePerQuarter => driver.FindElement(By.XPath("//*[@id=\"BuildingContentInsurance_Frequency\"]/option[5]"));
        public IWebElement BuildingContentsInsurancePerYear => driver.FindElement(By.XPath("//*[@id=\"BuildingContentInsurance_Frequency\"]/option[6]"));
        #endregion

        #region Appliance Furniture Rental
        public IWebElement ApplianceFurnitureRental => driver.FindElement(By.Id("ApplicanceFurnitureRental"));
        public IWebElement ApplianceFurnitureRentalFrequency => driver.FindElement(By.Id("ApplicanceFurnitureRental_Frequency"));
        public IWebElement ApplianceFurnitureRentalPerMonth => driver.FindElement(By.XPath("//*[@id=\"ApplicanceFurnitureRental_Frequency\"]/option[1]"));
        public IWebElement ApplianceFurnitureRentalPerWeek => driver.FindElement(By.XPath("//*[@id=\"ApplicanceFurnitureRental_Frequency\"]/option[2]"));
        public IWebElement ApplianceFurnitureRentalPerFortnight => driver.FindElement(By.XPath("//*[@id=\"ApplicanceFurnitureRental_Frequency\"]/option[3]"));
        public IWebElement ApplianceFurnitureRentalPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"ApplicanceFurnitureRental_Frequency\"]/option[4]"));
        public IWebElement ApplianceFurnitureRentalPerQuarter => driver.FindElement(By.XPath("//*[@id=\"ApplicanceFurnitureRental_Frequency\"]/option[5]"));
        public IWebElement ApplianceFurnitureRentalPerYear => driver.FindElement(By.XPath("//*[@id=\"ApplicanceFurnitureRental_Frequency\"]/option[6]"));
        #endregion

        #region TV Licence
        public IWebElement TVLicenceCredit => driver.FindElement(By.Id("TVLicence"));
        public IWebElement TVLicenceFrequency => driver.FindElement(By.Id("TVLicence_Frequency"));
        public IWebElement TVLicencePerMonth => driver.FindElement(By.XPath("//*[@id=\"TVLicence_Frequency\"]/option[1]"));
        public IWebElement TVLicencePerWeek => driver.FindElement(By.XPath("//*[@id=\"TVLicence_Frequency\"]/option[2]"));
        public IWebElement TVLicencePerFortnight => driver.FindElement(By.XPath("//*[@id=\"TVLicence_Frequency\"]/option[3]"));
        public IWebElement TVLicencePer4Weeks => driver.FindElement(By.XPath("//*[@id=\"TVLicence_Frequency\"]/option[4]"));
        public IWebElement TVLicencePerQuarter => driver.FindElement(By.XPath("//*[@id=\"TVLicence_Frequency\"]/option[5]"));
        public IWebElement TVLicencePerYear => driver.FindElement(By.XPath("//*[@id=\"TVLicence_Frequency\"]/option[6]"));
        #endregion

        #region Council Tax
        public IWebElement CouncilTax => driver.FindElement(By.Id("CouncilTax"));
        public IWebElement CouncilTaxFrequency => driver.FindElement(By.Id("CouncilTax_Frequency"));
        public IWebElement CouncilTaxPerMonth => driver.FindElement(By.XPath("//*[@id=\"CouncilTax_Frequency\"]/option[1]"));
        public IWebElement CouncilTaxPerWeek => driver.FindElement(By.XPath("//*[@id=\"CouncilTax_Frequency\"]/option[2]"));
        public IWebElement CouncilTaxPerFortnight => driver.FindElement(By.XPath("//*[@id=\"CouncilTax_Frequency\"]/option[3]"));
        public IWebElement CouncilTaxPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"CouncilTax_Frequency\"]/option[4]"));
        public IWebElement CouncilTaxPerQuarter => driver.FindElement(By.XPath("//*[@id=\"CouncilTax_Frequency\"]/option[5]"));
        public IWebElement CouncilTaxPerYear => driver.FindElement(By.XPath("//*[@id=\"CouncilTax_Frequency\"]/option[6]"));
        #endregion

        #region Gas
        public IWebElement Gas => driver.FindElement(By.Id("Gas"));
        public IWebElement GasFrequency => driver.FindElement(By.Id("Gas_Frequency"));
        public IWebElement GasPerMonth => driver.FindElement(By.XPath("//*[@id=\"Gas_Frequency\"]/option[1]"));
        public IWebElement GasPerWeek => driver.FindElement(By.XPath("//*[@id=\"Gas_Frequency\"]/option[2]"));
        public IWebElement GasPerFortnight => driver.FindElement(By.XPath("//*[@id=\"Gas_Frequency\"]/option[3]"));
        public IWebElement GasPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Gas_Frequency\"]/option[4]"));
        public IWebElement GasPerQuarter => driver.FindElement(By.XPath("//*[@id=\"Gas_Frequency\"]/option[5]"));
        public IWebElement GasPerYear => driver.FindElement(By.XPath("//*[@id=\"Gas_Frequency\"]/option[6]"));
        #endregion

        #region Electricity
        public IWebElement Electricity => driver.FindElement(By.Id("Electricity"));
        public IWebElement ElectricityFrequency => driver.FindElement(By.Id("Electricity_Frequency"));
        public IWebElement ElectricityPerMonth => driver.FindElement(By.XPath("//*[@id=\"Electricity_Frequency\"]/option[1]"));
        public IWebElement ElectricityPerWeek => driver.FindElement(By.XPath("//*[@id=\"Electricity_Frequency\"]/option[2]"));
        public IWebElement ElectricityPerFortnight => driver.FindElement(By.XPath("//*[@id=\"Electricity_Frequency\"]/option[3]"));
        public IWebElement ElectricityPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Electricity_Frequency\"]/option[4]"));
        public IWebElement ElectricityPerQuarter => driver.FindElement(By.XPath("//*[@id=\"Electricity_Frequency\"]/option[5]"));
        public IWebElement ElectricityPerYear => driver.FindElement(By.XPath("//*[@id=\"Electricity_Frequency\"]/option[6]"));
        #endregion

        #region Water
        public IWebElement Water => driver.FindElement(By.Id("Water"));
        public IWebElement WaterFrequency => driver.FindElement(By.Id("Water_Frequency"));
        public IWebElement WaterPerMonth => driver.FindElement(By.XPath("//*[@id=\"Water_Frequency\"]/option[1]"));
        public IWebElement WaterPerWeek => driver.FindElement(By.XPath("//*[@id=\"Water_Frequency\"]/option[2]"));
        public IWebElement WaterPerFortnight => driver.FindElement(By.XPath("//*[@id=\"Water_Frequency\"]/option[3]"));
        public IWebElement WaterPer4Weeks => driver.FindElement(By.XPath("//*[@id=\"Water_Frequency\"]/option[4]"));
        public IWebElement WaterPerQuarter => driver.FindElement(By.XPath("//*[@id=\"Water_Frequency\"]/option[5]"));
        public IWebElement WaterPerYear => driver.FindElement(By.XPath("//*[@id=\"Water_Frequency\"]/option[6]"));
        #endregion

        #region Page Transition
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));
        #endregion
    }
}
