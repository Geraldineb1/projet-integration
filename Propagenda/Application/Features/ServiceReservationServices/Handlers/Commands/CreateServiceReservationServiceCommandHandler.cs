﻿using Application.DTOs.ServiceReservationService;
using Application.Features.ServiceReservationServices.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceReservationServices.Handlers.Commands
{
    internal class CreateServiceReservationServiceCommandHandler : IRequestHandler<CreateServiceReservationServiceCommand, int>
    {
        private readonly IServiceReservationServiceRepository _serviceReservationServiceRepository;
        private readonly IMapper _mapper;

        public CreateServiceReservationServiceCommandHandler(IServiceReservationServiceRepository serviceReservationServiceRepository, IMapper mapper)
        {
            _serviceReservationServiceRepository = serviceReservationServiceRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateServiceReservationServiceCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateServiceReservationServiceDtoValidator();
            var validationResult = await validator.ValidateAsync(request.ServiceReservationServiceDto);
            if (validationResult.IsValid == false)
                throw new Exception();

            var serviceRerservationService = _mapper.Map<ServiceReservationService>(request.ServiceReservationServiceDto);

            serviceRerservationService = await _serviceReservationServiceRepository.Add(serviceRerservationService);

            return serviceRerservationService.Id;
        }
    }
}
