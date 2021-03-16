using AutomationResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using OpenQA.Selenium;

namespace LoginPractice
{
    public class BaseTest
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        protected IWebDriver driver;

        [TestInitialize]
        public virtual void  SetUpDriver()
        {
            var factory = new WebDriverFactory();
            driver = factory.Create(BrowserType.Chrome);

        }
        [TestCleanup]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}