using Application.DTOs.Event;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Ticket.Validators
{
    public class CreateTicketDtoValidator : AbstractValidator<CreateTicketDto>
    {
        public CreateTicketDtoValidator() 
        {
            RuleFor(p => p.EventId)
            .NotEmpty().GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.")
            .NotNull();

            RuleFor(p => p.TicketReservationId)
            .NotEmpty().GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.")
            .NotNull();

        }
    }
}
