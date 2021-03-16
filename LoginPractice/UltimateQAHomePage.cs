using NLog;
using OpenQA.Selenium;

namespace LoginPractice
{
    internal class UltimateQAHomePage:BasePage
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
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