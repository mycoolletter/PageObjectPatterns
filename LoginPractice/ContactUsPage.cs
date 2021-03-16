using NLog;
using OpenQA.Selenium;
using System;

namespace LoginPractice
{
    internal class ContactUsPage: BasePage
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public bool IsLocated => driver.FindElement(By.Id("columns")).Displayed;

        public ContactUsPage(IWebDriver driver) : base  (driver)
        {
        }

        internal void GoTo()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }

        internal object FillOutAllFields()
        {
            throw new NotImplementedException();
        }
    }
}