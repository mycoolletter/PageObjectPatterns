using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectPatterns.Pages
{
    class BaseSampleApplicationPage
    {
        protected IWebDriver driver;
        public BaseSampleApplicationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
