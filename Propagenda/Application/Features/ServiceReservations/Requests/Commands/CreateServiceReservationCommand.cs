using Application.DTOs.ServiceReservation;
using Application.Responses;
using MediatR;

namespace Application.Features.ServiceReservations.Requests.Commands
{
    public class CreateServiceReservationCommand : IRequest<BaseCommandResponse>
    {
        public CreateServiceReservationDto ServiceReservationDto { get; set; }
    }
}
