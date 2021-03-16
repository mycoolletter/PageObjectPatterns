using OpenQA.Selenium;
using System;

namespace SampleAcliactionLifecycle
{
    internal class HomePage : BasePage
    {
        
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