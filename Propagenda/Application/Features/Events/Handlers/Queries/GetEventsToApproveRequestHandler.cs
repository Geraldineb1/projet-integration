using Application.DTOs.Event;
using Application.Features.Events.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Events.Handlers.Queries
{
    internal class GetEventsToApproveRequestHandler : IRequestHandler<GetEventsToApproveRequest, List<EventDto>>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public GetEventsToApproveRequestHandler(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<List<EventDto>> Handle(GetEventsToApproveRequest request, CancellationToken cancellationToken)
        {
            var events = await _eventRepository.GetAllEventsToApprove();
            return _mapper.Map<List<EventDto>>(events);
        }
    }
}
