using NLog;
using OpenQA.Selenium;

namespace LoginPractice
{
    public class BasePage
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}