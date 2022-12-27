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
    public class GetServiceListRequestHandler : IRequestHandler<GetServiceListRequest, List<ServiceListDto>>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;
        public GetServiceListRequestHandler(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }
        public async Task<List<ServiceListDto>> Handle(GetServiceListRequest request, CancellationToken cancellationToken)
        {
            var services = await _serviceRepository.GetAll();
            return _mapper.Map<List<ServiceListDto>>(services);
        }
    }
}
