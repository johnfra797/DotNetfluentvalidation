using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetfluentvalidation.Domain
{
   public class TestTaker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public TestInfo TestInfo { get; set; }
    }
}
