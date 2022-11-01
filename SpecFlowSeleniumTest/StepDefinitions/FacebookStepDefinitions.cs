using OpenQA.Selenium;
using SpecFlowSeleniumTest.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumTest.StepDefinitions
{
    [Binding]
    public class FacebookStepDefinitions
    {
        public static IWebDriver driver = BrowserHook.driver;
        [Given(@"I navigate to facebook")]
        public void GivenINavigateToFacebook()
        {
            driver.Navigate().GoToUrl("fb.com");

        }
    }
}
