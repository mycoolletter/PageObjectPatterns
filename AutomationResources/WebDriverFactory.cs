using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using System;

namespace AutomationResources
{
    public class WebDriverFactory
    {
        public WebDriverFactory()
        {
        }

        public IWebDriver Create(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();
                    break;
                case BrowserType.FireFox:
                    return GetFireFoxDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("No such browser exists");
                    break;
            }
        }

        public IWebDriver CreateSauceDriver()
        {
            // // use next link for help  https://wiki.saucelabs.com/display/DOCS/Platform+Configurator?src=sidebar#/


            #region /* Mac OS run for Safari*/
            // var capabilities = new SafariOptions();
            // capabilities.PlatformName = "macOS 10.15";
            // capabilities.BrowserVersion = "latest";
            // return new RemoteWebDriver(new Uri("https://IDzhemesiuk:be9b48d672ee46019581e026c7c9515f@ondemand.eu-central-1.saucelabs.com:443/wd/hub"),capabilities);

            #endregion

            #region /* Windows OS run for Chrome*/
            //var capabilities2 = new ChromeOptions();
            //capabilities2.UseSpecCompliantProtocol = true;//use for Chrome
            //capabilities2.PlatformName = "Windows 10";
            //capabilities2.BrowserVersion = "latest";
            //return new RemoteWebDriver(new Uri("https://IDzhemesiuk:be9b48d672ee46019581e026c7c9515f@ondemand.eu-central-1.saucelabs.com:443/wd/hub"), capabilities2); 
            #endregion

            #region /*Linux OS run for Chrome*/
            //DesiredCapabilities caps = new DesiredCapabilities();
            //caps.SetCapability("browserName", "Chrome");
            //caps.SetCapability("platform", "Linux");
            //caps.SetCapability("version", "latest");
            //return new RemoteWebDriver(new Uri("https://IDzhemesiuk:be9b48d672ee46019581e026c7c9515f@ondemand.eu-central-1.saucelabs.com:443/wd/hub"), caps); 
            #endregion

            #region /* Iphone OS run for Safari*/
            //DesiredCapabilities caps = new DesiredCapabilities();
            //caps.SetCapability("deviceName", "iPhone XS Max Simulator");
            //caps.SetCapability("deviceOrientation", "portrait");
            //caps.SetCapability("platformVersion", "14.3");
            //caps.SetCapability("platformName", "iOS");
            //caps.SetCapability("browserName", "Safari");
            //return new RemoteWebDriver(new Uri("https://IDzhemesiuk:be9b48d672ee46019581e026c7c9515f@ondemand.eu-central-1.saucelabs.com:443/wd/hub"), caps,TimeSpan.FromSeconds(120));

            #endregion

            /* Android OS run for Chrome*/
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("deviceName", "Samsung Galaxy S9 WQHD GoogleAPI Emulator");
            caps.SetCapability("deviceOrientation", "portrait");
            caps.SetCapability("browserName", "Chrome");
            caps.SetCapability("platformVersion", "9.0");
            caps.SetCapability("platformName", "Android");
            return new RemoteWebDriver(new Uri("https://IDzhemesiuk:be9b48d672ee46019581e026c7c9515f@ondemand.eu-central-1.saucelabs.com:443/wd/hub"), caps,TimeSpan.FromSeconds(120));
        }

        private IWebDriver GetFireFoxDriver()
        {
            return new FirefoxDriver();
        }

        private ChromeDriver GetChromeDriver()
        {
            return new ChromeDriver();
        }
    }
}