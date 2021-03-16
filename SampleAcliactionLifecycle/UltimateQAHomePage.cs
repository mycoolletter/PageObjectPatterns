using OpenQA.Selenium;

namespace SampleAcliactionLifecycle
{
    internal class UltimateQAHomePage:BasePage
    {
        public UltimateQAHomePage(IWebDriver driver) : base(driver) { }

        public bool IsAvaliable 
        {
            get
            {
               return driver.Title.Contains("Home - Ultimate QA");
            }
            set { }
        }

    }
}