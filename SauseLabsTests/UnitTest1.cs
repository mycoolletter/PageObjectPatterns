using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AutomationResources;
using SampleAcliactionLifecycle;
using OpenQA.Selenium;

namespace SauseLabsTests
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [TestInitialize]
        public void SetUpForEveryTest()
        {
            driver = new WebDriverFactory().CreateSauceDriver();

        }
        [TestMethod]
        [TestProperty("Author", "IhorDzhemesiuk")]
        [Description("Go to page and check it")]
        [TestCategory("SauseLabsTests")]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("https://saucelabs.com/");
            Assert.AreEqual(driver.Title, "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs");
        }
        [TestMethod]
        [TestProperty("Author", "IhorDzhemesiuk")]
        [Description("Go to page and check it")]
        [TestCategory("SauseLabsTests")]
        public void TestMethod2()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Assert.AreEqual(driver.Title, "My Store");
        }
        [TestMethod]
        [TestProperty("Author", "IhorDzhemesiuk")]
        [Description("Go to page and check it")]
        [TestCategory("SauseLabsTests")]
        public void TestMethod3()
        {
            driver.Navigate().GoToUrl("https://ultimateqa.com/sample-application-lifecycle-sprint-2/");
            Assert.AreEqual(driver.Title, "Sample Application Lifecycle - Sprint 2 - Ultimate QA");
        }
        [TestCleanup]
        public void CleanUpForEveryTest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
