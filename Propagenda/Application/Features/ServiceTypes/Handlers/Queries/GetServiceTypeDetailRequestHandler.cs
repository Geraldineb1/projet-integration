using Application.DTOs;
using Application.Features.ServiceTypes.Requests;
using Application.Features.ServiceTypes.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ServiceTypes.Handlers.Queries
{
    public class GetServiceTypeDetailRequestHandler : IRequestHandler<GetServiceTypeDetailRequest, ServiceTypeDto>
    {
        private readonly IServiceTypeRepository _serviceTypeRepository;
        private readonly IMapper _mapper;

        public GetServiceTypeDetailRequestHandler(IServiceTypeRepository serviceTypeRepository, IMapper mapper)
        {
            _serviceTypeRepository = serviceTypeRepository;
            _mapper = mapper;
        }

        public async Task<ServiceTypeDto> Handle(GetServiceTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var serviceType = await _serviceTypeRepository.Get(request.Id);
            return _mapper.Map<ServiceTypeDto>(serviceType);
        }
    }
}
