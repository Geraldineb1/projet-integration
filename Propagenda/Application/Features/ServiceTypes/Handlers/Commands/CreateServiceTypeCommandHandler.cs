using Application.DTOs.ServiceReservation.Validators;
using Application.DTOs.ServiceType.Validators;
using Application.Exceptions;
using Application.Features.ServiceTypes.Requests.Commands;
using Application.Persistence.Contracts;
using Application.Responses;
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
    public class CreateServiceTypeCommandHandler : IRequestHandler<CreateServiceTypeCommand, BaseCommandResponse>
    {
        private readonly IServiceTypeRepository _serviceTypeRepository;
        private readonly IMapper _mapper;

        public CreateServiceTypeCommandHandler(IServiceTypeRepository serviceTypeRepository, IMapper mapper)
        {
            _serviceTypeRepository = serviceTypeRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateServiceTypeCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateServiceTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.ServiceTypeDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation failed";
                response.Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }

            var serviceType = _mapper.Map<ServiceType>(request.ServiceTypeDto);

            serviceType = await _serviceTypeRepository.Add(serviceType);
            response.Success = true;
            response.Message = "creation Succesful";
            response.Id = serviceType.Id;

            return response;
        }
    }
}
