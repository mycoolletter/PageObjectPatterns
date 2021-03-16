using OpenQA.Selenium;
using System;

namespace SampleAcliactionLifecycle
{
    internal class ContactUsPage: BasePage
    {

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