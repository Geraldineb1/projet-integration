using Application.Features.TicketReservations.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TicketReservations.Handlers.Commands
{
    public class CreateTicketReservationCommandHandler : IRequestHandler<CreateTicketReservationCommand, int>
    {
        private readonly ITicketReservationRepository _ticketReservationRepository;
        private readonly IMapper _mapper;

        public CreateTicketReservationCommandHandler(ITicketReservationRepository ticketReservationRepository, IMapper mapper)
        {
            _ticketReservationRepository = ticketReservationRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateTicketReservationCommand request, CancellationToken cancellationToken)
        {
            var ticketRerservation = _mapper.Map<TicketReservation>(request.ticketReservationDto);

            ticketRerservation = await _ticketReservationRepository.Add(ticketRerservation);

            return ticketRerservation.Id;
        }
    }
}
