using Application.Features.Events.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
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

        public CreateEventCommandHandler(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var eventToCreate = _mapper.Map<Domain.Event>(request.EventDto);

            eventToCreate = await _eventRepository.Add(eventToCreate);

            return eventToCreate.Id;
        }
    }
}
