using AutoMapper;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Services
{
    public class ProviderService : BaseHttpService, IProviderService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IMapper _mapper;
        private readonly IClient _httpclient;

        public ProviderService(IMapper mapper, IClient httpclient, ILocalStorageService localStorageService) : base(httpclient, localStorageService)
        {
            this._localStorageService = localStorageService;
            this._mapper = mapper;
            this._httpclient = httpclient;
        }

        public async Task<Response<int>> CreateProvider(CreateProviderVM provider)
        {
            try
            {
                var response = new Response<int>();
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

        public async Task<ViewProviderVM> GetProviderDetails(int id)
        {
            AddBearerToken();
            var provider = await _client.ProviderGETAsync(id);
            return _mapper.Map<ViewProviderVM>(provider);
        }

        public async Task<List<ProviderVM>> GetProviders()
        {
            AddBearerToken();
            var providers = await _client.ProviderAllAsync();
            return _mapper.Map<List<ProviderVM>>(providers);
        }

        /*public async Task<Response<int>> UpdateServiceType(int id, ServiceTypeVM serviceType)
        {
            try
            {
                ServiceTypeDto serviceTypeDto = _mapper.Map<ServiceTypeDto>(serviceType);
                AddBearerToken();
                await _client.ServiceTypePUTAsync(id.ToString(), serviceTypeDto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }*/
    }
}
