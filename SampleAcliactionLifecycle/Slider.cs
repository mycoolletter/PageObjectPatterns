using OpenQA.Selenium;
using System;

namespace SampleAcliactionLifecycle
{
    public class Slider : BasePage
    {
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