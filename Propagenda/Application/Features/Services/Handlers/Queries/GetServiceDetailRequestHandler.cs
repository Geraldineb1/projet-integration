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
    public class GetServiceDetailRequestHandler : IRequestHandler<GetServiceDetailRequest, ServiceDto>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public GetServiceDetailRequestHandler(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }

        public async Task<ServiceDto> Handle(GetServiceDetailRequest request, CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.Get(request.Id);
            return _mapper.Map<ServiceDto>(service);
        }
    }
}
