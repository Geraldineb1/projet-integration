using Application.DTOs.Provider;
using Application.Features.Providers.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Providers.Handlers.Queries
{
    public class GetProviderToApproveListRequestHandler : IRequestHandler<GetProvidersToApproveListRequest, List<ProviderDto>>
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IMapper _mapper;

        public GetProviderToApproveListRequestHandler(IProviderRepository providerRepository, IMapper mapper)
        {
            _providerRepository = providerRepository;
            _mapper = mapper;
        }
        public async Task<List<ProviderDto>> Handle(GetProvidersToApproveListRequest request, CancellationToken cancellationToken)
        {
            var providers = await _providerRepository.GetAllToApprove();
            return _mapper.Map<List<ProviderDto>>(providers);
        }
    }
}
