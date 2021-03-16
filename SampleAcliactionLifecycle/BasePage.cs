using OpenQA.Selenium;

namespace SampleAcliactionLifecycle
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}