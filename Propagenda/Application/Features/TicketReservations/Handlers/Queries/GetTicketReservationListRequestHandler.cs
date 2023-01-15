using Application.DTOs;
using Application.DTOs.TicketReservation;
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
    internal class GetTicketReservationListRequestHandler : IRequestHandler<GetTicketReservationListRequest, List<TicketReservationDto>>
    {
        private readonly ITicketReservationRepository _tRRepository;
        private readonly IMapper _mapper;

        public GetTicketReservationListRequestHandler(ITicketReservationRepository tRRepository, IMapper mapper)
        {
            _tRRepository = tRRepository;
            _mapper = mapper;
        }
        public async Task<List<TicketReservationDto>> Handle(GetTicketReservationListRequest request, CancellationToken cancellationToken)
        {
            var ticketReservations = await _tRRepository.GetAll();
            return _mapper.Map<List<TicketReservationDto>>(ticketReservations);
        }
    }
}
