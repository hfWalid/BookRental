﻿using BookRental.Web.Infrastructure.Validators;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BookRental.Web.Models
{
    public class RegistrationViewModel : IValidatableObject
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new RegistrationViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}