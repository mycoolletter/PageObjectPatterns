using NLog;
using OpenQA.Selenium;
using System;

namespace LoginPractice
{
    public class Slider : BasePage
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public Slider(IWebDriver driver) : base(driver)
        {
        }
        public string SliderElementStyle => driver.FindElement(By.Id("homeslider")).GetCssValue("left");

        public IWebElement NextButton => driver.FindElement(By.ClassName("bx-next"));

        public string SliderStyleAfter { get; private set; }

        internal void ClickNextButton()
        {
            NextButton.Click();
            SliderStyleAfter = driver.FindElement(By.Id("homeslider")).GetCssValue("left");
        }
    }
}