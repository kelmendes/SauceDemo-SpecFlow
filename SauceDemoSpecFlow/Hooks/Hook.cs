using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SauceDemoSpecFlow.Stepdefinition.Hook
{
    static class Hook
    {
        private static IWebDriver driver;

        public static void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

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
