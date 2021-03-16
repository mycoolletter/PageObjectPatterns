using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AutomationResources;
using System.Threading;
using NLog;

namespace LoginPractice
{

    [TestCategory("LoginPractice")]
    [TestClass]
    public class UnitTest1 :BaseTest
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        TestUser testUser;
        TestUser emergencePerson;
        private SampleApplicationPage sampleApplicationPage;

        [TestInitialize]
        public override void SetUpDriver()
        {
            base.SetUpDriver();
            testUser = new TestUser();
            testUser.FirstName = "Ihor";
            testUser.LastName = "Dzhemesiuk";
            sampleApplicationPage = new SampleApplicationPage(driver);
            emergencePerson = new TestUser();
            emergencePerson.FirstName = "TTTT";
            emergencePerson.LastName = "AAAA";
        }

        private void AssertFinalPage(UltimateQAHomePage ultimateQAHomePage)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(ultimateQAHomePage.IsAvaliable);
        }


        [TestMethod]
        [TestCategory("Iteration Exercise")]
        public void Iteration2()
        {
            sampleApplicationPage.GoTo("https://ultimateqa.com/sample-application-lifecycle-sprint-2/"
                , "Sample Application Lifecycle - Sprint 2 - Ultimate QA");

            var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(testUser);
            AssertFinalPage(ultimateQAHomePage);
        }    
        [TestMethod]
        [TestCategory("Iteration Exercise")]
        public void Iteration3()
        {
            testUser.GenderType = Gender.Female;
            
            sampleApplicationPage.GoTo("https://ultimateqa.com/sample-application-lifecycle-sprint-3/"
                , "Sample Application Lifecycle - Sprint 3 - Ultimate QA");

            var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(testUser);
            AssertFinalPage(ultimateQAHomePage);
        }
        [TestMethod]
        [TestCategory("Iteration Exercise")]
        public void Iteration3Other()
        {
            testUser.GenderType = Gender.Other;
            sampleApplicationPage.GoTo("https://ultimateqa.com/sample-application-lifecycle-sprint-3/"
                , "Sample Application Lifecycle - Sprint 3 - Ultimate QA");
            var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(testUser);
            AssertFinalPage(ultimateQAHomePage);
        }     
        [TestMethod]
        [TestCategory("Iteration Exercise")]
        public void Iteration4()
        {
            emergencePerson.GenderType = Gender.Female;
            testUser.GenderType = Gender.Other;
            sampleApplicationPage.GoTo("https://ultimateqa.com/sample-application-lifecycle-sprint-4/"
                , "Sample Application Lifecycle - Sprint 4 - Ultimate QA");
            sampleApplicationPage.FillOutEmergenceContact(emergencePerson);
            var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(testUser);
            AssertFinalPage(ultimateQAHomePage);
        }

        [TestClass]
        public class ContactUsFeature :BaseTest
        {
            [TestMethod]
            [TestProperty("Author", "IhorDzhemesiuk")]
            [Description("Validate that the contact us page opens successfuly with a form")]
            [TestCategory("ContactUsFeature")]
            public void ContactUsForm()
            {
                ContactUsPage contactUsPage = new ContactUsPage(driver);
                contactUsPage.GoTo();
                Assert.IsTrue(contactUsPage.IsLocated, "The contact us page did not open");
            }
            [TestMethod]
            [TestProperty("Author", "IhorDzhemesiuk")]
            [Description("Check the slider works")]
            [TestCategory("ContactUsFeature")]
            public void CheckSlider()
            {
                HomePage homePage = new HomePage(driver);
                homePage.GoTo();
                homePage.Slider.ClickNextButton();
                Assert.AreNotEqual(homePage.Slider.SliderElementStyle, homePage.Slider.SliderStyleAfter);
            }
        }

    }
}
