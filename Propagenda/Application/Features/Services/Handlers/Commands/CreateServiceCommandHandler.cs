using Application.DTOs.Service.Validators;
using Application.Features.Services.Requests.Commands;
using Application.Persistence.Contracts;
using Application.Responses;
using AutoMapper;
using Domain;
using FluentValidation;
using MediatR;

namespace Application.Features.Services.Handlers.Commands
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand, BaseCommandResponse>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IServiceTypeRepository _serviceTRepository;
        private readonly IProviderRepository _provRepository;
        private readonly IMapper _mapper;

        public CreateServiceCommandHandler(IServiceRepository serviceRepository,IServiceTypeRepository serviceTRepository, 
            IProviderRepository provRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _serviceTRepository = serviceTRepository;
            _provRepository = provRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateServiceDtoValidator(_serviceTRepository, _provRepository);
            var validationResult = await validator.ValidateAsync(request.ServiceDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }

            
            var service = _mapper.Map<Service>(request.ServiceDto);
            service.Image = "service.jpg";

            service = await _serviceRepository.Add(service);

            response.Success = true;
            response.Message = "Creation Succesful";
            response.Id = service.Id;

            return response;
        }
    }
}
