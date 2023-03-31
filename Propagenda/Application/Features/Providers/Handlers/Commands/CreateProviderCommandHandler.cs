using Application.DTOs.Provider.Validators;
using Application.Features.Providers.Requests.Commands;
using Application.Persistence.Contracts;
using Application.Persistence.Identity;
using Application.Responses;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Providers.Handlers.Commands
{
    public class CreateProviderCommandHandler : IRequestHandler<CreateProviderCommand, BaseCommandResponse>
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IMapper _mapper;
        private readonly IAuthService _authenticationService;
        IHttpContextAccessor _httpContextAccessor;

        public CreateProviderCommandHandler(IProviderRepository providerRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor, IAuthService authenticationService)
        {
            _providerRepository = providerRepository;
            _mapper = mapper;
            _authenticationService = authenticationService;
            this._httpContextAccessor = httpContextAccessor;
    }
        public async Task<BaseCommandResponse> Handle(CreateProviderCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateProviderDtoValidator();
            var validationResult = await validator.ValidateAsync(request.ProviderDto);
            var userId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(
                    q => q.Type == "uid")?.Value;

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation failed";
                response.Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }


            var provider = _mapper.Map<Provider>(request.ProviderDto);
            provider.ApplicationUserId = userId;
            

            provider = await _providerRepository.Add(provider);
            
            response.Success = true;
            response.Message = "creation Succesful";
            response.Id = provider.Id;

            return response;
        }
    }
}
