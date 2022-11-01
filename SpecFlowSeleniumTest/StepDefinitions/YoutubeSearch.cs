using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SpecFlowSeleniumTest.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowSeleniumTest.StepDefinitions
{
    [Binding]
    public class YoutubeSearch
    {
        private ChromeDriver chromedriver;

        private DriverContext _driverContext;

        public YoutubeSearch(DriverContext driverContext)
        {
            this._driverContext = driverContext;
        }

        [Given(@"Youtube is open in chrome")]
        public void GivenYoutubeIsOpenInChrome()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("123")));


         }

        [When(@"I type '([^']*)' on search")]
        public void WhenITypeOnSearch(string india)
        {
            throw new PendingStepException();
        }

        [Then(@"results shown")]
        public void ThenResultsShown()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(TimeoutException));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("123")));


            DefaultWait<IWebDriver> FluentWait = new DefaultWait<IWebDriver>(chromedriver);
            FluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            FluentWait.Timeout = TimeSpan.FromSeconds(5);

            FluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            FluentWait.Message = "Not found";

            FluentWait.Until(x => x.FindElement(By.ClassName("123")));




        }

    }
}
