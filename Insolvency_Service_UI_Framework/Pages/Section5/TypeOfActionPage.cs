using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{ 
    public class TypeOfActionPage
    {
        private IWebDriver driver;
        public TypeOfActionPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement TookControlOfAssets => driver.FindElement(By.Id("TypeOfAction_0"));
        public IWebElement AttachmentOfEarnings => driver.FindElement(By.Id("TypeOfAction_1"));
        public IWebElement Continue => driver.FindElement(By.Id("Continue"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
