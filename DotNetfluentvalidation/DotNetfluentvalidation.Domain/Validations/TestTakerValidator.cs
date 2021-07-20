using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace DotNetfluentvalidation.Domain.Validations
{
   public class TestTakerValidator : AbstractValidator<TestTaker>
    {
        public TestTakerValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty().NotNull().MaximumLength(20);
            RuleFor(p => p.LastName).NotEmpty().NotNull().MaximumLength(20);
            RuleFor(p => p.DateOfBirth).Must(IsOver18).WithMessage("Minimum age is 18 for regsitration");
            RuleFor(p => p.TestInfo).SetValidator(new TestInfoValidator());
        }
        private bool IsOver18(DateTime dob)
        {
            return DateTime.Now.Year - dob.Year >=18;
        }
    }
}
