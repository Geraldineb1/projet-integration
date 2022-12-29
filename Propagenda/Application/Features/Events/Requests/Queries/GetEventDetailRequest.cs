using Application.DTOs;
using Application.DTOs.Event;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Event.Requests.Queries
{
    public class GetEventDetailRequest : IRequest<EventDto>
    {
        public int Id { get; set; }
    }
}
