using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{ 
public class FormerEmployeesClaimingMoneyPage_EmployeeDetails
{
    private IWebDriver driver;
    public FormerEmployeesClaimingMoneyPage_EmployeeDetails(IWebDriver driver)
    {
        this.driver = driver;
    }
    // Page Identifier
    public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
    public IWebElement FirstName_InputField => driver.FindElement(By.Id("FirstName"));
    public IWebElement LastName_InputField => driver.FindElement(By.Id("LastName"));
    public IWebElement AddressLine1 => driver.FindElement(By.Id("FormerEmployeeAddress.Address_1"));
    public IWebElement AddressLine2 => driver.FindElement(By.Id("FormerEmployeeAddress.Address_2"));
    public IWebElement AddressLine3 => driver.FindElement(By.Id("FormerEmployeeAddress.Address_3"));
    public IWebElement TownCity => driver.FindElement(By.Id("FormerEmployeeAddress.TownCity"));
    public IWebElement County => driver.FindElement(By.Id("FormerEmployeeAddress.County"));
    public IWebElement PostalCode => driver.FindElement(By.Id("FormerEmployeeAddress.PostCode"));
    public IWebElement Country => driver.FindElement(By.Id("FormerEmployeeAddress.Country"));
    public IWebElement ClaimAmount => driver.FindElement(By.Id("Amount"));
    public IWebElement ClaimReason => driver.FindElement(By.Id("Reason"));
    public IWebElement AddEmployeeButton => driver.FindElement(By.Id("next"));
    public IWebElement ContinueButton_NoFormerEmployees => driver.FindElement(By.Id("noFormerEmployees"));
    public IWebElement BackButton => driver.FindElement(By.Id("back"));
}
}