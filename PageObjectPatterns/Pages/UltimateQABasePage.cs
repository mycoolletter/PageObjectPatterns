using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectPatterns.Pages
{
    class UltimateQABasePage: BaseSampleApplicationPage
    {
        public IWebElement Searchfield => driver.FindElement(By.XPath("//input[@class = 'et_pb_menu__search-input']"));
        public IWebElement SearchIcon => driver.FindElement(By.XPath("//*[@class = 'et_pb_menu__icon et_pb_menu__search-button' ]"));

        public UltimateQABasePage(IWebDriver driver) : base(driver) { }

        public UltimateQABasePage Open() 
        {
            driver.Navigate().GoToUrl("https://ultimateqa.com/");
            return this;
        }
        //public UltimateQABasePage Search(string searchingText)
        //{
        //    driver.FindElement(By.XPath("//*[@class = 'et_pb_menu__icon et_pb_menu__search-button' ]")).Click();
        //    var searchfield = driver.FindElement(By.XPath("//input[@class = 'et_pb_menu__search-input']"));
        //    searchfield.Clear();
        //    searchfield.SendKeys(searchingText);
        //    searchfield.Submit();
        //    return this;
        //}
        public ComplicatedPage Search(string searchingText)
        {
            SearchIcon.Click();
            Searchfield.Clear();
            Searchfield.SendKeys(searchingText);
            Searchfield.Submit();
            return new ComplicatedPage(driver);
        }
    }
}
