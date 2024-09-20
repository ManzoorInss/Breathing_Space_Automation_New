using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AssetDescriptionPage
    {
        private IWebDriver driver;
        public AssetDescriptionPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        public IWebElement FirstItemDescription => driver.FindElement(By.Id("Item_0"));
        public IWebElement FirstItemWorth => driver.FindElement(By.Id("ItemValue_0"));
        public IWebElement FirstItemSold_Yes => driver.FindElement(By.Id("ItemSold_0_0"));
        public IWebElement FirstItemSold_No => driver.FindElement(By.Id("ItemSold_0_1"));
        public IWebElement FirstItemDelete => driver.FindElement(By.Id("Delete_0"));
        public IWebElement SecondItemDescription => driver.FindElement(By.Id("Item_1"));
        public IWebElement SecondItemWorth => driver.FindElement(By.Id("ItemValue_1"));
        public IWebElement SecondItemSold_Yes => driver.FindElement(By.Id("ItemSold_1_0"));
        public IWebElement SecondItemSold_No => driver.FindElement(By.Id("ItemSold_1_1"));
        public IWebElement SecondItemDelete => driver.FindElement(By.Id("Delete_1"));
        public IWebElement AddAnotherItem => driver.FindElement(By.XPath("/html/body/main/div/div[2]/div/form/button"));
        public IWebElement Continue => driver.FindElement(By.Id("next"));
        public IWebElement Back => driver.FindElement(By.Id("back"));

    }
}
