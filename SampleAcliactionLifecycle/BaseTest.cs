using AutomationResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SampleAcliactionLifecycle
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [TestInitialize]
        public virtual void  SetUpDriver()
        {
            var factory = new WebDriverFactory();
            driver = factory.Create(BrowserType.FireFox);

        }
        [TestCleanup]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}