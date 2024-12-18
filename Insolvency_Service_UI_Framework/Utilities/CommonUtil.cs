using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSS_Automation_Framework.Utilities
{
    public static class FieldHelper
    {
        public static void FillField(IWebElement field, string value)
        {
            field.Clear();
            if (!string.IsNullOrWhiteSpace(value))
            {
                field.SendKeys(value);
            }
        }

        public static void ValidateFieldError(IWebElement field, IWebElement validationElement)
        {
            field.Clear();
            if (validationElement != null && string.IsNullOrEmpty(validationElement.Text))
            {
                string fieldId = field.GetDomAttribute("id") ?? "unknown field";
                throw new Exception($"Expected validation error but none displayed for field: {fieldId}");
            }
        }
    }
}

