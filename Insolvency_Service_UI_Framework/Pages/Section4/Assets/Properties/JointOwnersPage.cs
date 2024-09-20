using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class JointOwnersPage
    {
        private IWebDriver driver;
        public JointOwnersPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement SharePercentage => driver.FindElement(By.Id("JointOwners[0].JointOwnerShare"));
        public IWebElement FirstJointOwnerSharePercentage => driver.FindElement(By.Id("JointOwners[1].JointOwnerShare"));
        public IWebElement SecondJointOwnerSharePercentage => driver.FindElement(By.Id("JointOwners[2].JointOwnerShare"));
        public IWebElement ThirdJointOwnerSharePercentage => driver.FindElement(By.Id("JointOwners[3].JointOwnerShare"));
        public IWebElement FirstJointOwnerEdit => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[1]/table/tbody/tr[2]/td[4]/span/a"));
        public IWebElement FirstJointOwnerDelete => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[1]/table/tbody/tr[2]/td[5]/span/input"));
        public IWebElement FirstName => driver.FindElement(By.Id("FirstName"));
        public IWebElement LastName => driver.FindElement(By.Id("LastName"));
        public IWebElement AddJointOwner => driver.FindElement(By.Id("add"));
        public IWebElement ContinueSoleOwner => driver.FindElement(By.Id("continue"));
        public IWebElement ContinueAddedAllJointOwners => driver.FindElement(By.Id("continue"));

    }
}
