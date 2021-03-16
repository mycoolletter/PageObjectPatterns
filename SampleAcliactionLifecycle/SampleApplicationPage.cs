using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace SampleAcliactionLifecycle
{
    internal class SampleApplicationPage:BasePage
    {
        public SampleApplicationPage(IWebDriver driver) : base(driver) { }

        public bool IsAvaliable(string expected)
        {
            return driver.Title.Contains(expected);
        }
            

        public IWebElement FirstNameField => driver.FindElement(By.Name("firstname"));
        public IWebElement LastNameField => driver.FindElement(By.Name("lastname"));
        public IWebElement EmerFirstNameField => driver.FindElement(By.Id("f2"));
        public IWebElement EmerLastNameField => driver.FindElement(By.Id("l2"));
        public IWebElement FemaleRadioButton => driver.FindElement(By.XPath("//input[@value='female']"));
        public IWebElement OtherRadioButton => driver.FindElement(By.XPath("//input[@value='other']"));
        public IWebElement FemaleEmerRadioButton => driver.FindElement(By.Id("radio2-f"));


        internal void GoTo(string link, string expectedTitel)
        {
            driver.Navigate().GoToUrl(link);
            Assert.IsTrue(IsAvaliable(expectedTitel), $"Actual: {driver.Title} Expected: {expectedTitel}");
        }

        internal UltimateQAHomePage FillOutFormAndSubmit(TestUser testUser)
        {
            SetGender(testUser);

            FirstNameField.SendKeys(testUser.FirstName);
            LastNameField.SendKeys(testUser.LastName);
            LastNameField.Submit(); ;
            return new UltimateQAHomePage(driver);
        }

        private void SetGender(TestUser testUser)
        {
                switch (testUser.GenderType)
                {
                    case Gender.Male:
                        break;
                    case Gender.Female:
                        FemaleRadioButton.Click();
                        break;
                    case Gender.Other:
                    OtherRadioButton.Click();
                    break;
                    default:
                        break;
                }
        }       
        private void SetEmerGender(TestUser emergenceContactUser)
        {
                switch (emergenceContactUser.GenderType)
                {
                    case Gender.Male:
                        break;
                    case Gender.Female:
                        FemaleEmerRadioButton.Click();
                        break;
                    case Gender.Other:
                    OtherRadioButton.Click();
                    break;
                    default:
                        break;
                }
        }

        internal void FillOutEmergenceContact(TestUser emergenceContactUser)
        {
            SetEmerGender(emergenceContactUser);
            EmerFirstNameField.SendKeys(emergenceContactUser.FirstName);
            EmerLastNameField.SendKeys(emergenceContactUser.LastName);
        }
    }
}