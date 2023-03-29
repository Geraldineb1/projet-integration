using Application.DTOs.Event.Validators;
using Application.Features.Events.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Events.Handlers.Commands
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, int>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CreateEventCommandHandler(IEventRepository eventRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<int> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateEventDtoValidator();
            var validationResult = await validator.ValidateAsync(request.EventDto);
            var userId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(
                    q => q.Type == "uid")?.Value;

            if (validationResult.IsValid == false)
                throw new Exception();

            var eventToCreate = _mapper.Map<Domain.Event>(request.EventDto);
            eventToCreate.ApplicationUserId = userId;

            eventToCreate = await _eventRepository.Add(eventToCreate);

            return eventToCreate.Id;
        }
    }
}
