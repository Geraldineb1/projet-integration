using Application.DTOs.ServiceType.Validators;
using Application.Exceptions;
using Application.Features.ServiceTypes.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceTypes.Handlers.Commands
{
    public class CreateServiceTypeCommandHandler : IRequestHandler<CreateServiceTypeCommand, int>
    {
        private readonly IServiceTypeRepository _serviceTypeRepository;
        private readonly IMapper _mapper;

        public CreateServiceTypeCommandHandler(IServiceTypeRepository serviceTypeRepository, IMapper mapper)
        {
            _serviceTypeRepository = serviceTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateServiceTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateServiceTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.ServiceTypeDto);

            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult);
            }

            var serviceType = _mapper.Map<ServiceType>(request.ServiceTypeDto);

            serviceType = await _serviceTypeRepository.Add(serviceType);

            return serviceType.Id;
        }
    }
}
