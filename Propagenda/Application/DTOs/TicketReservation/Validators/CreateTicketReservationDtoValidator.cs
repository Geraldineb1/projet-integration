using Application.DTOs.Event;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.TicketReservation.Validators
{
    public class CreateTicketReservationDtoValidator : AbstractValidator<CreateTicketReservationDto>
    {
        public CreateTicketReservationDtoValidator() 
        {
            RuleFor(p => p.TotalNbTickets)
            .NotEmpty().GreaterThan(0).WithMessage("{PropertyName} must at least 0.")
            .NotNull();
        }
    }
}
