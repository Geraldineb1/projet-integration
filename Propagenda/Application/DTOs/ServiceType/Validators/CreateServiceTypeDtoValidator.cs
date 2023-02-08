using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ServiceType.Validators
{
    public class CreateServiceTypeDtoValidator : AbstractValidator<CreateServiceTypeDto>
    {
        public CreateServiceTypeDtoValidator()
        {
            RuleFor(p => p.Label)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(p => p.Image)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}
