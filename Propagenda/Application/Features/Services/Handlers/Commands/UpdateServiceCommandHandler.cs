using Application.Features.Services.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Services.Handlers.Commands
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand, Unit>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public UpdateServiceCommandHandler(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            
            var eventToUpdate = await _serviceRepository.Get(request.Id);

            if (request.ServiceDto != null)
            {
                _mapper.Map(request.ServiceDto, eventToUpdate);

                await _serviceRepository.Update(eventToUpdate);
            }
            else if(request.ChangeServiceActivationDto != null)
            {
                await _serviceRepository.ChangeActivationStatus(eventToUpdate, request.ChangeServiceActivationDto.isActive);
            }
            else if (request.ChangeServiceApprovalDto != null)
            {
                await _serviceRepository.ChangeApprovalStatus(eventToUpdate, request.ChangeServiceApprovalDto.isApproved);
            }


            return Unit.Value;
        }
    }
}
