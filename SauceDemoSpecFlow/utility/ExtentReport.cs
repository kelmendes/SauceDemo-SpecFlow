using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SauceDemoSpecFlow.utility
{
    public class ExtentReport
    {
        public static ExtentReports _extentReports;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;

        public static String dirActual = AppDomain.CurrentDomain.BaseDirectory;
        public static String reportFinalPath = dirActual.Replace("bin\\Debug\\net5.0", "TestResults");



        //Start Report
        public static void ExtentReportStart()
        {
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportFinalPath);
            htmlReporter.Config.ReportName = "Name";
            htmlReporter.Config.DocumentTitle = "Title";
            htmlReporter.Config.Theme = Theme.Standard;
            htmlReporter.Start();

            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(htmlReporter);
        }

        // Finish Report 
        public static void ExtentReportStop()
        {
            _extentReports.Flush();
        }

        public static string addScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotLocation = screenshot.AsBase64EncodedString;
            return screenshotLocation;
        }


    }
}
