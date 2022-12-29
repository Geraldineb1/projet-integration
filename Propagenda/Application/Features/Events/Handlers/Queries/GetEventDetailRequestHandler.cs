using Application.DTOs;
using Application.DTOs.Event;
using Application.DTOs.Service;
using Application.Features.Event.Requests.Queries;
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
    public class GetEventDetailRequestHandler : IRequestHandler<GetEventDetailRequest, EventDto>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        public GetEventDetailRequestHandler(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<EventDto> Handle(GetEventDetailRequest request, CancellationToken cancellationToken)
        {
            var singleEvent = await _eventRepository.Get(request.Id);
            return _mapper.Map<EventDto>(singleEvent);
        }
    }
}
