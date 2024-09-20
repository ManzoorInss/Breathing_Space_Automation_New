using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class ActionsTakenPage
    {
        private IWebDriver driver;
        public ActionsTakenPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement FirstCreditor_FormalActionYes => driver.FindElement(By.XPath("/html/body/main/div/div[2]/form/div[2]/fieldset[1]/div/div[2]/div/label[1]/input"));
        public IWebElement FirstCreditor_FormalActionNo => driver.FindElement(By.XPath("/html/body/main/div/div[2]/form/div[2]/fieldset[1]/div/div[2]/div/label[2]/input"));
        public IWebElement SecondCreditor_FormalActionYes => driver.FindElement(By.XPath("/html/body/main/div/div[2]/form/div[2]/fieldset[2]/div/div[2]/div/label[1]/input"));
        public IWebElement SecondCreditor_FormalActionNo => driver.FindElement(By.XPath("/html/body/main/div/div[2]/form/div[2]/fieldset[2]/div/div[2]/div/label[2]/input"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));

    }
}
