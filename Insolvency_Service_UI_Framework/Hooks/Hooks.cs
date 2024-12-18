using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using BSS_Automation_Framework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BSS_Automation_Framework.Hooks
{
    [Binding]
    public sealed class Hooks : ExtentReport
    {
        private readonly IObjectContainer _container;
        private static string _screenshotFolder;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Running before test run...");
            ExtentReportInit();
            ConfigUtil.InitAppConfig();
            ConfigUtil.InitTestData();

            _screenshotFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots");
            if (!Directory.Exists(_screenshotFolder))
            {
                Directory.CreateDirectory(_screenshotFolder);
            }
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("Running after test run...");
            ExtentReportTearDown();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine("Running before feature...");
            _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [BeforeScenario("@UI")]
        public void BeforeScenarioWithTag(ScenarioContext scenarioContext)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            _container.RegisterInstanceAs<IWebDriver>(driver);

            _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();
            driver?.Quit();
        }

        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            var driver = _container.Resolve<IWebDriver>();
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = scenarioContext.StepContext.StepInfo.Text;

            if (scenarioContext.TestError == null)
            {
                switch (stepType)
                {
                    case "Given":
                        _scenario.CreateNode<Given>(stepName);
                        break;
                    case "When":
                        _scenario.CreateNode<When>(stepName);
                        break;
                    case "Then":
                        _scenario.CreateNode<Then>(stepName);
                        break;
                    case "And":
                        _scenario.CreateNode<And>(stepName);
                        break;
                }
            }
            else
            {
                string screenshotPath = AddScreenshot(driver, scenarioContext);
                switch (stepType)
                {
                    case "Given":
                        _scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message,
                            MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
                        break;
                    case "When":
                        _scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message,
                            MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
                        break;
                    case "Then":
                        _scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message,
                            MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
                        break;
                    case "And":
                        _scenario.CreateNode<And>(stepName).Fail(scenarioContext.TestError.Message,
                            MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
                        break;
                }
            }
        }

        private string AddScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        {
            string screenshotName = $"{scenarioContext.ScenarioInfo.Title.Replace(" ", "_")}_{DateTime.Now:yyyyMMddHHmmss}.png";
            string screenshotPath = Path.Combine(_screenshotFolder, screenshotName);

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(screenshotPath); // Save as .png format directly based on file extension

            return screenshotPath;
        }
    }
}
