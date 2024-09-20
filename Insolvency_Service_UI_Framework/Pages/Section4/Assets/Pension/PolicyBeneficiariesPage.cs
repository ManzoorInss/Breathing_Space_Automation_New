using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class PolicyBeneficiariesPage
    {
        private IWebDriver driver;
        public PolicyBeneficiariesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement ApplicantSharePercentage => driver.FindElement(By.Id("PolicyBeneficiaries[0].BeneficiaryShare"));
        public IWebElement FirstJointBeneficiaryShare => driver.FindElement(By.Id("PolicyBeneficiaries[1].BeneficiaryShare"));
        public IWebElement FirstJointBeneficiaryEdit => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[1]/table/tbody/tr[2]/td[4]/span/a"));
        public IWebElement FirstJointBeneficiaryDelete => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/div[1]/table/tbody/tr[2]/td[5]/span/input"));
        public IWebElement FirstName => driver.FindElement(By.Id("FirstName"));
        public IWebElement LastName => driver.FindElement(By.Id("LastName"));
        public IWebElement AddBeneficiary => driver.FindElement(By.Id("add"));
        public IWebElement ContinueSoleBeneficiary => driver.FindElement(By.Id("next"));
        public IWebElement ContinueAddedAllBeneficiaries => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
