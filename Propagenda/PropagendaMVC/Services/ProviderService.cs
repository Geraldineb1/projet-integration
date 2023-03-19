using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace PropagendaMVC.Services
{
    public class ProviderService : BaseHttpService, IProviderService
    {
        
        private readonly IMapper _mapper;
        private readonly IClient _httpclient;
        private JwtSecurityTokenHandler _tokenHandler;

        public ProviderService(IMapper mapper, IClient httpclient, ILocalStorageService localStorageService) : base(httpclient, localStorageService)
        {
            
            this._mapper = mapper;
            this._httpclient = httpclient;
            this._tokenHandler = new JwtSecurityTokenHandler();
        }

        public async Task<Response<int>> CreateProvider(CreateProviderVM provider)
        {
            try
            {
                var response = new Response<int>();
                var token = _localStorage.GetStorageValue<String>("token");
                if (token != string.Empty)
                {
                    //Get Claims from token and Build auth user object
                    var tokenContent = _tokenHandler.ReadJwtToken(token);
                    var claims = ParseClaims(tokenContent);
                    var userId = claims[3].Value;
                    provider.ApplicationUserId = userId;
                }


                CreateProviderDto createProvider = _mapper.Map<CreateProviderDto>(provider);
                
                AddBearerToken();
                
                BaseCommandResponse apiResponse = await _client.ProviderPOSTAsync(createProvider);
                if (apiResponse.Success)
                {
                    response.Data = apiResponse.Id;
                    response.Success = true;
                }
                else
                {
                    foreach (var error in apiResponse.Errors)
                    {
                        response.ValidationErrors += error + Environment.NewLine;
                    }
                }
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        /*public async Task<Response<int>> DeleteServiceType(int id)
        {
            try
            {
                AddBearerToken();
                await _client.ServiceTypeDELETEAsync(id);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }*/

        public async Task<UpdateProviderVM> GetProviderDetails(int id)
        {
            AddBearerToken();
            var provider = await _client.ProviderGETAsync(id);
            
            return _mapper.Map<UpdateProviderVM>(provider);
        }

        public async Task<List<ProviderVM>> GetProviders()
        {
            AddBearerToken();
            var providers = await _client.ProviderAllAsync();
            return _mapper.Map<List<ProviderVM>>(providers);
        }

        public async Task<List<ProviderVM>> GetProvidersToApprove()
        {
            AddBearerToken();
            var providers = await _client.ProviderAllAsync();
            return _mapper.Map<List<ProviderVM>>(providers);
        }

        public async Task<Response<int>> UpdateProvider(int id, UpdateProviderVM provider)
        {
            try
            {
                
                UpdateProviderDto providerDto = _mapper.Map<UpdateProviderDto>(provider);
                AddBearerToken();
                await _client.ProviderPUTAsync(id, providerDto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        private IList<Claim> ParseClaims(JwtSecurityToken tokenContent)
        {
            var claims = tokenContent.Claims.ToList();
            claims.Add(new Claim(ClaimTypes.Name, tokenContent.Subject));
            return claims;
        }
    }
}
