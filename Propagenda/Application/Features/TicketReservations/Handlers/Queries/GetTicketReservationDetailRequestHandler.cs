using Application.DTOs;
using Application.Features.TicketReservations.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TicketReservations.Handlers.Queries
{
    internal class GetTicketReservationDetailRequestHandler : IRequestHandler<GetTicketReservationDetailRequest, TicketReservationDto>
    {
        private readonly ITicketReservationRepository _tRRepository;
        private readonly IMapper _mapper;

        public GetTicketReservationDetailRequestHandler(ITicketReservationRepository tRRepository, IMapper mapper)
        {
            _tRRepository = tRRepository;
            _mapper = mapper;
        }
        public async Task<TicketReservationDto> Handle(GetTicketReservationDetailRequest request, CancellationToken cancellationToken)
        {
            var ticketReservation = await _tRRepository.Get(request.Id);
            return _mapper.Map<TicketReservationDto>(ticketReservation);
        }
    }
}
