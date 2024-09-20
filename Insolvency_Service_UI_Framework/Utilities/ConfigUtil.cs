using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Utilities
{
    public class ConfigUtil
    {
        public static string RunningConfig { get; set; }
        public static IConfiguration GetConfigKey { get; set; }
        public static IConfiguration GetTestDataKey { get; set; }
        public static string PortalBaseUrl { get; set; }
        public static string ODSAdminUrl { get; set; }
        public static string ODSAdminUsername { get; set; }
        public static string ODSAdminPassword { get; set; }
        public static string ODSAdjudicatorUrl { get; set; }
        public static string ODSAdjudicatorUsername { get; set; }
        public static string ODSAdjudicatorPassword { get; set; }
        public static string MailTrapUrl { get; set; }
        public static string MailTrapUsername { get; set; }
        public static string MailTrapPassword { get; set; }
        public static string PaymentCardNumber { get; set; }
        public static string PaymentSecurityNumber { get; set; }
        public static string LoremIpsum { get; set; }
        public static string SpecialCharacters { get; set; }

        private static IConfiguration InitAppConfiguration =>
            new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{RunningConfig}.json")
                .Build();

        private static IConfiguration InitTestDataConfiguration =>
            new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@"Data\TestData.json", optional: true, reloadOnChange: true)
                .Build();
        public static void InitAppConfig()
        {
            // TODO: find a proper way to get the running configuration
            var assemblyPath = Assembly.GetExecutingAssembly().Location;
            var folders = assemblyPath.Split('\\').ToList();
            // get the folder after bin
            var binPosition = folders.IndexOf("bin");
            RunningConfig = folders[binPosition + 1];
            GetConfigKey = InitAppConfiguration;
        }

        public static void InitTestData()
        {
            GetTestDataKey = InitTestDataConfiguration;
        }
    }
}
