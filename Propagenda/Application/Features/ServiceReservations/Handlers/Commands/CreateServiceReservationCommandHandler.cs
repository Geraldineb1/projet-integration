using Application.DTOs.ServiceReservation.Validators;
using Application.Features.ServiceReservations.Requests.Commands;
using Application.Persistence.Contracts;
using Application.Responses;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceReservations.Handlers.Commands
{
    public class CreateServiceReservationCommandHandler : IRequestHandler<CreateServiceReservationCommand, BaseCommandResponse>
    {
        private readonly IServiceReservationRepository _serviceReservationRepository;
        private readonly IMapper _mapper;
        IHttpContextAccessor _httpContextAccessor;
        private readonly IServiceServiceReservationRepository _ssRepository;

        public CreateServiceReservationCommandHandler(IServiceReservationRepository serviceReservationRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor, IServiceServiceReservationRepository serviceServiceReservationRepository)
        {
            _serviceReservationRepository = serviceReservationRepository;
            _mapper = mapper;
            this._httpContextAccessor = httpContextAccessor;
            _ssRepository = serviceServiceReservationRepository;
        }
        public async Task<BaseCommandResponse> Handle(CreateServiceReservationCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateServiceReservationDtoValidator();
            var validationResult = await validator.ValidateAsync(request.ServiceReservationDto);
            var userId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(
                    q => q.Type == "uid")?.Value;

            if (validationResult.IsValid == false) 
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }

            var serviceReservation = _mapper.Map<ServiceReservation>(request.ServiceReservationDto);
            serviceReservation.RequestDate = DateTime.Now;
            serviceReservation.IsAccepted = false;
            serviceReservation.IsCompleted = false;
            serviceReservation.ApplicationUserId = userId;

            serviceReservation = await _serviceReservationRepository.Add(serviceReservation);

            ServiceServiceReservation ssr = new ServiceServiceReservation { ServicesId = request.ServiceReservationDto.ServiceId, ServiceReservationsId = serviceReservation.Id };
            await _ssRepository.Add(ssr);


            response.Success = true;
            response.Message = "Creation Succesful";
            response.Id = serviceReservation.Id;

            return response;
        }
    }
}
