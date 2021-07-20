﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation.Results;

namespace DotNetfluentvalidation.Application.Exceptions
{
    public class ValidationException:ApplicationException
    {
        public List<string> ValidationErrors { get; set; }
        public ValidationException(ValidationResult validationResult)
        {
            ValidationErrors = new List<string>();
            foreach (var validationError in validationResult.Errors)
            {
                ValidationErrors.Add(validationError.ErrorMessage);
            }
        }
    }
}
