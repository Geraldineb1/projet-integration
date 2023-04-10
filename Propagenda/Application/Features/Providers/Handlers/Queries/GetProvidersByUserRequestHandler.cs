using Application.DTOs.Provider;
using Application.Features.Providers.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Providers.Handlers.Queries
{
    public class GetProvidersByUserRequestHandler : IRequestHandler<GetProvidersByUserRequest, List<ProviderDto>>
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IMapper _mapper;
        IHttpContextAccessor _httpContextAccessor;

        public GetProvidersByUserRequestHandler(IProviderRepository providerRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _providerRepository = providerRepository;
            _mapper = mapper;
            this._httpContextAccessor = httpContextAccessor;
        }
        public async Task<List<ProviderDto>> Handle(GetProvidersByUserRequest request, CancellationToken cancellationToken)
        {
            var userId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(
                    q => q.Type == "uid")?.Value;

            var providers = await _providerRepository.GetAllByUser(userId);
            return _mapper.Map<List<ProviderDto>>(providers);
        }
    }
}
