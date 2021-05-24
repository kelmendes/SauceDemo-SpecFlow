using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SauceDemoSpecFlow.Stepdefinition.Hook
{
    [Binding]
    static class Hook
    {
        private static IWebDriver driver;

        [BeforeScenario]
        public static void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
        [AfterScenario]
        public static void tearDown()
        {
            driver.Dispose();
        }

        public static IWebDriver getDrivers()
        {
            return driver;
        }

    }

    
}
