using Application.DTOs.ServiceReservation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceReservations.Requests.Commands
{
    public class UpdateServiceReservationCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public ServiceReservationDto ServiceReservationDto { get; set; }
        public ChangeServiceReservationApprovalDto  ChangeServiceReservationApprovalDto { get; set; }
        public ChangeServiceReservationCompletionDto ChangeServiceReservationCompletionDto { get; set; }
    }
}
