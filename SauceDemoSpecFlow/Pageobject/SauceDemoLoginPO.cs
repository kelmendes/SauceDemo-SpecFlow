using OpenQA.Selenium;
using SauceDemoSpecFlow.Stepdefinition.Hook;
using System;

namespace SauceDemoSpecFlow.PageObjects
{
    class SauceDemoLoginPO
    {
        private IWebDriver driver;
        public String inputUserName = "//*[@id='user-name']";
        public String inputPassword = "//*[@id='password']";
        public String btnLogin = "//*[@id='login-button']";
        public String alertErroLogin = "//h3[@data-test='error']";
        public String btnMenuLateral = "//*[@id='react-burger-menu-btn']";
        public String btnLogoutMenuLateral = "//*[@id='logout_sidebar_link']";

        public SauceDemoLoginPO()
        {
           // driver = Hook.getDrivers();
        }

        public IWebElement InputUserName()
        {
            return Hook.getDrivers().FindElement(By.XPath(inputUserName));
        }

        public IWebElement InputPassword()
        {
            return Hook.getDrivers().FindElement(By.XPath(inputPassword));
        }

        public IWebElement botãoLogin()
        {
            return Hook.getDrivers().FindElement(By.XPath(btnLogin));
        }

        public bool alertErroLoginCheck()
        {
            bool temp = false;
            try
            {
                temp = Hook.getDrivers().FindElement(By.XPath(alertErroLogin)).Displayed;
                return temp;
            }
            catch (Exception NoSuchElementException){}
            return temp;
        }

        public IWebElement botãoMenuLateral()
        {
            return Hook.getDrivers().FindElement(By.XPath(btnMenuLateral));
        }

        public IWebElement botãoLogoutMenuLateral()
        {
            return Hook.getDrivers().FindElement(By.XPath(btnLogoutMenuLateral));
        }
    }
}
