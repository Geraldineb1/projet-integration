using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Event.Validators
{
    public class CreateEventDtoValidator : AbstractValidator<CreateEventDto>
    {
         public CreateEventDtoValidator()
        {
        RuleFor(p => p.Title)
        .NotEmpty().WithMessage("{PropertyName} is required.")
        .NotNull()
        .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(p => p.EventDate)
                    .NotEmpty().WithMessage("{PropertyName} is greater than date now.")
                    .NotNull();
        RuleFor(p => p.Description)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(250).WithMessage("{PropertyName} must not exceed 50 characters.");
        RuleFor(p => p.VenueName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(250).WithMessage("{PropertyName} must not exceed 50 characters.");
        RuleFor(p => p.VenueAddress)
        .NotEmpty().WithMessage("{PropertyName} is required.")
        .NotNull()
        .MaximumLength(250).WithMessage("{PropertyName} must not exceed 250 characters.");

        RuleFor(p => p.TicketsAmount)
        .NotEmpty().GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.")
        .NotNull();

            RuleFor(p => p.NbSoldTickets)
            .NotEmpty().GreaterThan(0).WithMessage("{PropertyName} must be at least 0.");
        RuleFor(p => p.TicketPrice)
        .NotEmpty().GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.")
        .NotNull();

        }
    }

}
