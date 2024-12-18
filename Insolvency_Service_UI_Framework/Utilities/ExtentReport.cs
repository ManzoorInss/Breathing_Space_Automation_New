using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Config;
using OpenQA.Selenium;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace BSS_Automation_Framework.Utilities
{
    public class ExtentReport
    {
        public static ExtentReports _extentReports;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;

        public static string dir = AppDomain.CurrentDomain.BaseDirectory;
        public static string testResultPath = Path.Combine(dir, "TestResults");
        public static string screenshotPath = Path.Combine(testResultPath, "Screenshots");
        public static string reportFilePath = Path.Combine(testResultPath, "ExtentReport.html"); // Correct file path

        public static void ExtentReportInit()
        {
            try
            {
                // Ensure TestResults and Screenshots directories exist
                if (!Directory.Exists(testResultPath))
                    Directory.CreateDirectory(testResultPath);

                if (!Directory.Exists(screenshotPath))
                    Directory.CreateDirectory(screenshotPath);

                // Initialize ExtentSparkReporter with a proper file path
                var htmlReporter = new ExtentSparkReporter(reportFilePath);
                htmlReporter.Config.ReportName = "Automation Status Report";
                htmlReporter.Config.DocumentTitle = "Automation Status Report";
                htmlReporter.Config.Theme = Theme.Standard;

                // Attach reporter
                _extentReports = new ExtentReports();
                _extentReports.AttachReporter(htmlReporter);
                _extentReports.AddSystemInfo("Application", "Breathing Space Application");
                _extentReports.AddSystemInfo("Browser", "Chrome");
                _extentReports.AddSystemInfo("OS", "Windows");

                Console.WriteLine($"Extent report initialized. Report path: {reportFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing Extent Reports: {ex.Message}");
            }
        }

        public static void ExtentReportTearDown()
        {
            try
            {
                _extentReports.Flush();
                Console.WriteLine($"Extent report generated successfully at: {reportFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error flushing Extent Report: {ex.Message}");
            }
        }

        public string AddScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        {
            try
            {
                ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
                Screenshot screenshot = takesScreenshot.GetScreenshot();

                // Construct screenshot file name
                string screenshotName = $"{scenarioContext.ScenarioInfo.Title.Replace(" ", "_")}_{DateTime.Now:yyyyMMddHHmmss}.png";
                string screenshotLocation = Path.Combine(screenshotPath, screenshotName);

                // Ensure the Screenshots directory exists
                if (!Directory.Exists(screenshotPath))
                {
                    Directory.CreateDirectory(screenshotPath);
                }

                // Save the screenshot (file extension decides the format)
                screenshot.SaveAsFile(screenshotLocation); // Default is PNG

                Console.WriteLine($"Screenshot captured: {screenshotLocation}");
                return screenshotLocation;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error capturing screenshot: {ex.Message}");
                return string.Empty;
            }
        }

    }
}
