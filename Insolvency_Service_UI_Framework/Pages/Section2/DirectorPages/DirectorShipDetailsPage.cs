using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class DirectorShipDetailsPage
    {
        private IWebDriver driver;
        public DirectorShipDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //PageElements
        public IWebElement LimitedCompnayNameField => driver.FindElement(By.Id("LimitedCompanyName"));
        public IWebElement IsCompanyReigsteredinUK_YesOption => driver.FindElement(By.Id("IsCompanyRegisteredInTheUK_0"));
        public IWebElement IsCompanyReigsteredinUK_NoOption => driver.FindElement(By.Id("IsCompanyRegisteredInTheUK_1"));
        public IWebElement CompanyRegistrationNumberField => driver.FindElement(By.Id("CompanyRegistrationNumber"));
        public IWebElement CompanyRegisteredCountryField => driver.FindElement(By.Id("CompanyRegistrationCountry"));

        public IWebElement CompanySubjectToInsolvencyProceedings_YesOption => driver.FindElement(By.Id("IsCompanySubjectToInsolvencyProceedings_0"));
        public IWebElement CompanySubjectToInsolvencyProceedings_NoOption => driver.FindElement(By.Id("IsCompanySubjectToInsolvencyProceedings_1"));
        public IWebElement StillAnActiveDirector_YesOption => driver.FindElement(By.Id("AreYouStillAnActiveDirector_0"));
        public IWebElement StillAnActiveDirector_NoOption => driver.FindElement(By.Id("AreYouStillAnActiveDirector_1"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
