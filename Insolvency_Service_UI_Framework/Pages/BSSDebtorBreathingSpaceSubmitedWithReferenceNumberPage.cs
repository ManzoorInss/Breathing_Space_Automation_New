using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BSSTestAutomation.Pages
{
    public class BSSBreathingSpaceConfirmationPage
    {
        private readonly IWebDriver _driver;
        private readonly ScenarioContext _scenarioContext;

        public BSSBreathingSpaceConfirmationPage(IWebDriver driver, ScenarioContext scenarioContext)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
            _scenarioContext = scenarioContext ?? throw new ArgumentNullException(nameof(scenarioContext));
        }

        // Page Elements
        public IWebElement ConfirmationTitle => _driver.FindElement(By.ClassName("govuk-panel__title"));
        public IWebElement ReferenceNumber => _driver.FindElement(By.CssSelector("#account-confirmation-reference strong"));
        public IWebElement ReturnToHomePageLink => _driver.FindElement(By.Id("account-confirmation-back-to-home"));
        public IWebElement FeedbackLink => _driver.FindElement(By.Id("leave-feedback-link"));

        // Methods
        public void ValidateConfirmationText()
        {
            string expectedTitle = "Breathing Space submitted";
            string actualTitle = ConfirmationTitle.Text.Trim();

            if (!actualTitle.Equals(expectedTitle, StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Confirmation text mismatch. Expected: '{expectedTitle}', but got: '{actualTitle}'.");
            }

            Console.WriteLine($"Confirmation text validated: {actualTitle}");
        }

        public string GetBSSReferenceNumber()
        {
            string reference = ReferenceNumber.Text.Trim();
            Console.WriteLine($"Captured reference number: {reference}");
            _scenarioContext["ReferenceNumber"] = reference; 
            return reference;
        }

        public void ReturnToHomePage()
        {
            ReturnToHomePageLink.Click();
            Console.WriteLine("Clicked 'Return to service homepage' link.");
        }

        public void ValidateFeedbackLink()
        {
            if (!FeedbackLink.Displayed)
            {
                throw new Exception("Feedback link is not displayed on the confirmation page.");
            }

            Console.WriteLine($"Feedback link is displayed: {FeedbackLink.GetAttribute("href")}");
        }
    }
}
