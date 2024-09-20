using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankruptcy_Automation_Framework.Pages
{
    public class SecurityQuestionsPage
    {
        private IWebDriver driver;
        public SecurityQuestionsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // Page Identifier
        public IWebElement PageHeading => driver.FindElement(By.XPath("//h1[@class='form-title heading-large']"));
        // Buttons and Elements
        public IWebElement SecurityQuestion1Link => driver.FindElement(By.Id("SecurityQuestionAnswers[0].SecurityQuestion"));
        public IWebElement GrandmotherQuestion => driver.FindElement(By.XPath("//*[@id=\"SecurityQuestionAnswers[0].SecurityQuestion\"]/option[2]"));
        public IWebElement ConcertQuestion => driver.FindElement(By.XPath("//*[@id=\"SecurityQuestionAnswers[0].SecurityQuestion\"]/option[3]"));
        public IWebElement LeastFavouriteTeacherQuestion => driver.FindElement(By.XPath("//*[@id=\"SecurityQuestionAnswers[0].SecurityQuestion\"]/option[4]"));
        public IWebElement FirstTelephoneNumberQuestion => driver.FindElement(By.XPath("//*[@id=\"SecurityQuestionAnswers[0].SecurityQuestion\"]/option[5]"));
        public IWebElement SecurityAnswer1InputField => driver.FindElement(By.Id("SecurityQuestionAnswers[0].SecurityAnswer"));
        public IWebElement SecurityQuestion2Link => driver.FindElement(By.Id("SecurityQuestionAnswers[1].SecurityQuestion"));
        public IWebElement ChilhoodHeroQuestion => driver.FindElement(By.XPath("//*[@id=\"SecurityQuestionAnswers[1].SecurityQuestion\"]/option[2]"));
        public IWebElement OldestSiblingMiddleNameQuestion => driver.FindElement(By.XPath("//*[@id=\"SecurityQuestionAnswers[1].SecurityQuestion\"]/option[3]"));
        public IWebElement FavouriteFilmQuestion => driver.FindElement(By.XPath("//*[@id=\"SecurityQuestionAnswers[1].SecurityQuestion\"]/option[4]"));
        public IWebElement TimeOfBirthQuestion => driver.FindElement(By.XPath("//*[@id=\"SecurityQuestionAnswers[1].SecurityQuestion\"]/option[5]"));
        public IWebElement SecurityAnswer2InputField => driver.FindElement(By.Id("SecurityQuestionAnswers[1].SecurityAnswer"));
        public IWebElement SecurityQuestion3Link => driver.FindElement(By.Id("SecurityQuestionAnswers[2].SecurityQuestion"));
        public IWebElement ParentsMeetQuestion => driver.FindElement(By.XPath("//*[@id=\"SecurityQuestionAnswers[2].SecurityQuestion\"]/option[2]"));
        public IWebElement FavouriteNovelQuestion => driver.FindElement(By.XPath("//*[@id=\"SecurityQuestionAnswers[2].SecurityQuestion\"]/option[3]"));
        public IWebElement BestFriendQuestion => driver.FindElement(By.XPath("//*[@id=\"SecurityQuestionAnswers[2].SecurityQuestion\"]/option[4]"));
        public IWebElement FavouriteToyQuestion => driver.FindElement(By.XPath("//*[@id=\"SecurityQuestionAnswers[2].SecurityQuestion\"]/option[5]"));
        public IWebElement SecurityAnswer3InputField => driver.FindElement(By.Id("SecurityQuestionAnswers[2].SecurityAnswer"));

        
        public IWebElement ContinueButton => driver.FindElement(By.Id("next"));
        public IWebElement BackButton => driver.FindElement(By.Id("back"));
    }
}
