using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumTest.Hooks
{
    [Binding]
    public class BrowserHook
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public static IWebDriver driver;

        [BeforeScenario]
        public void OpenBrowser()
        {
                        
            driver = new ChromeDriver("C:\\SeleniumAutomation");
            driver.Navigate().GoToUrl("fb.com");
        }

       
       /* [AfterScenario]
        public void AfterScenario()
        {
        driver.Quit();
        }*/
    }
}