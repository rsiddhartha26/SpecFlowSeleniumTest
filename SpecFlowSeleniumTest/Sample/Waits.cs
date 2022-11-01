using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumTest.Sample
{
    public class Waits
    {
       
        
        public static void main()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("www.youtube.com");

            //Implicit wait

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Explicit wait

            WebDriverWait Explicitwait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            Explicitwait.IgnoreExceptionTypes(typeof(NoAlertPresentException));

            IWebElement searchbox = Explicitwait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("123")));
            searchbox.Click();
             
            //Fluent Wait

            DefaultWait<IWebDriver> fluentwait = new DefaultWait<IWebDriver>(driver);
            fluentwait.Timeout = TimeSpan.FromSeconds(20);
            fluentwait.PollingInterval = TimeSpan.FromMilliseconds(15);

            fluentwait.IgnoreExceptionTypes(typeof(NoAlertPresentException));

            IWebElement element1 = fluentwait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("123")));

            element1.Click();


           

        }
        

    }
}
