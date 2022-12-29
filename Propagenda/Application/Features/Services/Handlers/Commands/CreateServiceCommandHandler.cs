using Application.Features.Services.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Services.Handlers.Commands
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand, int>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public CreateServiceCommandHandler(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var serviceRerservation = _mapper.Map<Service>(request.serviceDto);

            serviceRerservation = await _serviceRepository.Add(serviceRerservation);

            return serviceRerservation.Id;
        }
    }
}
