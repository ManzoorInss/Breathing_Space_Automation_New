using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class SoldTransferredGiftedAssetsPage
    {
        private IWebDriver driver;
        public SoldTransferredGiftedAssetsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement SoldProperties_Yes => driver.FindElement(By.Id("HasSoldProperties_Yes"));
        public IWebElement SoldProperties_No => driver.FindElement(By.Id("HasSoldProperties_No"));
        public IWebElement SoldPensionInsurance_Yes => driver.FindElement(By.Id("HasSoldPolicies_Yes"));
        public IWebElement SoldPensionInsurance_No => driver.FindElement(By.Id("HasSoldPolicies_No"));
        public IWebElement SoldAssets_Yes => driver.FindElement(By.Id("HasSoldAssets_Yes"));
        public IWebElement SoldAssets_No => driver.FindElement(By.Id("HasSoldAssets_No"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));

    }
}
