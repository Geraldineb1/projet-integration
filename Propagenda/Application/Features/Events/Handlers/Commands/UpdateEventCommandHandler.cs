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
    public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand, Unit>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public UpdateEventCommandHandler(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            /*var serviceType = await _eventRepository.Get(request.EventDto.Id);

            _mapper.Map(request.EventDto, serviceType);

            await _eventRepository.Update(serviceType);*/

            var singleEvent = await _eventRepository.Get(request.Id);

            if (request.EventDto != null)
            {
                _mapper.Map(request.EventDto, singleEvent);

                await _eventRepository.Update(singleEvent);
            }
            else if (request.ChangeEventActivationDto != null)
            {
                await _eventRepository.ChangeActivationStatus(singleEvent, request.ChangeEventActivationDto.IsActive);
            }
            else if (request.ChangeEventApprovalDto != null)
            {
                await _eventRepository.ChangeApprovalStatus(singleEvent, request.ChangeEventApprovalDto.IsApproved);
            }

            return Unit.Value;
        }
    }
}
