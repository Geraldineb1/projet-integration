using Application.DTOs.Event;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Provider.Validators
{
    public class CreateProviderDtoValidator : AbstractValidator<CreateProviderDto>
    {
        public CreateProviderDtoValidator()
        {
            RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(p => p.Bio)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 500 characters.");
            RuleFor(p => p.Link)
                    .NotEmpty().WithMessage("{PropertyName} is required.")
                    .NotNull()
                    .MaximumLength(250).WithMessage("{PropertyName} must not exceed 50 characters.");
            //RuleFor(p => p.IsActive)
            //        .NotEmpty().WithMessage("{PropertyName} is required.")
            //        .NotNull()
            //        .MaximumLength(250).WithMessage("{PropertyName} must not exceed 50 characters.");
            


        }
    }
}
