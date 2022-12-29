using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceReservations.Requests.Queries
{
    public class GetServiceReservationDetailRequest : IRequest<ServiceReservationDto>
    {
        public int Id { get; set; }
    }
}
