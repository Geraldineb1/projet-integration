using Application.DTOs.Event;
using Application.Features.Events.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Events.Handlers.Queries
{
    internal class GetEventsByUserRequestHandler : IRequestHandler<GetEventsByUserRequest, List<EventDto>>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        IHttpContextAccessor _httpContextAccessor;

        public GetEventsByUserRequestHandler(IEventRepository eventRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
            this._httpContextAccessor = httpContextAccessor;
        }
        public async Task<List<EventDto>> Handle(GetEventsByUserRequest request, CancellationToken cancellationToken)
        {
            var userId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(
                    q => q.Type == "uid")?.Value;

            var services = await _eventRepository.GetAllEventsByUser(userId);
            return _mapper.Map<List<EventDto>>(services);
        }
    }
}
