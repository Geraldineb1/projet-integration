using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tickets.Requests.Queries
{
    public class GetTicketDetailRequest : IRequest<TicketDto>
    {
        public int Id { get; set; }
    }
}
