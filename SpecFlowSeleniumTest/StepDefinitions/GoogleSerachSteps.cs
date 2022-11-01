using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpecFlowSeleniumTest.StepDefinitions
{

    [Binding]
    public class GoogleSerachSteps
    {
        public IWebDriver driver;

        [Given(@"I have navigated to google page")]
        public void GivenIHaveNavigatedToGooglePage()
        {
            driver = new ChromeDriver();
           // Browser.Current.Navigate().GoToUrl("www.google.com");


        }

        [Given(@"I see google page is fully loaded")]
        public void GivenISeeGooglePageIsFullyLoaded()
        {
           
            //Boolean Visible = driver.FindElement(By.Name("q")).Displayed;
            if(true)
            {
                Console.WriteLine("Page loaded");

            }
            else
            {
                Console.WriteLine("Page not loaded");
            }
        }


    }
}
