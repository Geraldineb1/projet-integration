using Application.DTOs;
using Application.DTOs.Event;
using Application.DTOs.Service;
using Application.Features.Events.Requests.Queries;
using Application.Features.Services.Requests.Queries;
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
    public class GetEventListRequestHandler : IRequestHandler<GetEventListRequest, List<EventDto>>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        public GetEventListRequestHandler(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<List<EventDto>> Handle(GetEventListRequest request, CancellationToken cancellationToken)
        {
            var events = await _eventRepository.GetAll();
            return _mapper.Map<List<EventDto>>(events);
        }
    }
}
