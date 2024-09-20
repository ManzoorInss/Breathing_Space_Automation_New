using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class LegalProceedingsPage
    {
        private IWebDriver driver;
        public LegalProceedingsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        // Buttons and Elements

        public IWebElement SeparatedYes => driver.FindElement(By.Id("HasSeparated_Yes"));
        public IWebElement SeparatedNo => driver.FindElement(By.Id("HasSeparated_No"));
        public IWebElement SeparatedEdit => driver.FindElement(By.Id("btn-edit-separeted"));
        public IWebElement OngoingLegalYes => driver.FindElement(By.Id("HasOngoingLegalClaims_Yes"));
        public IWebElement OngoingLegalNo => driver.FindElement(By.Id("HasOngoingLegalClaims_No"));
        public IWebElement OngoingLegalEdit => driver.FindElement(By.Id("btn-edit-ongoingLegalClaims"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
