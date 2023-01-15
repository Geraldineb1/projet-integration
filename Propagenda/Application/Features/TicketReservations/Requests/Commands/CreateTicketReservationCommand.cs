using Application.DTOs;
using Application.DTOs.TicketReservation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TicketReservations.Requests.Commands
{
    public class CreateTicketReservationCommand : IRequest<int>
    {
        public CreateTicketReservationDto ticketReservationDto { get; set; }
    }
}
