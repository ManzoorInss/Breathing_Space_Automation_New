using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    internal class HelpWithApplicationDetailsPage
    {
        private IWebDriver driver;
        public HelpWithApplicationDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/h1"));

        //Page Elements

        public IWebElement CannotFindAppNumber => driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div/form/div[1]/a"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
