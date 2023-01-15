using Application.Features.ServiceTypes.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceTypes.Handlers.Commands
{
    public class UpdateServiceTypeCommandHandler : IRequestHandler<UpdateServiceTypeCommand, Unit>
    {
        private readonly IServiceTypeRepository _serviceTypeRepository;
        private readonly IMapper _mapper;

        public UpdateServiceTypeCommandHandler(IServiceTypeRepository serviceTypeRepository, IMapper mapper)
        {
            _serviceTypeRepository = serviceTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateServiceTypeCommand request, CancellationToken cancellationToken)
        {
            var eventToUpdate = await _serviceTypeRepository.Get(request.ServiceTypeDto.Id);

            _mapper.Map(request.ServiceTypeDto, eventToUpdate);

            await _serviceTypeRepository.Update(eventToUpdate);

            return Unit.Value;
        }
    }
}
