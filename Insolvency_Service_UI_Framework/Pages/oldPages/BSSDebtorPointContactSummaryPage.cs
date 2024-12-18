//using CinnamonCS.Driver.Web.Controls;
//using CinnamonCS.Driver.Web.Driver;
//using CinnamonCS.Driver.Web.Lib.Attributes;
//using CinnamonCS.Driver.Web.Lib.Enums;

//namespace BSSTestAutomation.Pages
//{
//    public class BSSDebtorPointContactSummaryPage
//    {
//        public IDriver Driver { get; }

//        public BSSDebtorPointContactSummaryPage(IDriver driver)
//        {
//            Driver = driver;
//        }

//        [Find(By: By.Id, Using: "point-contact-summary-heading")]
//        public virtual IPageElement PageTitle { get; set; }

//        [Find(By: By.Id, Using: "back-link")]
//        public virtual IPageElement BackLink { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-name-lbl")]
//        public virtual IPageElement NameHeader { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-name")]
//        public virtual IPageElement FullName { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-tel")]
//        public virtual IPageElement TelNo { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-email")]
//        public virtual IPageElement Email { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-notification")]
//        public virtual IPageElement ContactType { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-address")]
//        public virtual IPageElement Address { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-role")]
//        public virtual IPageElement Role { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-chng-name")]
//        public virtual IPageElement AddOrChangeNameLink { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-role-lbl")]
//        public virtual IPageElement RoleHeader { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-chng-role")]
//        public virtual IPageElement AddOrChangeRoleLink { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-tel-lbl")]
//        public virtual IPageElement TelNoHeader { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-chng-tel")]
//        public virtual IPageElement AddOrChangeTelNoLink { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-not-lbl")]
//        public virtual IPageElement NotificationsHeader { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-chng-notification")]
//        public virtual IPageElement AddOrChangeNotificationLink { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-email-lbl")]
//        public virtual IPageElement EmailHeader { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-chng-email")]
//        public virtual IPageElement AddOrChangeEmailLink { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-address-lbl")]
//        public virtual IPageElement AddressHeader { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-chng-address")]
//        public virtual IPageElement AddOrChangeAddressLink { get; set; }

//        [Find(By: By.Id, Using: "point-contact-summary-save")]
//        public virtual IButtonElement SaveAndContinueButton { get; set; }
//    }
//}