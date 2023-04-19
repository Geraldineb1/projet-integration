using Application.DTOs.Event.Validators;
using Application.Features.Events.Requests.Commands;
using Application.Persistence.Contracts;
using Application.Responses;
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
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, BaseCommandResponse>
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
        public async Task<BaseCommandResponse> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateEventDtoValidator();
            var validationResult = await validator.ValidateAsync(request.EventDto);
            var userId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(
                    q => q.Type == "uid")?.Value;

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation failed";
                response.Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }

            var eventToCreate = _mapper.Map<Domain.Event>(request.EventDto);
            eventToCreate.ApplicationUserId = userId;
            eventToCreate.IsActive = true;
            eventToCreate.Image = "event-1.jpg";

            eventToCreate = await _eventRepository.Add(eventToCreate);
            response.Success = true;
            response.Message = "creation Succesful";
            response.Id = eventToCreate.Id;

            return response;
        }
    }
}
