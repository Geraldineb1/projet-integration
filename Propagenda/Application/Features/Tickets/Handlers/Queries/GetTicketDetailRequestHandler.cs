using Application.DTOs;
using Application.Features.Tickets.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tickets.Handlers.Queries
{
    public class GetTicketDetailRequestHandler : IRequestHandler<GetTicketDetailRequest, TicketDto>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public GetTicketDetailRequestHandler (ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }
        public async Task<TicketDto> Handle(GetTicketDetailRequest request, CancellationToken cancellationToken)
        {
            var ticket = await _ticketRepository.Get(request.Id);
            return _mapper.Map<TicketDto>(ticket);
        }
    }
}
