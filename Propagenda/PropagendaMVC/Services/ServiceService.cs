using AutoMapper;
using PropagendaMVC.Contracts;
using PropagendaMVC.Models;
using PropagendaMVC.Services.Base;

namespace PropagendaMVC.Services
{
    public class ServiceService : BaseHttpService, IServiceService
    {
            private readonly ILocalStorageService _localStorageService;
            private readonly IMapper _mapper;
            private readonly IClient _httpclient;

            public ServiceService(IMapper mapper, IClient httpclient, ILocalStorageService localStorageService) : base(httpclient, localStorageService)
            {
                this._localStorageService = localStorageService;
                this._mapper = mapper;
                this._httpclient = httpclient;
            }

        public async Task<Response<int>> CreateService(CreateServiceVM service)
        {
            try
            {
                var response = new Response<int>();
                CreateServiceDto createService = _mapper.Map<CreateServiceDto>(service);
                AddBearerToken();
                BaseCommandResponse apiResponse = await _client.ServicePOSTAsync(createService);
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

        public async Task<List<ServiceVM>> GetServicesToApprove()
        {
            AddBearerToken();
            var providers = await _client.ToApproveAsync();
            return _mapper.Map<List<ServiceVM>>(services);
        }

        public async Task<Response<int>> DeleteService(int id)
            {
                try
                {
                    AddBearerToken();
                    await _client.ServiceDELETEAsync(id);
                    return new Response<int>() { Success = true };
                }
                catch (ApiException ex)
                {
                    return ConvertApiExceptions<int>(ex);
                }
            }

            public async Task<ServiceVM> GetServiceDetails(int id)
            {
                AddBearerToken();
                var service = await _client.ServiceGETAsync(id);
                return _mapper.Map<ServiceVM>(service);
            }

            public async Task<List<ServiceListVM>> GetServices()
            {
                AddBearerToken();
                var services = await _client.ServiceAllAsync();
                return _mapper.Map<List<ServiceListVM>>(services);
            }

        public async Task<Response<int>> UpdateService(int id, ServiceVM service)
        {
            try
            {
                UpdateServiceDto serviceDto = _mapper.Map<UpdateServiceDto>(service);
                AddBearerToken();
                await _client.ServicePUTAsync(id, serviceDto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<Response<int>> UpdateApproval(int id, ServiceToApproveVM service)
        {
            try
            {

                ChangeServiceApprovalDto serviceDto = _mapper.Map<ChangeServiceApprovalDto>(serviceDto);
                AddBearerToken();
                await _client.ChangeapprovalAsync(id, serviceDto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

    }
}
