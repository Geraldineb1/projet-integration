using Application.DTOs.Event;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Events.Requests.Queries
{
    public class GetEventsByUserRequest : IRequest<List<EventDto>>
    {
    }
}
