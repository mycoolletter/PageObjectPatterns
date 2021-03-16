using NLog;
using OpenQA.Selenium;
using System;

namespace LoginPractice
{
    internal class HomePage : BasePage
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.Slider = new Slider(driver);
        }

        public Slider Slider { get; internal set; }

        internal void GoTo()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
    }
}