using Application.DTOs.Provider;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ServiceReservation.Validators
{
   public class CreateServiceReservationDtoValidator : AbstractValidator<CreateServiceReservationDto>
    {
        public CreateServiceReservationDtoValidator()
        {
            RuleFor(p => p.RequestDate)
        .NotEmpty().WithMessage("{PropertyName} is greater than date now.")
        .NotNull();
//            RuleFor(p => p.IsAccepted)
//            .NotEmpty().WithMessage("{PropertyName} is required.")
//            .NotNull();
//            RuleFor(p => p.IsCompleted)
//.NotEmpty().WithMessage("{PropertyName} is required.")
//.NotNull();
            RuleFor(p => p.UserId)
            .NotEmpty().GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.")
            .NotNull();

        }
    }
}
