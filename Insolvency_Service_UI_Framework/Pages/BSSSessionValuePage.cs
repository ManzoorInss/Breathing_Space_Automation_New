using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BSSTestAutomation.Pages
{
    public class BSSSessionValuePage
    {
        private IWebDriver _driver;

        public BSSSessionValuePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SessionValuePageTitle => _driver.FindElement(By.ClassName("govuk-fieldset__heading"));
        public IWebElement SessionValuePageName => _driver.FindElement(By.CssSelector("input[id*='Values[0].Name']"));
        public IWebElement SessionValuePageValue => _driver.FindElement(By.CssSelector("input[id*='Values[0].Value']"));
        public IWebElement SessionValuePageName2 => _driver.FindElement(By.CssSelector("input[id*='Values[1].Name']"));
        public IWebElement SessionValuePageValue2 => _driver.FindElement(By.CssSelector("input[id*='Values[1].Value']"));
        public IWebElement SessionValuePageRedirectUrl => _driver.FindElement(By.Id("RedirectUrl-input"));
        public IWebElement SessionValuePageRedirectButton => _driver.FindElement(By.Id("search-button"));

        public void ClickRedirect()
        {
            SessionValuePageRedirectButton.Click();
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.Url.Contains("next-page-url-part"));
        }

        public void EnterSessionValueName(string name)
        {
            SessionValuePageName.Clear();
            SessionValuePageName.SendKeys(name);
        }

        public void EnterSessionValue(string value)
        {
            SessionValuePageValue.Clear();
            SessionValuePageValue.SendKeys(value);
        }

        public void EnterSessionValueName2(string name)
        {
            SessionValuePageName2.Clear();
            SessionValuePageName2.SendKeys(name);
        }

        public void EnterSessionValue2(string value)
        {
            SessionValuePageValue2.Clear();
            SessionValuePageValue2.SendKeys(value);
        }

        public void EnterRedirectUrl(string url)
        {
            SessionValuePageRedirectUrl.Clear();
            SessionValuePageRedirectUrl.SendKeys(url);
        }
    }
}
