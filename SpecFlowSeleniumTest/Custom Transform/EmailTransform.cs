using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumTest.Custom_Transform
{
    [Binding]
    public class EmailTransform
    {
        [StepArgumentTransformation(@"(.*) email")]
        public string emailaddress(string email)
        {
            return string.Empty;
        }
    }
}
