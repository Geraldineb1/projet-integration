using Application.DTOs;
using Application.DTOs.ServiceReservation;
using Application.Features.ServiceReservations.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceReservations.Handlers.Queries
{
    public class GetServiceReservationDetailRequestHandler : IRequestHandler<GetServiceReservationDetailRequest, ServiceReservationDto>
    {
        private readonly IServiceReservationRepository _sRRepository;
        private readonly IMapper _mapper;

        public GetServiceReservationDetailRequestHandler(IServiceReservationRepository sRRepository, IMapper mapper)
        {
            _sRRepository = sRRepository;
            _mapper = mapper;
        }
        public async Task<ServiceReservationDto> Handle(GetServiceReservationDetailRequest request, CancellationToken cancellationToken)
        {
            var serviceReservations = await _sRRepository.Get(request.Id);
            return _mapper.Map<ServiceReservationDto>(serviceReservations);
        }
    }
}
