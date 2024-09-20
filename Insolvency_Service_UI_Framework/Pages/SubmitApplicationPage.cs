using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class SubmitApplicationPage
    {
        private IWebDriver driver;
        public SubmitApplicationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));

        //Buttons and PageElements
        public IWebElement SubmitMyApplication => driver.FindElement(By.Id("next"));
        public IWebElement BackToApplicationOverview => driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div/form/div[5]/a"));
    }
}
