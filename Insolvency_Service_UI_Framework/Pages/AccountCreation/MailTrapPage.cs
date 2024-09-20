using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class MailTrapPage
    {
        private IWebDriver driver;
        public MailTrapPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Login Page

        public IWebElement mailTrapLoginPageHeading => driver.FindElement(By.XPath("/html/body/main/div/div[1]/h1"));
        public IWebElement mailTrapUserEmail => driver.FindElement(By.Id("user_email"));
        public IWebElement mailTrapNextButton => driver.FindElement(By.XPath("/html/body/main/div/div[1]/form/div[3]/a"));
        public IWebElement mailTrapUserPassword => driver.FindElement(By.Id("user_password"));
        public IWebElement mailTrapLogInButton => driver.FindElement(By.XPath("/html/body/main/div/div[1]/form/div[2]/div[3]/input"));
        public IWebElement mailTrapPasswordButton => driver.FindElement(By.XPath("/html/body/main/div/div[1]/form/div[2]/div[1]/div/a"));
        public IWebElement mailTrapCookiesAgreement => driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll"));

        //Project Page
        public IWebElement mailTrapProjectsHeader => driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[1]/h1"));

        //Inbox Page
        public IWebElement mailTrapInboxHeader => driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/nav/span"));
        public IWebElement MailTrapEmailSearchBox => driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div[1]/div[1]/input"));
        public IWebElement MailTrapEmailSearchButton => driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div[1]/div[1]/svg"));
        public IWebElement MailTrapEmailExistence => driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[1]/div[2]/ul/li[1]/a/span[2]/p/span"));

        //Switch to Email IFrame

        public IWebElement EmailIFrame => driver.FindElement(By.XPath("//*[@id=\"html_tabpanel\"]/div[2]/div/div/iframe"));

        //Email Elements
        public IWebElement mailTrapEmail => driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div/div[1]/div[2]/ul/li[1]/a"));
        public IWebElement ApplicationNumber => driver.FindElement(By.Id("urn"));
    }
}
