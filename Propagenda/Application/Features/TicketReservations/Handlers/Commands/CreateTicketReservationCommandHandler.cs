using Application.DTOs.TicketReservation.Validators;
using Application.Features.TicketReservations.Requests.Commands;
using Application.Persistence.Contracts;
using Application.Responses;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TicketReservations.Handlers.Commands
{
    public class CreateTicketReservationCommandHandler : IRequestHandler<CreateTicketReservationCommand, BaseCommandResponse>
    {
        private readonly ITicketReservationRepository _ticketReservationRepository;
        private readonly IMapper _mapper;
        private readonly ITicketRepository _ticketRepository;
        private readonly IEventRepository _eventRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CreateTicketReservationCommandHandler(ITicketReservationRepository ticketReservationRepository, IEventRepository eventRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _ticketReservationRepository = ticketReservationRepository;
            _mapper = mapper;
            this._httpContextAccessor = httpContextAccessor;
            this._eventRepository = eventRepository;
        }
        public async Task<BaseCommandResponse> Handle(CreateTicketReservationCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateTicketReservationDtoValidator();
            var validationResult = await validator.ValidateAsync(request.TicketReservationDto);
            var userId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(q => q.Type == "uid")?.Value;

            var singleEvent = await _eventRepository.Get(request.TicketReservationDto.EventId);
            var ticketsLeft = (int)(singleEvent.TicketsAmount - singleEvent.NbSoldTickets);
            if (ticketsLeft < request.TicketReservationDto.TotalNbTickets)
            {
                validationResult.Errors.Add(new FluentValidation.Results.ValidationFailure(nameof(request.TicketReservationDto.TotalNbTickets), "Not enough tickets"));
            }

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var ticketRerservation = _mapper.Map<TicketReservation>(request.TicketReservationDto);
                ticketRerservation.ApplicationUserId = userId;

                ticketRerservation = await _ticketReservationRepository.Add(ticketRerservation);

                response.Success = true;
                response.Message = "creation Succesful";
                response.Id = ticketRerservation.Id;
            }


            

            return response;
        }
    }
}
