﻿using Application.DTOs.Provider.Validators;
using Application.Features.Providers.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Providers.Handlers.Commands
{
    public class CreateProviderCommandHandler : IRequestHandler<CreateProviderCommand, int>
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IMapper _mapper;

        public CreateProviderCommandHandler(IProviderRepository providerRepository, IMapper mapper)
        {
            _providerRepository = providerRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateProviderCommand request, CancellationToken cancellationToken)
        {
            //
            var validator = new CreateProviderDtoValidator();
            var validationResult = await validator.ValidateAsync(request.ProviderTypeDto);
            if (validationResult.IsValid == false)
                throw new Exception();
            //

            var provider = _mapper.Map<Provider>(request.ProviderDto);

            provider = await _providerRepository.Add(provider);

            return provider.Id;
        }
    }
}
