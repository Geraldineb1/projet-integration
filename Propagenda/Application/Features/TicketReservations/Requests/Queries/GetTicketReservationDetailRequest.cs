﻿using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TicketReservations.Requests.Queries
{
    public class GetTicketReservationDetailRequest : IRequest<TicketReservationDto>
    {
        public int Id { get; set; }
    }
}
