using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class AdjudicatorDashboardPage
    {
        private IWebDriver driver;
        public AdjudicatorDashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//*[@id=\"content\"]/div/h1"));

        // Buttons and Elements
        public IWebElement Active => driver.FindElement(By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]/ul[1]/li[1]/a"));
        public IWebElement Pending => driver.FindElement(By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]/ul[1]/li[2]/a"));
        public IWebElement Completed => driver.FindElement(By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]/ul[1]/li[3]/a"));
        public IWebElement NonCompleted => driver.FindElement(By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]/ul[1]/li[4]/a"));
        public IWebElement All => driver.FindElement(By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]/ul[1]/li[5]/a"));
        public IWebElement FilterResults => driver.FindElement(By.Id("searchString"));
        public IWebElement ReferenceOrder => driver.FindElement(By.Id("urn"));
        public IWebElement NameOrder => driver.FindElement(By.Id("name"));
        public IWebElement ReceivedOrder => driver.FindElement(By.Id("date"));
        public IWebElement FirstCase => driver.FindElement(By.XPath("/html/body/div[3]/div/div[4]/table/tbody/tr[1]/td[1]/a"));
        public IWebElement SecondCase => driver.FindElement(By.Id("/html/body/div[3]/div/div[4]/table/tbody/tr[2]/td[1]/a"));
        public IWebElement ThirdCase => driver.FindElement(By.Id("/html/body/div[3]/div/div[4]/table/tbody/tr[3]/td[1]/a"));
        public IWebElement FourthCase => driver.FindElement(By.Id("/html/body/div[3]/div/div[4]/table/tbody/tr[4]/td[1]/a"));
        public IWebElement FifthCase => driver.FindElement(By.Id("/html/body/div[3]/div/div[4]/table/tbody/tr[5]/td[1]/a"));



    }
}
