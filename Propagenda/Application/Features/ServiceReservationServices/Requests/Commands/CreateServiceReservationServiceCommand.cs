using Application.DTOs;
using Application.DTOs.ServiceReservationService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceReservationServices.Requests.Commands
{
    internal class CreateServiceReservationServiceCommand : IRequest<int>
    {
        public CreateServiceReservationServiceDto ServiceReservationServiceDto { get; set; }
    }
}
