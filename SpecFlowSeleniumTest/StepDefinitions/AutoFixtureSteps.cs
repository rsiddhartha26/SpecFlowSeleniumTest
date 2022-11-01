using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumTest.StepDefinitions
{
    [Binding]
    public class AutoFixtureSteps
    {
        [Given(@"I type the random user details")]
        public void GivenITypeTheRandomUserDetails()
        {
            var person = new Fixture().Create<User>();
            Console.WriteLine(person.Name);
            Console.WriteLine(person.address);
            Console.WriteLine(person.email);
        }

        [Given(@"I type email (.* email)")]
        public void GivenITypeEmail(string email)
        {
            Console.WriteLine(email);
        }

      

    }


    public record User
    {
        public string Name { get; set; }
        public string address { get; set; }

        public string email  { get; set; }
    }

   }

