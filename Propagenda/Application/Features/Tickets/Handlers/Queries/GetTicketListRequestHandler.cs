﻿using Application.DTOs;
using Application.DTOs.Ticket;
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
    public class GetTicketListRequestHandler : IRequestHandler<GetTicketListRequest, List<TicketDto>>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public GetTicketListRequestHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }
        public async Task<List<TicketDto>> Handle(GetTicketListRequest request, CancellationToken cancellationToken)
        {
            var tickets = await _ticketRepository.GetAll();
            return _mapper.Map<List<TicketDto>>(tickets);
        }
    }
}
