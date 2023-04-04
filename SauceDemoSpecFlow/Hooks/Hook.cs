using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using SauceDemoSpecFlow.utility;
using BoDi;

namespace SauceDemoSpecFlow.Stepdefinition.Hook
{
    [Binding]
    public class Hook : ExtentReport
    {
        private static IWebDriver driver;
        private readonly IObjectContainer _container;

        public Hook(IObjectContainer container)
        {
            _container = container;
        }

        public static IWebDriver getDrivers()
        {
            return driver;
        }

        // ExtentReport
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentReportStart();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext _featureContext)
        {
            //Create dynamic feature name
             Console.WriteLine("BeforeFeature");
            _feature = _extentReports.CreateTest<Feature>(_featureContext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext _scenarioContext)
        {
            Console.WriteLine("BeforeScenario");
            _scenario = _feature.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);


            ChromeOptions options = new ChromeOptions();
            options.AddArguments("headless");

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            
            
        }

        [AfterStep]
        public static void InsertReportingSteps(ScenarioContext _scenarioContext)
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            String StepInfo = ScenarioStepContext.Current.StepInfo.Text;

            if (_scenarioContext.StepContext.TestError == null)
            {
                if (stepType == "Given")
                    _scenario.CreateNode<When>(StepInfo).AddScreenCaptureFromBase64String(addScreenshot(driver, _scenarioContext));
                else if (stepType == "When")
                    _scenario.CreateNode<When>(StepInfo).AddScreenCaptureFromBase64String(addScreenshot(driver, _scenarioContext));
                else if (stepType == "Then")
                    _scenario.CreateNode<Then>(StepInfo).AddScreenCaptureFromBase64String(addScreenshot(driver, _scenarioContext));
                else if (stepType == "And")
                    _scenario.CreateNode<And>(StepInfo).AddScreenCaptureFromBase64String(addScreenshot(driver, _scenarioContext));
            }
            else if (_scenarioContext.StepContext.TestError != null)
            {
                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(StepInfo).Fail(_scenarioContext.StepContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromBase64String(addScreenshot(driver, _scenarioContext)).Build());
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(StepInfo).Fail(_scenarioContext.StepContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromBase64String(addScreenshot(driver, _scenarioContext)).Build());
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(StepInfo).Fail(_scenarioContext.StepContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromBase64String(addScreenshot(driver, _scenarioContext)).Build());
                }
                else if (stepType == "And")
                {
                    _scenario.CreateNode<And>(StepInfo).Fail(_scenarioContext.StepContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromBase64String(addScreenshot(driver, _scenarioContext)).Build());
                }
            }

        }

        [AfterScenario]
        public static void AfterScenario()
        {
            driver.Dispose();
            Console.WriteLine("AfterScenario");
            //implement logic that has to run after executing each scenario
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            //kill the browser
            ExtentReportStop();
        }

    }




}
