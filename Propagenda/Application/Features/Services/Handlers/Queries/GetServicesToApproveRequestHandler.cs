using Application.DTOs.Service;
using Application.Features.Services.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Services.Handlers.Queries
{
    public class GetServicesToApproveRequestHandler : IRequestHandler<GetServicesToApproveRequest, List<ServiceDto>>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public GetServicesToApproveRequestHandler(IServiceRepository servicesRepository, IMapper mapper)
        {
            _serviceRepository = servicesRepository;
            _mapper = mapper;
        }
        public async Task<List<ServiceDto>> Handle(GetServicesToApproveRequest request, CancellationToken cancellationToken)
        {
            var providers = await _serviceRepository.GetAllServicesToApprove();
            return _mapper.Map<List<ServiceDto>>(providers);
        }
    }
}
