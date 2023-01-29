using Application.DTOs;
using Application.DTOs.ServiceReservation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceReservations.Requests.Commands
{
    public class CreateServiceReservationCommand : IRequest<int>
    {
        public CreateServiceReservationDto ServiceReservationDto { get; set; }
    }
}
