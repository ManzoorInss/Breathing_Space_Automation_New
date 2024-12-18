using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BSS_Automation_Framework.Utilities
{
    public static class ConfigUtil
    {
        public static IConfiguration GetConfigKey { get; set; }
        public static IConfiguration GetTestDataKey { get; set; }
        public static string PortalBaseUrl { get; private set; }

        public static void InitAppConfig()
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory; // Gets bin/Debug path
            var configPath = Path.Combine(basePath, "..", "..", "..", "appSettings.json");

            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException($"Configuration file not found at {configPath}");
            }

            GetConfigKey = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(configPath))
                .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
                .Build();

            PortalBaseUrl = GetConfigKey["PortalBaseUrl"];
        }

        public static void InitTestData()
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory; // Gets bin/Debug path
            var testDataPath = Path.Combine(basePath, "..", "..", "..", "TestData", "TestData.json");

            if (!File.Exists(testDataPath))
            {
                throw new FileNotFoundException($"Test data file not found at {testDataPath}");
            }

            GetTestDataKey = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(testDataPath))
                .AddJsonFile("TestData.json", optional: false, reloadOnChange: true)
                .Build();
        }
    }
}

public class GlobalWait
    {
        private WebDriverWait _wait;

        public GlobalWait(IWebDriver driver, TimeSpan timeout)
        {
            _wait = new WebDriverWait(driver, timeout);
        }

        public void WaitForElementToBeClickable(By locator)
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }

        public void WaitForElementToBeClickable(IWebElement element)
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public void WaitForElementToBeVisible(By locator)
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public void WaitForElementToExist(By locator)
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }
    }