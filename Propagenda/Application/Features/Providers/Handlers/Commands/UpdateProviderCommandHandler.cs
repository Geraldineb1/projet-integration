using Application.Features.Providers.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Providers.Handlers.Commands
{
    public class UpdateProviderCommandHandler : IRequestHandler<UpdateProviderCommand, Unit>
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IMapper _mapper;

        public UpdateProviderCommandHandler(IProviderRepository providerRepository, IMapper mapper)
        {
            _providerRepository = providerRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProviderCommand request, CancellationToken cancellationToken)
        {

            var provider = await _providerRepository.Get(request.Id);

            if (request.ProviderDto != null)
            {
                _mapper.Map(request.ProviderDto, provider);

                await _providerRepository.Update(provider);
            }
            else if (request.ChangeProviderActivationDto != null)
            {
                await _providerRepository.ChangeActivationStatus(provider, request.ChangeProviderActivationDto.IsActive);
            }

            return Unit.Value;
        }
    }
}
