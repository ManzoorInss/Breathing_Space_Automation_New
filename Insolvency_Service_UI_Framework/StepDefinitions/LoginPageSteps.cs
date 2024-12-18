using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using BSSTestAutomation.Pages;
using BSS_Automation_Framework.Utilities;

[Binding]
public class BSSLoginPageSteps
{
    private IWebDriver _driver;
    private BSSLoginPage _bssLoginPage;

    public BSSLoginPageSteps(IWebDriver driver, BSSLoginPage bSSLoginPage)
    {
        _driver = driver;
        _bssLoginPage = bSSLoginPage;
    }

    [Given(@"I log into the Breathing Space Application")]
    public void GivenILogIntoTheBreathingSpaceApplication()
    {
        _driver.Navigate().GoToUrl(ConfigUtil.PortalBaseUrl);
        _bssLoginPage.BSSLogin("28 09 73 31 15 10", "Test@123456");
        _bssLoginPage.EnterOnetimePassword("123456");
    }
}
