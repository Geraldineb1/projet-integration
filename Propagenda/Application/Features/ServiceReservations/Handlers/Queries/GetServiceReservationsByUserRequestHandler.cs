using Application.DTOs.ServiceReservation;
using Application.Features.ServiceReservations.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceReservations.Handlers.Queries
{
    public class GetServiceReservationsByUserRequestHandler : IRequestHandler<GetServiceReservationsByUserRequest, List<ServiceReservationDto>>
    {
        private readonly IServiceReservationRepository _serviceReservationRepository;
        private readonly IMapper _mapper;
        IHttpContextAccessor _httpContextAccessor;

        public GetServiceReservationsByUserRequestHandler(IServiceReservationRepository serviceReservationRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _serviceReservationRepository = serviceReservationRepository;
            _mapper = mapper;
            this._httpContextAccessor = httpContextAccessor;
        }
        public async Task<List<ServiceReservationDto>> Handle(GetServiceReservationsByUserRequest request, CancellationToken cancellationToken)
        {
            var userId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(
                    q => q.Type == "uid")?.Value;

            var serviceReservations = await _serviceReservationRepository.GetAllByUser(userId);
            return _mapper.Map<List<ServiceReservationDto>>(serviceReservations);
        }
    }
}
