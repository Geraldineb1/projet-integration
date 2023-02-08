using AutoMapper;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Services
{
    public class ServiceTypeService : BaseHttpService, IServiceTypeService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IMapper _mapper;
        private readonly IClient _httpclient;

        public ServiceTypeService(IMapper mapper, IClient httpclient, ILocalStorageService localStorageService) : base(httpclient, localStorageService)
        {
            this._localStorageService = localStorageService;
            this._mapper = mapper;
            this._httpclient = httpclient;
        }

        public async Task<Response<int>> CreateServiceType(CreateServiceTypeVM serviceType)
        {
            try
            {
                var response = new Response<int>();
                CreateServiceTypeDto createServiceType = _mapper.Map<CreateServiceTypeDto>(serviceType);
                AddBearerToken();
                var apiResponse = await _client.ServiceTypePOSTAsync(createServiceType);
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

        public async Task<Response<int>> DeleteServiceType(int id)
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
        }

        public async Task<ServiceTypeVM> GetServiceTypeDetails(int id)
        {
            AddBearerToken();
            var serviceType = await _client.ServiceTypeGETAsync(id);
            return _mapper.Map<ServiceTypeVM>(serviceType);
        }

        public async Task<List<ServiceTypeVM>> GetServiceTypes()
        { 
            AddBearerToken();
            var serviceTypes = await _client.ServiceTypeAllAsync();
            return _mapper.Map<List<ServiceTypeVM>>(serviceTypes);
        }

        public async Task<Response<int>> UpdateServiceType(int id, ServiceTypeVM serviceType)
        {
            try
            {
                ServiceTypeDto serviceTypeDto = _mapper.Map<ServiceTypeDto>(serviceType);
                AddBearerToken();
                await _client.ServiceTypePUTAsync(id.ToString(),serviceTypeDto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }
    }
}
