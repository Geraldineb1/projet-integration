using Application.DTOs.ServiceReservation;
using MediatR;

namespace Application.Features.ServiceReservations.Requests.Commands
{
    public class CreateServiceReservationCommand : IRequest<int>
    {
        public CreateServiceReservationDto ServiceReservationDto { get; set; }
    }
}
