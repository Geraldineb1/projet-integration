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
    public class GetProviderDetailRequestHandler : IRequestHandler<GetProviderDetailRequest, UpdateProviderDto>
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IMapper _mapper;

        public GetProviderDetailRequestHandler(IProviderRepository providerRepository, IMapper mapper)
        {
            _providerRepository = providerRepository;
            _mapper = mapper;
        }
        public async Task<UpdateProviderDto> Handle(GetProviderDetailRequest request, CancellationToken cancellationToken)
        {
            var provider = await _providerRepository.Get(request.Id);
            return _mapper.Map<UpdateProviderDto>(provider);
        }
    }
}
