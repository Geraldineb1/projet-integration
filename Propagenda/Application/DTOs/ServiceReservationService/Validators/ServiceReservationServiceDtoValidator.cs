using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ServiceReservationService.Validators
{
    public class ServiceReservationServiceDtoValidator : AbstractValidator<CreateServiceReservationServiceDto>
    {
        public ServiceReservationServiceDtoValidator() 
        {
            RuleFor(p => p.DateService)
                    .NotEmpty().WithMessage("{PropertyName} is greater than date now.")
                    .NotNull();

        }
    }
}
