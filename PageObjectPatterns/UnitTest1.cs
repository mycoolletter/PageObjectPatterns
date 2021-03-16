using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PageObjectPatterns.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace PageObjectPatterns
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;
        private UltimateQABasePage myPage;
        [TestInitialize]
        public void SetUpDriver()
        {
            driver = GetChromeDriver();
            myPage = new UltimateQABasePage(driver);
        }

        private ChromeDriver GetChromeDriver()
        {
            var driverLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(driverLocation);
        }

        [TestCleanup]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var complicatedPage = myPage.Open().Search("Complicated Page");
            bool isCorrectPage = complicatedPage.OpenSearchingResult().IsCorrectPageOpened("Complicated Page - Ultimate QA");
            Assert.IsTrue(isCorrectPage,"Complicated page is not opened");
        }
    }
}
