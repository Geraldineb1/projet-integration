using Application.DTOs;
using Application.DTOs.Ticket;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tickets.Requests.Commands
{
    public class CreateTicketCommand : IRequest<int>
    {
        public CreateTicketDto ticketDto { get; set; }
    }
}
