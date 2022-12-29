using Application.DTOs;
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
    public class GetProviderListRequestHandler : IRequestHandler<GetProviderListRequest, List<ProviderDto>>
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IMapper _mapper;

        public GetProviderListRequestHandler(IProviderRepository providerRepository, IMapper mapper)
        {
            _providerRepository = providerRepository;
            _mapper = mapper;
        }
        public async Task<List<ProviderDto>> Handle(GetProviderListRequest request, CancellationToken cancellationToken)
        {
            var providers = await _providerRepository.GetAll();
            return _mapper.Map<List<ProviderDto>>(providers);
        }
    }
}
