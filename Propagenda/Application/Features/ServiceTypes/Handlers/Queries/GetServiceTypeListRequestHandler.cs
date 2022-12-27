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
    internal class GetServiceTypeListRequestHandler : IRequestHandler<GetServiceTypeListRequest, List<ServiceTypeDto>>
    {
        private readonly IServiceTypeRepository _serviceTypeRepository;
        private readonly IMapper _mapper;

        public GetServiceTypeListRequestHandler(IServiceTypeRepository serviceTypeRepository, IMapper mapper)
        {
            _serviceTypeRepository = serviceTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<ServiceTypeDto>> Handle(GetServiceTypeListRequest request, CancellationToken cancellationToken)
        {
            var serviceTypes = await _serviceTypeRepository.GetAll();
            return _mapper.Map<List<ServiceTypeDto>>(serviceTypes);
        }
    }
}
