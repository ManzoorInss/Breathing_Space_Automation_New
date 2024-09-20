using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class ContactDetailsPage
    {
        private IWebDriver driver;
        public ContactDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //Buttons and PageElements
        public IWebElement TelephoneField => driver.FindElement(By.Id("ContactDetails.Telephone"));
        public IWebElement MobileField => driver.FindElement(By.Id("ContactDetails.Mobile"));
        public IWebElement EmailAddressField => driver.FindElement(By.Id("ContactDetails.Email"));
        public IWebElement SearchAddressField => driver.FindElement(By.Id("SearchAddress"));
        //If input is given with proper address in search address filed we can use the xpath using //div[@title='<Enter Input here given above']
        public IWebElement BuildingAndStreet_LineOneField => driver.FindElement(By.Id("Address.Address_1"));
        public IWebElement BuildingAndStreet_LineTwoField => driver.FindElement(By.Id("Address.Address_2"));
        public IWebElement BuildingAndStreet_LineThreeField => driver.FindElement(By.Id("Address.Address_3"));
        public IWebElement TownOrCityField => driver.FindElement(By.Id("Address.TownCity"));
        public IWebElement CountyField => driver.FindElement(By.Id("Address.County"));
        public IWebElement PostcodeField => driver.FindElement(By.Id("Address.PostCode"));
        public IWebElement CountryField => driver.FindElement(By.Id("Address.Country"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

        //Error Messaging
        public IWebElement EnterValidMobileError => driver.FindElement(By.XPath("//a[@href='#ContactDetails.Mobile']"));
        public IWebElement EnterValidTelephoneError => driver.FindElement(By.XPath("//a[@href='#ContactDetails.Telephone']"));
        public IWebElement EnterFirstLineOfAddressError => driver.FindElement(By.XPath("//a[normalize-space()='Please enter the first line of your address']"));
        public IWebElement EnterTownError => driver.FindElement(By.XPath("//a[normalize-space()='Please enter your town']"));
        public IWebElement EnterPostalCodeError => driver.FindElement(By.XPath("//a[normalize-space()='Please enter your postal code']"));
        public IWebElement EnterCountryError => driver.FindElement(By.XPath("//a[normalize-space()='Please enter the country in which you lived']"));

    }
}