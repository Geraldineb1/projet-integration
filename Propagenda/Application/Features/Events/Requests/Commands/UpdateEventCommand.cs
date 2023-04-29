using Application.DTOs.Event;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Events.Requests.Commands
{
    public class UpdateEventCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateEventDto EventDto { get; set; }

        public ChangeEventApprovalDto ChangeEventApprovalDto { get; set; }
        public ChangeEventActivationDto ChangeEventActivationDto { get; set; }
    }
}
