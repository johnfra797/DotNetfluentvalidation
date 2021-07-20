using System;
using System.Collections.Generic;
using System.Text;
using DotNetfluentvalidation.Domain;

namespace DotNetfluentvalidation.Application.Services
{
    public interface ITestService
    {
        TestTaker SaveTestTaker(TestTaker testTaker);
    }
}
