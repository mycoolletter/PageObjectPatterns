using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObjectPatterns.Pages
{
    class ComplicatedPage : BaseSampleApplicationPage
    {
        public IWebElement SearchResult => driver.FindElements(By.XPath("//a[@class = 'jetpack-instant-search__search-result-minimal-title-link']"))[0];

        public ComplicatedPage(IWebDriver driver) : base(driver) { }

        public ComplicatedPage OpenSearchingResult()
        {
            #region OtherImplementation
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            //IWebElement element = wait.Until((d) =>
            //{
            //    return d.FindElements(By.XPath("//a[@class = 'jetpack-instant-search__search-result-minimal-title-link']"))[0];
            //});
            //element.Click(); 
            #endregion
            Thread.Sleep(4000);
            SearchResult.Click();
            return this;
        }
        public bool IsCorrectPageOpened(string expected)
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            return driver.Title.Contains(expected);
        }
    }
}
