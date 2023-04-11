using Application.DTOs.Service;
using Application.Features.Services.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Services.Handlers.Queries
{
    public class GetServicesByUserRequestHandler : IRequestHandler<GetServicesByUserRequest, List<ServiceDto>>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;
        IHttpContextAccessor _httpContextAccessor;

        public GetServicesByUserRequestHandler(IServiceRepository serviceRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
            this._httpContextAccessor = httpContextAccessor;
        }
        public async Task<List<ServiceDto>> Handle(GetServicesByUserRequest request, CancellationToken cancellationToken)
        {
            var userId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(
                    q => q.Type == "uid")?.Value;

            var services = await _serviceRepository.GetAllServicesByUser(userId);
            return _mapper.Map<List<ServiceDto>>(services);
        }
    }
}
