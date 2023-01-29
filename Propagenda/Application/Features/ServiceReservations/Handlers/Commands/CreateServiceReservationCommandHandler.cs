using Application.DTOs.ServiceReservation.Validators;
using Application.Features.ServiceReservations.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceReservations.Handlers.Commands
{
    public class CreateServiceReservationCommandHandler : IRequestHandler<CreateServiceReservationCommand, int>
    {
        private readonly IServiceReservationRepository _serviceReservationRepository;
        private readonly IMapper _mapper;

        public CreateServiceReservationCommandHandler(IServiceReservationRepository serviceReservationRepository, IMapper mapper)
        {
            _serviceReservationRepository = serviceReservationRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateServiceReservationCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateServiceReservationDtoValidator();
            var validationResult = await validator.ValidateAsync(request.ServiceReservationDto);
            if (validationResult.IsValid == false)
                throw new Exception();

            var serviceRerservation = _mapper.Map<ServiceReservation>(request.ServiceReservationDto);

            serviceRerservation = await _serviceReservationRepository.Add(serviceRerservation);

            return serviceRerservation.Id;
        }
    }
}
