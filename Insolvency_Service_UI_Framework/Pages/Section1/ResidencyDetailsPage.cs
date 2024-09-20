using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class ResidencyDetailsPage
    {
        private IWebDriver driver;
        public ResidencyDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        //PageElements
        public IWebElement DateMovedIn_MonthField => driver.FindElement(By.Id("DateMovedIn_Month"));
        public IWebElement January => driver.FindElement(By.XPath("//*[@id=\"DateMovedIn_Month\"]/option[2]"));
        public IWebElement February => driver.FindElement(By.XPath("//*[@id=\"DateMovedIn_Month\"]/option[3]"));
        public IWebElement March => driver.FindElement(By.XPath("//*[@id=\"DateMovedIn_Month\"]/option[4]"));
        public IWebElement April => driver.FindElement(By.XPath("//*[@id=\"DateMovedIn_Month\"]/option[5]"));
        public IWebElement May => driver.FindElement(By.XPath("//*[@id=\"DateMovedIn_Month\"]/option[6]"));
        public IWebElement June => driver.FindElement(By.XPath("//*[@id=\"DateMovedIn_Month\"]/option[7]"));
        public IWebElement July => driver.FindElement(By.XPath("//*[@id=\"DateMovedIn_Month\"]/option[8]"));
        public IWebElement August => driver.FindElement(By.XPath("//*[@id=\"DateMovedIn_Month\"]/option[9]"));
        public IWebElement Septemeber => driver.FindElement(By.XPath("//*[@id=\"DateMovedIn_Month\"]/option[10]"));
        public IWebElement October => driver.FindElement(By.XPath("//*[@id=\"DateMovedIn_Month\"]/option[11]"));
        public IWebElement November => driver.FindElement(By.XPath("//*[@id=\"DateMovedIn_Month\"]/option[12]"));
        public IWebElement December => driver.FindElement(By.XPath("//*[@id=\"DateMovedIn_Month\"]/option[13]"));
        public IWebElement Year => driver.FindElement(By.Id("DateMovedIn_Year"));
        public IWebElement OwntheProperty_YesOption => driver.FindElement(By.Id("PropertyOwnership_0"));
        public IWebElement OwntheProperty_NoTennacyOption => driver.FindElement(By.Id("PropertyOwnership_1"));
        public IWebElement OwntheProperty_NoLiveWithFamilyOption => driver.FindElement(By.Id("PropertyOwnership_2"));
        public IWebElement OwntheProperty_OtherOption => driver.FindElement(By.Id("PropertyOwnership_Other"));
        public IWebElement OtherOptionInputField => driver.FindElement(By.Id("PropertyOwnership_OtherText"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
