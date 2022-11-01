using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumTest.Context
{
    public class DriverContext
    {
       public ChromeDriver driver;

        public DriverContext(ChromeDriver driver)
        {
            this.driver = new ChromeDriver();
        }

        public static implicit operator DriverContext(ChromeDriver v)
        {
            throw new NotImplementedException();
        }
    }
}
