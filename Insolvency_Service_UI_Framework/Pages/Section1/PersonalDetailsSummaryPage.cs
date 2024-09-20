using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PersonalDetailsSummaryPage
    {
        private IWebDriver driver;
        public PersonalDetailsSummaryPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        //Page Elements
        public IWebElement Edit_TitleField => driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/a[1]"));
        public IWebElement Edit_FirstNameField => driver.FindElement(By.XPath("//tbody/tr[2]/td[3]/a[1]"));
        public IWebElement Edit_MiddleNameField => driver.FindElement(By.XPath("//tbody/tr[3]/td[3]/a[1]"));
        public IWebElement Edit_LastNameField => driver.FindElement(By.XPath("//tbody/tr[4]/td[3]/a[1]"));
        public IWebElement Edit_OtherNamesField => driver.FindElement(By.XPath("//tbody/tr[5]/td[3]/a[1]"));
        public IWebElement Edit_DateOfBirthField => driver.FindElement(By.XPath("//tbody/tr[6]/td[3]/a[1]"));
        public IWebElement Edit_ContactDetailsField => driver.FindElement(By.XPath("//tbody/tr[7]/td[3]/a[1]"));
        public IWebElement Edit_CurrentAddressField => driver.FindElement(By.XPath("//tbody/tr[8]/td[3]/a[1]"));
        public IWebElement Edit_DateMovedInField => driver.FindElement(By.XPath("//tbody/tr[9]/td[3]/a[1]"));
        public IWebElement Edit_PeopelWhoLiveWithField => driver.FindElement(By.XPath("//tbody/tr[10]/td[3]/a[1]"));
        public IWebElement Edit_DependantsDontLiveField => driver.FindElement(By.XPath("//tbody/tr[11]/td[3]/a[1]"));
        public IWebElement Edit_PreviousAddressField => driver.FindElement(By.XPath("//tbody/tr[12]/td[3]/a[1]"));
        public IWebElement Edit_YourHouseholdSection => driver.FindElement(By.XPath("/html/body/main/div/div[2]/form[1]/div/table/tbody/tr/td[5]/a"));
        public IWebElement Delete_YourHouseholdSection => driver.FindElement(By.XPath("/html/body/main/div/div[2]/form[1]/div/table/tbody/tr/td[5]/span/input"));
        public IWebElement Edit_YourNonResidentDependantsSection => driver.FindElement(By.XPath("/html/body/main/div/div[2]/form[1]/div/table/tbody/tr/td[5]/span/a"));
        public IWebElement Delete_YourNonResidentDependantsSection => driver.FindElement(By.XPath("/html/body/main/div/div[2]/form[1]/div/table/tbody/tr/td[6]/span/input"));
        public IWebElement Continue_Button => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
