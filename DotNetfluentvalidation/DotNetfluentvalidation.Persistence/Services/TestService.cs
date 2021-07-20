using System;
using System.Collections.Generic;
using System.Text;
using DotNetfluentvalidation.Application.Exceptions;
using DotNetfluentvalidation.Application.Services;
using DotNetfluentvalidation.Domain;
using DotNetfluentvalidation.Domain.Validations;

namespace DotNetfluentvalidation.Persistence.Services
{
    public class TestService : ITestService
    {
        public TestTaker SaveTestTaker(TestTaker testTaker)
        {
            var validationService = new TestTakerValidator();
            var validationResult = validationService.Validate(testTaker);

            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }
            return testTaker;
        }
    }
}
