﻿using Application.DTOs.Ticket.Validators;
using Application.Features.Tickets.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tickets.Handlers.Commands
{
    public class CreateTicketCommandHandler : IRequestHandler<CreateTicketCommand, int>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public CreateTicketCommandHandler(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {

            var validator = new CreateTicketDtoValidator();
            var validationResult = await validator.ValidateAsync(request.TicketDto);
            if (validationResult.IsValid == false)
                throw new Exception();

            var ticket = _mapper.Map<Ticket>(request.TicketDto);
            ticket.TicketNumber = RandomNumberGenerator.GetInt32(6);

            ticket = await _ticketRepository.Add(ticket);

            return ticket.Id;
        }
    }
}
