using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using BSS_Automation_Framework.Utilities;

namespace BSSTestAutomation.Pages
{
    public class BSSLoginPage
    {
        private IWebDriver _driver;

        public BSSLoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Elements 

        public IWebElement UsernameField => _driver.FindElement(By.Id("user_id"));
        public IWebElement PasswordField => _driver.FindElement(By.Id("password"));
        public IWebElement SignInButton => _driver.FindElement(By.Id("continue")); 
        public IWebElement ErrorMessage => _driver.FindElement(By.ClassName("govuk-error-message"));
        public IWebElement OneTimePasswordField => _driver.FindElement(By.Id("oneTimePassword"));

        public void BSSLogin(string username, string password)
        {
            GlobalWait wait = new GlobalWait(_driver, TimeSpan.FromSeconds(10));

            wait.WaitForElementToBeClickable(UsernameField);
            UsernameField.Click();
            UsernameField.Clear();
            UsernameField.SendKeys(username);

            wait.WaitForElementToBeClickable(PasswordField);
            PasswordField.Click();
            PasswordField.Clear();
            PasswordField.SendKeys(password);

            wait.WaitForElementToBeClickable(SignInButton);
            SignInButton.Click();
        }
        public void EnterOnetimePassword(string onetimepassword)
        {

            OneTimePasswordField.Click();
            OneTimePasswordField.Clear();
            OneTimePasswordField.SendKeys(onetimepassword);
            SignInButton.Click();
            Thread.Sleep(5000);
        }
        public string GetErrorMessage()
        {
            return ErrorMessage.Text;
        }
    }
}