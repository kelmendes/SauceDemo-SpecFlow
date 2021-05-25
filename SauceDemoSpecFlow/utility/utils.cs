using OpenQA.Selenium;
using SauceDemoSpecFlow.Stepdefinition.Hook;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoSpecFlow.utility
{
    public static class utils
    {
        public static string strNomeProduto = ("Sauce Labs Backpack, Sauce Labs Bike Light, Sauce Labs Onesie, Test.allTheThings() T-Shirt (Red), Sauce Labs Fleece Jacket, Sauce Labs Bolt T-Shirt");
        public static string getStrNomeProduto()
        {
            return strNomeProduto;
        }

        public static void scrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)Hook.getDrivers()).ExecuteScript("arguments[0].scrollIntoView();", element);

        }
    }
}
